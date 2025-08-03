using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using FhirCore.Versioning;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace FhirCore.Interfaces
{
    /// <summary>
    /// FHIR 資源基礎介面
    /// 
    /// <para>
    /// 定義所有 FHIR 資源的基本屬性和行為。此介面提供了資源的核心功能，
    /// 包括識別、元資料管理、擴展支援和驗證機制。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// public class PatientR5 : ResourceBase&lt;FhirR5Version&gt;, IResource
    /// {
    ///     public override string ResourceType => "Patient";
    ///     // 其他屬性實作...
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 所有 FHIR 資源都必須實作此介面，確保基本功能的一致性。
    /// 介面定義了資源的最小必要屬性集合。
    /// </para>
    /// </remarks>
    public interface IResource
    {
        /// <summary>
        /// 資源的唯一識別碼
        /// 
        /// <para>
        /// 在資源所在伺服器範圍內唯一識別此資源實例的邏輯 ID。
        /// 一旦指派，此值永遠不會改變。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// var resource = new PatientR5 { Id = "patient-12345" };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ID 必須符合以下規則：
        /// - 長度在 1-64 個字元之間
        /// - 只能包含字母、數字、連字號 (-) 和句號 (.) 
        /// - 不能包含空格或其他特殊字元
        /// </para>
        /// </remarks>
        string? Id { get; set; }

        /// <summary>
        /// 資源類型名稱
        /// 
        /// <para>
        /// 此資源的 FHIR 資源類型名稱。此值必須與 FHIR 規範中定義的
        /// 標準資源類型名稱完全匹配。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// // 對於 Patient 資源
        /// public override string ResourceType => "Patient";
        /// 
        /// // 對於 Observation 資源  
        /// public override string ResourceType => "Observation";
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// ResourceType 用於：
        /// - 序列化時的資源類型識別
        /// - 路由和 API 端點匹配
        /// - 驗證和類型檢查
        /// </para>
        /// </remarks>
        string ResourceType { get; }

        /// <summary>
        /// 資源的元資料
        /// 
        /// <para>
        /// 包含有關資源的元資料，如版本 ID、最後更新時間、安全標籤等。
        /// 這些資料提供了資源管理和版本控制所需的資訊。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// resource.Meta = new Meta
        /// {
        ///     VersionId = "1",
        ///     LastUpdated = DateTimeOffset.Now,
        ///     Source = "http://example.org/fhir"
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Meta 包含的重要資訊：
        /// - VersionId: 資源的版本識別碼
        /// - LastUpdated: 最後更新時間戳記
        /// - Source: 資源的來源系統
        /// - Profile: 資源遵循的設定檔
        /// - Security: 安全性標籤
        /// - Tag: 分類標籤
        /// </para>
        /// </remarks>
        Meta? Meta { get; set; }

        /// <summary>
        /// 資源的隱含規則 URI
        /// 
        /// <para>
        /// 指向定義此資源實例所遵循的隱含規則集的 URI 參考。
        /// 這些規則可能會限制或擴展資源的使用方式。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// resource.ImplicitRules = "http://example.org/fhir/rules/special-handling";
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 重要注意事項：
        /// - 如果資源包含 implicitRules，任何不理解這些規則的系統都不應處理該資源
        /// - 這是一個強制性的安全機制
        /// - 應謹慎使用，因為會限制資源的互操作性
        /// </para>
        /// </remarks>
        string? ImplicitRules { get; set; }

        /// <summary>
        /// 資源內容的基本語言
        /// 
        /// <para>
        /// 指定資源內容的基本語言。使用 BCP 47 語言標籤格式。
        /// 這有助於國際化和多語言環境的正確處理。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// resource.Language = "zh-TW";  // 繁體中文
        /// resource.Language = "en-US";  // 美式英語
        /// resource.Language = "ja-JP";  // 日語
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 語言碼的重要性：
        /// - 幫助系統正確顯示和處理文字內容
        /// - 支援語言特定的排序和搜尋
        /// - 協助翻譯和本地化工作
        /// - 確保可訪問性標準的遵循
        /// </para>
        /// </remarks>
        string? Language { get; set; }

        /// <summary>
        /// 資源的擴展集合
        /// 
        /// <para>
        /// 可選的擴展元素集合，允許在不修改基本資源定義的情況下
        /// 添加額外的資訊。每個擴展都由 URL 識別。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// resource.Extension.Add(new Extension
        /// {
        ///     Url = "http://example.org/fhir/extension/birth-place",
        ///     Value = "New York, USA"
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 擴展的使用場景：
        /// - 添加標準資源中未定義的欄位
        /// - 支援特定實作的需求
        /// - 提供額外的臨床或業務資訊
        /// - 實現標準化之前的新功能
        /// </para>
        /// 
        /// <para>
        /// 擴展設計原則：
        /// - 每個擴展必須有唯一的 URL
        /// - 擴展應該是可選的
        /// - 不理解擴展的系統應該能忽略它們
        /// </para>
        /// </remarks>
        ObservableCollection<Extension> Extension { get; }

        /// <summary>
        /// 資源的修飾符擴展集合
        /// 
        /// <para>
        /// 可能會改變其他元素含義的擴展集合。與普通擴展不同，
        /// 修飾符擴展如果不被理解，會影響資源的安全處理。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// resource.ModifierExtension.Add(new Extension
        /// {
        ///     Url = "http://example.org/fhir/modifier-extension/data-absent-reason",
        ///     Value = "masked"
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 修飾符擴展的特殊性：
        /// - 可能會改變資源的語義
        /// - 不理解修飾符擴展的系統不應處理資源
        /// - 比普通擴展具有更強的安全約束
        /// - 通常用於表示資料的缺失或特殊狀態
        /// </para>
        /// 
        /// <para>
        /// 常見用途：
        /// - 表示資料被隱藏或遮罩
        /// - 指示資料不可用的原因
        /// - 標記特殊的處理要求
        /// </para>
        /// </remarks>
        ObservableCollection<Extension> ModifierExtension { get; }

        /// <summary>
        /// 驗證資源是否符合 FHIR 標準
        /// 
        /// <para>
        /// 執行資源的完整驗證，包括必填欄位檢查、資料格式驗證、
        /// 業務規則檢查等。這是確保資源品質的重要機制。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// var result = resource.Validate();
        /// if (result == ValidationResult.Success)
        /// {
        ///     // 資源有效，可以繼續處理
        ///     Console.WriteLine("資源驗證成功");
        /// }
        /// else
        /// {
        ///     // 處理驗證錯誤
        ///     Console.WriteLine($"驗證失敗: {result.ErrorMessage}");
        /// }
        /// </code>
        /// </example>
        /// </summary>
        /// <returns>
        /// 驗證結果，成功時返回 ValidationResult.Success，
        /// 失敗時返回包含錯誤訊息的 ValidationResult
        /// </returns>
        /// <remarks>
        /// <para>
        /// 驗證包含的檢查項目：
        /// - 必填欄位存在性檢查
        /// - 資料類型和格式驗證
        /// - 值域和約束檢查
        /// - 業務規則驗證
        /// - 引用完整性檢查
        /// - FHIR 規範相容性驗證
        /// </para>
        /// 
        /// <para>
        /// 驗證時機：
        /// - 資源創建後
        /// - 資源修改後
        /// - 序列化之前
        /// - 傳輸之前
        /// </para>
        /// </remarks>
        ValidationResult Validate();

        /// <summary>
        /// 取得資源的 FHIR 版本
        /// 
        /// <para>
        /// 返回此資源所遵循的 FHIR 規範版本。這對於多版本支援
        /// 和版本相容性檢查非常重要。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// var version = resource.GetFhirVersion();
        /// Console.WriteLine($"資源使用 FHIR 版本: {version}");
        /// // 輸出: "資源使用 FHIR 版本: 5.0.0"
        /// </code>
        /// </example>
        /// </summary>
        /// <returns>
        /// FHIR 版本字串，如 "4.0.1" (R4) 或 "5.0.0" (R5)
        /// </returns>
        /// <remarks>
        /// <para>
        /// 版本資訊的用途：
        /// - 確保版本相容性
        /// - 選擇適當的驗證規則
        /// - 處理版本特定的功能
        /// - 序列化和反序列化的版本控制
        /// - API 版本協商
        /// </para>
        /// 
        /// <para>
        /// 支援的 FHIR 版本：
        /// - R4: "4.0.1"
        /// - R5: "5.0.0"
        /// - 未來版本將根據 FHIR 規範添加
        /// </para>
        /// </remarks>
        string GetFhirVersion();
    }

    /// <summary>
    /// 泛型 FHIR 資源介面
    /// 
    /// <para>
    /// 定義版本特定的 FHIR 資源屬性和行為。此介面擴展了基本的 IResource 介面，
    /// 提供版本感知的功能，確保資源與特定的 FHIR 版本相關聯。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// public class PatientR5 : ResourceBase&lt;FhirR5Version&gt;, IFhirResource&lt;FhirR5Version&gt;
    /// {
    ///     public override string ResourceType => "Patient";
    ///     public FhirR5Version Version => new();
    ///     // 其他 R5 特定實作...
    /// }
    /// </code>
    /// </example>
    /// </summary>
    /// <typeparam name="TVersion">FHIR 版本類型，必須實作 IFhirVersion 介面</typeparam>
    /// <remarks>
    /// <para>
    /// 此泛型介面的優勢：
    /// - 編譯時期的版本類型安全
    /// - 版本特定的功能存取
    /// - 自動版本驗證和檢查
    /// - 清晰的版本分離和管理
    /// </para>
    /// 
    /// <para>
    /// 通過泛型約束確保：
    /// - 資源與特定 FHIR 版本相關聯
    /// - 版本特定的驗證和操作
    /// - 類型安全的版本管理
    /// </para>
    /// </remarks>
    public interface IFhirResource<TVersion> : IResource 
        where TVersion : IFhirVersion
    {
        /// <summary>
        /// 取得與此資源關聯的 FHIR 版本實例
        /// 
        /// <para>
        /// 提供對資源相關 FHIR 版本的強型別存取，允許進行版本特定的
        /// 操作和驗證。這個屬性確保了版本的類型安全性。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// public class PatientR5 : ResourceBase&lt;FhirR5Version&gt;
        /// {
        ///     public FhirR5Version Version => new();
        ///     
        ///     public void DoR5SpecificOperation()
        ///     {
        ///         if (Version.SupportsResourceType("Patient"))
        ///         {
        ///             // 執行 R5 特定的 Patient 操作
        ///         }
        ///     }
        /// }
        /// </code>
        /// </example>
        /// </summary>
        /// <value>FHIR 版本實例，提供版本特定的功能和資訊</value>
        /// <remarks>
        /// <para>
        /// 版本實例提供的功能：
        /// - 版本特定的資源類型支援檢查
        /// - 版本特定的資料類型支援檢查
        /// - 版本特定的驗證規則
        /// - 版本間的相容性檢查
        /// </para>
        /// 
        /// <para>
        /// 使用場景：
        /// - 版本特定的功能檢查
        /// - 條件性功能啟用
        /// - 版本相容性驗證
        /// - 多版本支援的應用程式
        /// </para>
        /// </remarks>
        TVersion Version { get; }
    }

    /// <summary>
    /// 資源元資料類別
    /// 
    /// <para>
    /// 包含有關資源的元資料資訊，如版本 ID、最後更新時間、來源系統、
    /// 設定檔、安全標籤和分類標籤。這些資訊用於資源管理、版本控制、
    /// 安全性和分類等目的。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var meta = new Meta
    /// {
    ///     VersionId = "1",
    ///     LastUpdated = DateTimeOffset.Now,
    ///     Source = "http://example.org/fhir/Patient",
    ///     Profile = { "http://hl7.org/fhir/StructureDefinition/Patient" }
    /// };
    /// 
    /// meta.Tag.Add(new Coding
    /// {
    ///     System = "http://terminology.hl7.org/CodeSystem/v3-ActReason",
    ///     Code = "HTEST",
    ///     Display = "test health data"
    /// });
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Meta 元素在 FHIR 中的重要性：
    /// - 提供資源的管理資訊
    /// - 支援版本控制和追蹤
    /// - 實現安全性和訪問控制
    /// - 協助資源的分類和檢索
    /// </para>
    /// </remarks>
    public class Meta
    {
        /// <summary>
        /// 版本識別碼
        /// 
        /// <para>
        /// 資源的版本識別碼。每次資源更新時，此值都會改變，
        /// 用於樂觀鎖定和版本控制。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.VersionId = "3"; // 表示這是第三個版本
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// VersionId 的特性：
        /// - 由伺服器管理，客戶端不應修改
        /// - 每次更新時自動遞增
        /// - 用於條件性操作（如 If-Match 標頭）
        /// - 支援樂觀並發控制
        /// </para>
        /// </remarks>
        public string? VersionId { get; set; }

        /// <summary>
        /// 最後更新時間
        /// 
        /// <para>
        /// 資源在伺服器上最後一次創建、更新或刪除的時間戳記。
        /// 包含時區資訊，使用 DateTimeOffset 確保準確性。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.LastUpdated = DateTimeOffset.Now;
        /// meta.LastUpdated = DateTimeOffset.Parse("2023-12-25T10:30:00+08:00");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// LastUpdated 的用途：
        /// - 追蹤資源的更新歷史
        /// - 支援增量同步
        /// - 實現資料新鮮度檢查
        /// - 協助除錯和審計
        /// </para>
        /// </remarks>
        public DateTimeOffset? LastUpdated { get; set; }

        /// <summary>
        /// 來源系統
        /// 
        /// <para>
        /// 識別最初創建此資源的系統的 URI。這有助於追蹤資源的來源
        /// 和在多系統環境中維護資料血統。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.Source = "http://example.hospital.org/fhir";
        /// meta.Source = "urn:uuid:12345678-1234-1234-1234-123456789abc";
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的重要性：
        /// - 追蹤資源的原始來源
        /// - 支援多系統整合
        /// - 協助資料治理和審計
        /// - 實現來源特定的處理邏輯
        /// </para>
        /// </remarks>
        public string? Source { get; set; }

        /// <summary>
        /// 分類標籤集合
        /// 
        /// <para>
        /// 用於對資源進行分類的標籤集合。標籤可以用於搜尋、過濾、
        /// 統計和其他業務目的，但不影響資源的語義。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.Tag.Add(new Coding
        /// {
        ///     System = "http://example.org/tags",
        ///     Code = "vip-patient",
        ///     Display = "VIP Patient"
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 標籤的用途：
        /// - 業務流程分類
        /// - 資源檢索和過濾
        /// - 統計和報告
        /// - 自動化處理規則
        /// </para>
        /// </remarks>
        public ObservableCollection<Coding> Tag { get; } = new();

        /// <summary>
        /// 安全標籤集合
        /// 
        /// <para>
        /// 指定資源的安全分類標籤，用於訪問控制和安全性管理。
        /// 這些標籤定義了誰可以存取資源以及在什麼條件下可以存取。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.Security.Add(new Coding
        /// {
        ///     System = "http://terminology.hl7.org/CodeSystem/v3-Confidentiality",
        ///     Code = "R",
        ///     Display = "Restricted"
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 安全標籤的重要性：
        /// - 實現細粒度的訪問控制
        /// - 支援法規合規性要求
        /// - 保護敏感資料
        /// - 實現角色型存取控制 (RBAC)
        /// </para>
        /// 
        /// <para>
        /// 常見的安全標籤：
        /// - 機密性等級 (N, R, V)
        /// - 完整性等級
        /// - 處理限制
        /// - 用途限制
        /// </para>
        /// </remarks>
        public ObservableCollection<Coding> Security { get; } = new();

        /// <summary>
        /// 設定檔集合
        /// 
        /// <para>
        /// 資源宣告遵循的設定檔 (StructureDefinition) 的規範 URL 列表。
        /// 設定檔定義了資源的額外約束和擴展。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// meta.Profile.Add("http://hl7.org/fhir/StructureDefinition/Patient");
        /// meta.Profile.Add("http://example.org/fhir/StructureDefinition/MyPatientProfile");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 設定檔的作用：
        /// - 定義額外的驗證規則
        /// - 指定必要的擴展
        /// - 限制允許的值
        /// - 提供實作指導
        /// </para>
        /// 
        /// <para>
        /// 設定檔的層次：
        /// - 基礎 FHIR 規範
        /// - 國際實作指南 (如 US Core)
        /// - 國家或地區設定檔
        /// - 組織特定設定檔
        /// </para>
        /// </remarks>
        public ObservableCollection<string> Profile { get; } = new();
    }

    /// <summary>
    /// 編碼類別
    /// 
    /// <para>
    /// 表示來自編碼系統的單一代碼。Coding 包含系統 URI、代碼值、
    /// 顯示文字和其他相關資訊，用於在 FHIR 中表示標準化概念。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var coding = new Coding
    /// {
    ///     System = "http://snomed.info/sct",
    ///     Code = "73211009",
    ///     Display = "Diabetes mellitus",
    ///     Version = "20230101"
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Coding 在 FHIR 中的重要性：
    /// - 提供標準化的概念表示
    /// - 支援多語言和本地化
    /// - 實現語義互操作性
    /// - 協助自動化處理和決策支援
    /// </para>
    /// </remarks>
    public class Coding
    {
        /// <summary>
        /// 編碼系統的 URI
        /// 
        /// <para>
        /// 定義代碼含義的編碼系統的識別 URI。這是代碼的命名空間，
        /// 確保代碼的唯一性和含義的準確性。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// coding.System = "http://snomed.info/sct";        // SNOMED CT
        /// coding.System = "http://loinc.org";              // LOINC
        /// coding.System = "http://www.nlm.nih.gov/research/umls/rxnorm"; // RxNorm
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常見的編碼系統：
        /// - SNOMED CT: 臨床術語
        /// - LOINC: 檢驗和觀察標識符
        /// - ICD-10: 疾病分類
        /// - RxNorm: 藥物術語
        /// - CPT: 醫療程序編碼
        /// </para>
        /// </remarks>
        public string? System { get; set; }

        /// <summary>
        /// 編碼系統的版本
        /// 
        /// <para>
        /// 使用的編碼系統版本。當編碼系統有版本控制且代碼的含義
        /// 可能在版本間有所不同時，此欄位特別重要。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// coding.Version = "20230101";     // SNOMED CT 版本
        /// coding.Version = "2.68";         // LOINC 版本
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 版本的重要性：
        /// - 確保代碼含義的準確性
        /// - 支援編碼系統的演進
        /// - 協助版本間的對應
        /// - 實現精確的語義互操作性
        /// </para>
        /// </remarks>
        public string? Version { get; set; }

        /// <summary>
        /// 代碼值
        /// 
        /// <para>
        /// 由編碼系統定義的符號。這是實際的代碼值，
        /// 在指定的編碼系統中具有特定的含義。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// coding.Code = "73211009";  // SNOMED CT 代碼
        /// coding.Code = "718-7";     // LOINC 代碼
        /// coding.Code = "male";      // 簡单的代碼值
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 代碼的特性：
        /// - 在指定系統中唯一
        /// - 大小寫敏感（除非系統另有規定）
        /// - 不應包含空格或特殊格式
        /// - 必須與系統定義完全匹配
        /// </para>
        /// </remarks>
        public string? Code { get; set; }

        /// <summary>
        /// 顯示文字
        /// 
        /// <para>
        /// 由編碼系統定義的代碼的人類可讀表示。這是代碼的標準顯示名稱，
        /// 用於使用者介面和報告中的顯示。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// coding.Display = "Diabetes mellitus";  // SNOMED CT 顯示文字
        /// coding.Display = "Hemoglobin";          // LOINC 顯示文字
        /// coding.Display = "Male";                // 性別代碼顯示文字
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 顯示文字的用途：
        /// - 提供使用者友好的代碼表示
        /// - 支援多語言顯示
        /// - 協助代碼的理解和驗證
        /// - 在 UI 中直接顯示
        /// </para>
        /// 
        /// <para>
        /// 重要注意事項：
        /// - 顯示文字不應用於計算或邏輯判斷
        /// - 應該與編碼系統定義的官方顯示文字一致
        /// - 可能因語言和地區而異
        /// </para>
        /// </remarks>
        public string? Display { get; set; }

        /// <summary>
        /// 使用者選擇標記
        /// 
        /// <para>
        /// 指示此編碼是否由使用者直接選擇（如從清單中挑選），
        /// 而非由系統自動推斷或計算得出。這對於理解資料的來源很重要。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// // 使用者從下拉選單中選擇
        /// coding.UserSelected = true;
        /// 
        /// // 系統根據規則自動指派
        /// coding.UserSelected = false;
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// UserSelected 的意義：
        /// - true: 使用者明確選擇此代碼
        /// - false: 代碼由系統推導或計算
        /// - null: 未知或不相關
        /// </para>
        /// 
        /// <para>
        /// 使用場景：
        /// - 區分使用者輸入與系統推導
        /// - 審計和品質控制
        /// - 理解資料的可靠性
        /// - 支援工作流程分析
        /// </para>
        /// </remarks>
        public bool? UserSelected { get; set; }
    }

    /// <summary>
    /// 擴展類別
    /// 
    /// <para>
    /// 表示 FHIR 擴展，允許在不修改基本資源定義的情況下添加額外資訊。
    /// 每個擴展都由唯一的 URL 識别，並包含一個值或嵌套的擴展。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var extension = new Extension
    /// {
    ///     Url = "http://example.org/fhir/extension/birth-place",
    ///     Value = "New York, USA"
    /// };
    /// 
    /// // 嵌套擴展
    /// var complexExtension = new Extension
    /// {
    ///     Url = "http://example.org/fhir/extension/address-detail"
    /// };
    /// complexExtension.Extensions.Add(new Extension
    /// {
    ///     Url = "district",
    ///     Value = "Manhattan"
    /// });
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 擴展的設計原則：
    /// - 必須有唯一的 URL 識別
    /// - 可以包含值或嵌套擴展，但不能同時包含兩者
    /// - 應該是可選的，不理解的系統可以忽略
    /// - 不應改變核心元素的含義（除非是修飾符擴展）
    /// </para>
    /// </remarks>
    public class Extension
    {
        /// <summary>
        /// 擴展的識別 URL
        /// 
        /// <para>
        /// 唯一識別此擴展定義的 URI。這個 URL 必須指向一個
        /// StructureDefinition，該定義描述了擴展的結構和約束。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// extension.Url = "http://hl7.org/fhir/StructureDefinition/patient-birthPlace";
        /// extension.Url = "http://example.org/fhir/extension/custom-field";
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// URL 的要求：
        /// - 必須是絕對 URI
        /// - 應該是可解析的（但不要求可存取）
        /// - 在同一上下文中必須唯一
        /// - 建議指向實際的 StructureDefinition
        /// </para>
        /// 
        /// <para>
        /// URL 的命名慣例：
        /// - 使用組織的域名作為基礎
        /// - 包含有意義的路徑和名稱
        /// - 避免使用臨時或不穩定的 URL
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "Extension URL 是必填欄位")]
        public string Url { get; set; } = string.Empty;

        /// <summary>
        /// 擴展的值
        /// 
        /// <para>
        /// 擴展攜帶的實際值。可以是任何 FHIR 資料類型，
        /// 包括原始類型、複雜類型或資源引用。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// // 字串值
        /// extension.Value = "Some text value";
        /// 
        /// // 數字值
        /// extension.Value = 42;
        /// 
        /// // 布林值
        /// extension.Value = true;
        /// 
        /// // 複雜物件
        /// extension.Value = new Address { City = "Taipei" };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 值的限制：
        /// - 如果有嵌套擴展，則不能有值
        /// - 值的類型必須符合擴展定義
        /// - 可以是 null（空擴展）
        /// </para>
        /// 
        /// <para>
        /// 常見的值類型：
        /// - 原始類型：string, int, bool, DateTime
        /// - 複雜類型：Address, HumanName, Coding
        /// - 引用類型：Resource references
        /// </para>
        /// </remarks>
        public object? Value { get; set; }

        /// <summary>
        /// 嵌套擴展集合
        /// 
        /// <para>
        /// 包含在此擴展內的子擴展。用於創建複雜的、結構化的擴展。
        /// 如果存在嵌套擴展，則不能同時設定 Value。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// var parentExtension = new Extension
        /// {
        ///     Url = "http://example.org/fhir/extension/contact-detail"
        /// };
        /// 
        /// parentExtension.Extensions.Add(new Extension
        /// {
        ///     Url = "phone",
        ///     Value = "+1-555-123-4567"
        /// });
        /// 
        /// parentExtension.Extensions.Add(new Extension
        /// {
        ///     Url = "email",
        ///     Value = "john.doe@example.com"
        /// });
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 嵌套擴展的用途：
        /// - 創建複雜的資料結構
        /// - 組織相關的擴展欄位
        /// - 支援重複的複雜資料
        /// - 實現層次化的資料組織
        /// </para>
        /// 
        /// <para>
        /// 設計注意事項：
        /// - 避免過度嵌套（建議不超過 3 層）
        /// - 確保嵌套結構有明確的語義
        /// - 考慮使用複雜資料類型替代深度嵌套
        /// </para>
        /// </remarks>
        public ObservableCollection<Extension> Extensions { get; set; } = new();
    }

    /// <summary>
    /// 值集類別介面
    /// 
    /// <para>
    /// 定義值集類別的基本合約，提供枚舉名稱存取功能。
    /// 所有 FHIR 值集類別都應實作此介面。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 此介面確保所有值集類別提供一致的枚舉名稱存取方式，
    /// 支援值集的標準化操作和互操作性。
    /// </para>
    /// </remarks>
    public interface IValueSetClass
    {
        /// <summary>
        /// 取得枚舉名稱
        /// </summary>
        /// <returns>枚舉的字串表示</returns>
        /// <remarks>
        /// <para>
        /// 此方法應返回枚舉值的標準字串表示，
        /// 通常用於序列化和顯示目的。
        /// </para>
        /// </remarks>
        string GetEnumName();
    }
}
