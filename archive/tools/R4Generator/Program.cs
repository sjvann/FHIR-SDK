using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;

namespace FhirR4Generator
{
    /// <summary>
    /// FHIR R4 資源生成器
    /// 
    /// <para>
    /// 從 FHIR R4 定義檔案自動生成 C# 資源類別
    /// </para>
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 主程式進入點
        /// </summary>
        /// <param name="args">命令列參數</param>
        public static async Task Main(string[] args)
        {
            Console.WriteLine("?? FHIR R4 資源生成器");
            Console.WriteLine("===================");

            try
            {
                var generator = new R4ResourceGenerator();
                await generator.GenerateAllResourcesAsync();
                
                Console.WriteLine("? R4 資源生成完成！");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"? 生成失敗: {ex.Message}");
                Console.WriteLine($"詳細錯誤: {ex.StackTrace}");
                Environment.Exit(1);
            }
        }
    }

    /// <summary>
    /// R4 資源生成器
    /// </summary>
    public class R4ResourceGenerator
    {
        private readonly string _definitionsPath;
        private readonly string _outputPath;
        private readonly HashSet<string> _processedResources = new();

        public R4ResourceGenerator()
        {
            // 獲取解決方案的根目錄
            var solutionDir = GetSolutionDirectory();
            if (solutionDir == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("? 錯誤: 找不到解決方案根目錄。");
                Console.ResetColor();
                Environment.Exit(1);
            }

            _definitionsPath = Path.Combine(solutionDir, "Definitions", "R4");
            _outputPath = Path.Combine(solutionDir, "FhirCore.R4", "Resources");
        }

        private string? GetSolutionDirectory()
        {
            var currentDir = new DirectoryInfo(AppContext.BaseDirectory);
            while (currentDir != null && !currentDir.GetFiles("*.sln").Any())
            {
                currentDir = currentDir.Parent;
            }
            return currentDir?.FullName;
        }

        /// <summary>
        /// 生成所有 R4 資源
        /// </summary>
        public async Task GenerateAllResourcesAsync()
        {
            Console.WriteLine($"?? 讀取定義檔案: {_definitionsPath}");
            
            // 確保輸出目錄存在
            Directory.CreateDirectory(_outputPath);

            // 處理 definitions.json.zip
            var definitionsZip = Path.Combine(_definitionsPath, "definitions.json.zip");
            if (!File.Exists(definitionsZip))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"? 錯誤: 找不到定義檔案: {Path.GetFullPath(definitionsZip)}");
                Console.WriteLine("請確認 'definitions.json.zip' 檔案已放置在正確的目錄中。");
                Console.ResetColor();
                Environment.Exit(1); // 找不到檔案，終止執行
                return;
            }

            await ProcessDefinitionsZipAsync(definitionsZip);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"? 已成功處理 {_processedResources.Count} 個資源。");
            Console.ResetColor();
        }

        /// <summary>
        /// 處理 definitions.json.zip 檔案
        /// </summary>
        private async Task ProcessDefinitionsZipAsync(string zipPath)
        {
            Console.WriteLine($"?? 處理壓縮檔: {zipPath}");
            
            using var archive = ZipFile.OpenRead(zipPath);

            Console.WriteLine("?? 正在檢查壓縮檔內容...");
            foreach (var entry in archive.Entries)
            {
                Console.WriteLine($"  - 找到檔案: {entry.FullName}");
            }

            // 從多個可能的來源檔案中尋找資源定義
            var definitionFiles = new[] { "profiles-resources.json", "definitions.json" };
            var foundDefinition = false;

            foreach (var fileName in definitionFiles)
            {
                var definitionsEntry = archive.Entries.FirstOrDefault(e => 
                    e.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));

                if (definitionsEntry != null)
                {
                    Console.WriteLine($"?? 找到並開始處理定義檔: {fileName}");
                    foundDefinition = true;
                    using var stream = definitionsEntry.Open();
                    using var reader = new StreamReader(stream);
                    var jsonContent = await reader.ReadToEndAsync();
                    
                    var doc = JsonDocument.Parse(jsonContent);
                    if (doc.RootElement.TryGetProperty("entry", out var entries))
                    {
                        Console.WriteLine($"  - 找到 {entries.GetArrayLength()} 個定義項目");
                        
                        foreach (var entry in entries.EnumerateArray())
                        {
                            if (entry.TryGetProperty("resource", out var resource))
                            {
                                await ProcessResourceDefinitionAsync(resource);
                            }
                        }
                    }
                }
            }

            if (!foundDefinition)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("? 錯誤: 壓縮檔中找不到任何有效的定義檔 (如 profiles-resources.json 或 definitions.json)");
                Console.ResetColor();
                Environment.Exit(1); // 找不到檔案，終止執行
            }
        }

        /// <summary>
        /// 處理單一資源定義
        /// </summary>
        private async Task ProcessResourceDefinitionAsync(JsonElement resource)
        {
            if (!resource.TryGetProperty("resourceType", out var resourceTypeElement) ||
                resourceTypeElement.GetString() != "StructureDefinition")
            {
                return;
            }

            if (!resource.TryGetProperty("kind", out var kindElement) ||
                kindElement.GetString() != "resource")
            {
                return;
            }

            if (resource.TryGetProperty("name", out var nameElement))
            {
                var resourceName = nameElement.GetString();
                if (!string.IsNullOrEmpty(resourceName) && 
                    !_processedResources.Contains(resourceName) &&
                    IsValidResourceName(resourceName))
                {
                    Console.WriteLine($"?? 生成資源: {resourceName}");
                    
                    var classContent = GenerateResourceClass(resource, resourceName);
                    var fileName = Path.Combine(_outputPath, $"{resourceName}.cs");
                    
                    await File.WriteAllTextAsync(fileName, classContent, Encoding.UTF8);
                    _processedResources.Add(resourceName);
                }
            }
        }

        /// <summary>
        /// 檢查是否為有效的資源名稱
        /// </summary>
        private bool IsValidResourceName(string name)
        {
            // 排除內建類型和特殊資源
            var excludedNames = new HashSet<string>
            {
                "Element", "BackboneElement", "Resource", "DomainResource", 
                "Extension", "Narrative", "Meta", "Reference"
            };
            
            return !excludedNames.Contains(name) && 
                   !string.IsNullOrEmpty(name) && 
                   char.IsUpper(name[0]);
        }

        /// <summary>
        /// 生成資源類別代碼
        /// </summary>
        private string GenerateResourceClass(JsonElement resource, string resourceName)
        {
            var sb = new StringBuilder();
            
            // Using 語句
            sb.AppendLine("using FhirCore.Base;");
            sb.AppendLine("using FhirCore.R4;");
            sb.AppendLine("using DataTypeServices.DataTypes.ComplexTypes;");
            sb.AppendLine("using DataTypeServices.DataTypes.PrimitiveTypes;");
            sb.AppendLine("using DataTypeServices.DataTypes.SpecialTypes;");
            sb.AppendLine("using DataTypeServices.TypeFramework;");
            sb.AppendLine("using System.ComponentModel.DataAnnotations;");
            sb.AppendLine("using System.Text.Json.Nodes;");
            sb.AppendLine("using FhirCore.Interfaces;");
            sb.AppendLine();

            // 命名空間
            sb.AppendLine("namespace FhirCore.R4.Resources");
            sb.AppendLine("{");

            // 類別註解
            sb.AppendLine("    /// <summary>");
            sb.AppendLine($"    /// FHIR R4 {resourceName} 資源");
            sb.AppendLine("    /// ");
            sb.AppendLine("    /// <para>");
            
            if (resource.TryGetProperty("description", out var descElement))
            {
                var desc = descElement.GetString()?.Replace("\n", " ").Replace("\r", "");
                if (!string.IsNullOrEmpty(desc))
                {
                    sb.AppendLine($"    /// {desc}");
                }
            }
            else
            {
                sb.AppendLine($"    /// {resourceName} 資源的詳細描述將在此處添加。");
                sb.AppendLine("    /// 這是 FHIR R4 標準中的重要資源類型。");
            }
            
            sb.AppendLine("    /// </para>");
            sb.AppendLine("    /// ");
            sb.AppendLine("    /// <example>");
            sb.AppendLine("    /// <code>");
            sb.AppendLine($"    /// var {resourceName.ToLower()} = new {resourceName}(\"{resourceName.ToLower()}-001\");");
            sb.AppendLine("    /// // 設定資源屬性...");
            sb.AppendLine("    /// </code>");
            sb.AppendLine("    /// </example>");
            sb.AppendLine("    /// </summary>");
            sb.AppendLine("    /// <remarks>");
            sb.AppendLine("    /// <para>");
            sb.AppendLine($"    /// R4 版本的 {resourceName} 資源具有以下特點：");
            sb.AppendLine("    /// - 增強的資料結構");
            sb.AppendLine("    /// - 改進的驗證規則");
            sb.AppendLine("    /// - 更好的互操作性");
            sb.AppendLine("    /// </para>");
            sb.AppendLine("    /// </remarks>");

            // 類別宣告
            sb.AppendLine($"    public class {resourceName} : ResourceBase<R4Version>");
            sb.AppendLine("    {");

            // 生成屬性
            GenerateProperties(sb, resource);

            // 資源類型屬性
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// 資源類型");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine($"        public override string ResourceType => \"{resourceName}\";");
            sb.AppendLine();

            // 建構函數
            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// 建立新的 {resourceName} 資源實例");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine($"        public {resourceName}()");
            sb.AppendLine("        {");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// 建立新的 {resourceName} 資源實例");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        /// <param name=\"id\">資源的唯一識別碼</param>");
            sb.AppendLine($"        public {resourceName}(string id)");
            sb.AppendLine("        {");
            sb.AppendLine("            Id = id;");
            sb.AppendLine("        }");
            sb.AppendLine();

            // ToString 方法
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// 轉換為字串表示");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        public override string ToString()");
            sb.AppendLine("        {");
            sb.AppendLine($"            return $\"{resourceName}(Id: {{Id}})\";");
            sb.AppendLine("        }");

            // 類別結束
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        /// <summary>
        /// 生成屬性
        /// </summary>
        private void GenerateProperties(StringBuilder sb, JsonElement resource)
        {
            // 先收集所有屬性
            var properties = new Dictionary<string, JsonElement>();
            
            if (resource.TryGetProperty("snapshot", out var snapshot) &&
                snapshot.TryGetProperty("element", out var elements))
            {
                foreach (var element in elements.EnumerateArray())
                {
                    if (element.TryGetProperty("path", out var pathElement))
                    {
                        var path = pathElement.GetString();
                        if (!string.IsNullOrEmpty(path) && path.Contains('.'))
                        {
                            var parts = path.Split('.');
                            if (parts.Length == 2) // 只要第一層屬性
                            {
                                var propertyName = parts[1];
                                if (IsValidPropertyName(propertyName) && !properties.ContainsKey(propertyName))
                                {
                                    properties[propertyName] = element;
                                }
                            }
                        }
                    }
                }
            }

            // 生成屬性
            foreach (var kvp in properties.OrderBy(x => x.Key))
            {
                GenerateProperty(sb, kvp.Value, kvp.Key);
            }
        }

        /// <summary>
        /// 生成單一屬性
        /// </summary>
        private void GenerateProperty(StringBuilder sb, JsonElement element, string propertyName)
        {
            var propertyType = DeterminePropertyType(element, propertyName);
            var fieldName = $"_{propertyName.ToLower()}";

            // 私有欄位
            sb.AppendLine($"        private {propertyType}? {fieldName};");
            sb.AppendLine();

            // 屬性註解
            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// {propertyName}");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        /// <remarks>");
            sb.AppendLine("        /// <para>");
            sb.AppendLine($"        /// {propertyName} 的詳細描述。");
            sb.AppendLine("        /// </para>");
            sb.AppendLine("        /// </remarks>");

            // 屬性宣告
            sb.AppendLine($"        public {propertyType}? {propertyName}");
            sb.AppendLine("        {");
            sb.AppendLine($"            get => {fieldName};");
            sb.AppendLine("            set");
            sb.AppendLine("            {");
            sb.AppendLine($"                {fieldName} = value;");
            sb.AppendLine($"                OnPropertyChanged(nameof({propertyName}));");
            sb.AppendLine("            }");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        /// <summary>
        /// 決定屬性類型
        /// </summary>
        private string DeterminePropertyType(JsonElement element, string propertyName)
        {
            // 檢查是否為陣列
            var isArray = false;
            if (element.TryGetProperty("max", out var maxElement))
            {
                var max = maxElement.GetString();
                isArray = max == "*" || (int.TryParse(max, out var maxInt) && maxInt > 1);
            }

            // 獲取基本類型
            var baseType = "FhirString";
            if (element.TryGetProperty("type", out var typeArray) && typeArray.ValueKind == JsonValueKind.Array)
            {
                var firstType = typeArray.EnumerateArray().FirstOrDefault();
                if (firstType.TryGetProperty("code", out var codeElement))
                {
                    var code = codeElement.GetString();
                    baseType = MapFhirTypeToCs(code, propertyName);
                }
            }

            return isArray ? $"List<{baseType}>" : baseType;
        }

        /// <summary>
        /// 將 FHIR 類型對應到 C# 類型
        /// </summary>
        private string MapFhirTypeToCs(string? fhirType, string propertyName)
        {
            if (fhirType == "BackboneElement")
            {
                // 對於 BackboneElement，我們需要一個更特定的類型名稱
                // 通常是 ResourceName + PropertyName (首字母大寫)
                // 這部分需要更複雜的邏輯來處理，暫時返回一個佔位符
                return "BackboneElement";
            }

            return fhirType switch
            {
                "string" => "FhirString",
                "boolean" => "FhirBoolean",
                "integer" => "FhirInteger",
                "decimal" => "FhirDecimal",
                "date" => "FhirDate",
                "dateTime" => "FhirDateTime",
                "time" => "FhirTime",
                "instant" => "FhirInstant",
                "code" => "FhirCode",
                "uri" => "FhirUri",
                "url" => "FhirUrl",
                "canonical" => "FhirCanonical",
                "id" => "FhirId",
                "markdown" => "FhirMarkdown",
                "base64Binary" => "FhirBase64Binary",
                "positiveInt" => "FhirPositiveInt",
                "unsignedInt" => "FhirUnsignedInt",
                "oid" => "FhirOid",
                "uuid" => "FhirUuid",
                "xhtml" => "FhirXhtml",
                "Reference" => "ReferenceType",
                "CodeableConcept" => "CodeableConcept",
                "Coding" => "Coding",
                "Identifier" => "Identifier",
                "HumanName" => "HumanName",
                "Address" => "Address",
                "ContactPoint" => "ContactPoint",
                "Period" => "Period",
                "Quantity" => "Quantity",
                "Range" => "Range",
                "Ratio" => "Ratio",
                "Attachment" => "Attachment",
                "Annotation" => "Annotation",
                "Timing" => "Timing",
                "Signature" => "Signature",
                "Meta" => "Meta",
                "Extension" => "Extension",
                "Element" => "Element",
                _ => "FhirString"
            };
        }

        /// <summary>
        /// 檢查是否為有效的屬性名稱
        /// </summary>
        private bool IsValidPropertyName(string name)
        {
            // 排除基礎資源屬性
            var excludedProperties = new HashSet<string>
            {
                "ResourceType", "Id", "Meta", "ImplicitRules", "Language", 
                "Text", "Contained", "Extension", "ModifierExtension"
            };

            return !string.IsNullOrEmpty(name) && 
                   char.IsLetter(name[0]) && 
                   !name.Contains('-') && // 排除包含連字號的無效路徑部分
                   name.All(c => char.IsLetterOrDigit(c) || c == '_') &&
                   !excludedProperties.Contains(name);
        }
    }
}