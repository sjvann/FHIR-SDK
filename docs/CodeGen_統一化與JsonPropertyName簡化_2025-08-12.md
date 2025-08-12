## CodeGen 產生器統一化與 JsonPropertyName 簡化 調整記錄（2025-08-12）

### 摘要
本次工作完成兩項目標：
- 產生器「統一化」：Resource 層與 Backbone 層分別使用正確的屬性模板與變更通知機制，避免混用。
- System.Text.Json 屬性簡化：.NET 9 已內建 System.Text.Json，將 [System.Text.Json.Serialization.JsonPropertyName] 統一簡化為 [JsonPropertyName]，並在輸出檔案加入 using System.Text.Json.Serialization;。

### 變更動機
- 先前產出中，部份 Backbone 類別仍使用舊模板（OnPropertyChanged("jsonName")），而 Resource 類別已用新模板（OnPropertyChangedByClr + nameof），導致風格不一致，亦曾引發 CS0120 編譯錯誤。
- .NET 9 已內建 System.Text.Json，屬性標注可簡化，不必再寫完整命名空間。

### 產生器改動

#### 1) PropertyEmitter（Tools/CodeGen/Services/PropertyEmitter.cs）
- 新增/保留的介面方法（僅列出重點）：
  - EmitClr：Resource 層用（[JsonPropertyName] + OnPropertyChangedByClr）
  - EmitClrBackbone：Backbone 層用（[JsonPropertyName] + OnPropertyChanged("jsonName")）
  - EmitChoiceWithMutex：Resource 層 Choice 互斥屬性
  - EmitChoiceWithMutexBackbone：Backbone 層 Choice 互斥屬性
- 將所有屬性標注由 [System.Text.Json.Serialization.JsonPropertyName("...")] 改為 [JsonPropertyName("...")]。

範例（Resource 層範本，節錄）：
- 來源檔：Tools/CodeGen/Services/PropertyEmitter.cs
- 變更後範例片段：

<augment_code_snippet path="Tools/CodeGen/Services/PropertyEmitter.cs" mode="EXCERPT">
````csharp
[JsonPropertyName("{jsonName}")]
public List<{csType}> {propName} { get => {field}; set { {field} = value; OnPropertyChangedByClr(nameof({propName}), value); } }
````
</augment_code_snippet>

範例（Backbone 層範本，節錄）：
- 來源檔：Tools/CodeGen/Services/PropertyEmitter.cs

<augment_code_snippet path="Tools/CodeGen/Services/PropertyEmitter.cs" mode="EXCERPT">
````csharp
[JsonPropertyName("{jsonName}")]
public {csType}? {propName} { get => {field}; set { {field} = value; OnPropertyChanged("{jsonName}", value); } }
````
</augment_code_snippet>

#### 2) PoCGenerator（Tools/CodeGen/Generators/PoCGenerator.cs）
- 生成 Resource 檔案時，新增 using System.Text.Json.Serialization; 以支援簡化屬性標注。
- Backbone 類別內部屬性改為呼叫 EmitClrBackbone（原本錯用 Emit 或 EmitClr 的地方已統一修正）。
- Choice 互斥屬性：Resource 層用 EmitChoiceWithMutex；Backbone 層用 EmitChoiceWithMutexBackbone。

範例（新增 using，節錄）：
- 來源檔：Tools/CodeGen/Generators/PoCGenerator.cs

<augment_code_snippet path="Tools/CodeGen/Generators/PoCGenerator.cs" mode="EXCERPT">
````csharp
sb.AppendLine("using System.Text.Json.Nodes;");
sb.AppendLine("using System.Text.Json.Serialization;");
````
</augment_code_snippet>

### 測試與驗證

#### 1) 重新產生 R5（僅示範 Patient、Observation、Organization）
- 指令：
  - tools/CodeGen → 產生 Patient、Observation、Organization
- 結果：成功生成下列檔案（節錄）：
  - FhirSDK.Resources.R5/Generated/Patient.g.cs
  - FhirSDK.Resources.R5/Generated/Observation.g.cs
  - FhirSDK.Resources.R5/Generated/Organization.g.cs

#### 2) 單元測試
- 專案：FhirSDK.Resources.R5.Tests
- 結果：建置成功、測試通過 20/20；無相關警告。

### 其他清理（測試專案）
- 移除 FhirSDK.Resources.R5.Tests.csproj 中與 Directory.Build.props 重複的套件參考，解決 NU1504 警告。
- 將 AssertSpec.Equals 加上 new 關鍵字，消除 CS0108 警告（名稱遮蔽 object.Equals）。

範例（AssertSpec 片段）：
- 來源檔：FhirSDK.Resources.R5.Tests/Generic/ResourceCaseModels.cs

<augment_code_snippet path="FhirSDK.Resources.R5.Tests/Generic/ResourceCaseModels.cs" mode="EXCERPT">
````csharp
public class AssertSpec
{
    public string Path { get; set; } = string.Empty;
    public new string? Equals { get; set; }
    public string? Contains { get; set; }
    public bool? Exists { get; set; }
}
````
</augment_code_snippet>

### 相容性與注意事項
- 需 .NET 9（已使用 System.Text.Json 簡化屬性）。
- 產出檔案已統一加入 using System.Text.Json.Serialization;。
- Resource 與 Backbone 的變更通知機制不同：
  - Resource：OnPropertyChangedByClr(nameof(Prop), value)
  - Backbone：OnPropertyChanged("jsonName", value)

### 後續建議
- 對所有 R5 資源執行全量 CodeGen，確保全面採用新的模板（目前示範了 3 個資源）。
- 新增簡單的產出快照測試，鎖定屬性標注與變更通知機制，避免未來回歸。
- 統一其他測試專案（若有）中的套件版本來源，持續避免 NU1504。

### 受影響檔案（主要）
- Tools/CodeGen/Services/PropertyEmitter.cs
- Tools/CodeGen/Generators/PoCGenerator.cs
- FhirSDK.Resources.R5.Tests/FhirSDK.Resources.R5.Tests.csproj（移除重複套件）
- FhirSDK.Resources.R5.Tests/Generic/ResourceCaseModels.cs（修正 CS0108）

