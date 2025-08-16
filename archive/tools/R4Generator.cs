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
    /// FHIR R4 �귽�ͦ���
    /// 
    /// <para>
    /// �q FHIR R4 �w�q�ɮצ۰ʥͦ� C# �귽���O
    /// </para>
    /// </summary>
    public class Program
    {
        /// <summary>
        /// �D�{���i�J�I
        /// </summary>
        /// <param name="args">�R�O�C�Ѽ�</param>
        public static async Task Main(string[] args)
        {
            Console.WriteLine("?? FHIR R4 �귽�ͦ���");
            Console.WriteLine("===================");

            try
            {
                var generator = new R4ResourceGenerator();
                await generator.GenerateAllResourcesAsync();
                
                Console.WriteLine("? R4 �귽�ͦ������I");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"? �ͦ�����: {ex.Message}");
                Console.WriteLine($"�Բӿ��~: {ex.StackTrace}");
                Environment.Exit(1);
            }
        }
    }

    /// <summary>
    /// R4 �귽�ͦ���
    /// </summary>
    public class R4ResourceGenerator
    {
        private readonly string _definitionsPath = "Definitions/R4";
        private readonly string _outputPath = "FhirCore.R4/Resources";
        private readonly HashSet<string> _processedResources = new();

        /// <summary>
        /// �ͦ��Ҧ� R4 �귽
        /// </summary>
        public async Task GenerateAllResourcesAsync()
        {
            Console.WriteLine($"?? Ū���w�q�ɮ�: {_definitionsPath}");
            
            // �T�O��X�ؿ��s�b
            Directory.CreateDirectory(_outputPath);

            // Ū�� profiles-resources.json
            var resourcesFile = Path.Combine(_definitionsPath, "profiles-resources.json");
            if (File.Exists(resourcesFile))
            {
                await ProcessResourceDefinitionsAsync(resourcesFile);
            }

            // �B�z definitions.json.zip
            var definitionsZip = Path.Combine(_definitionsPath, "definitions.json.zip");
            if (File.Exists(definitionsZip))
            {
                await ProcessDefinitionsZipAsync(definitionsZip);
            }

            Console.WriteLine($"? �w�B�z {_processedResources.Count} �Ӹ귽");
        }

        /// <summary>
        /// �B�z�귽�w�q�ɮ�
        /// </summary>
        private async Task ProcessResourceDefinitionsAsync(string filePath)
        {
            var jsonContent = await File.ReadAllTextAsync(filePath);
            var doc = JsonDocument.Parse(jsonContent);

            if (doc.RootElement.TryGetProperty("entry", out var entries))
            {
                foreach (var entry in entries.EnumerateArray())
                {
                    if (entry.TryGetProperty("resource", out var resource))
                    {
                        await ProcessResourceDefinitionAsync(resource);
                    }
                }
            }
        }

        /// <summary>
        /// �B�z definitions.json.zip �ɮ�
        /// </summary>
        private async Task ProcessDefinitionsZipAsync(string zipPath)
        {
            using var archive = ZipFile.OpenRead(zipPath);
            
            var definitionsEntry = archive.Entries.FirstOrDefault(e => 
                e.Name.Equals("definitions.json", StringComparison.OrdinalIgnoreCase));

            if (definitionsEntry != null)
            {
                using var stream = definitionsEntry.Open();
                using var reader = new StreamReader(stream);
                var jsonContent = await reader.ReadToEndAsync();
                
                var doc = JsonDocument.Parse(jsonContent);
                if (doc.RootElement.TryGetProperty("entry", out var entries))
                {
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

        /// <summary>
        /// �B�z��@�귽�w�q
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
                if (!string.IsNullOrEmpty(resourceName) && !_processedResources.Contains(resourceName))
                {
                    Console.WriteLine($"?? �ͦ��귽: {resourceName}");
                    
                    var classContent = GenerateResourceClass(resource, resourceName);
                    var fileName = Path.Combine(_outputPath, $"{resourceName}.cs");
                    
                    await File.WriteAllTextAsync(fileName, classContent, Encoding.UTF8);
                    _processedResources.Add(resourceName);
                }
            }
        }

        /// <summary>
        /// �ͦ��귽���O�N�X
        /// </summary>
        private string GenerateResourceClass(JsonElement resource, string resourceName)
        {
            var sb = new StringBuilder();
            
            // Using �y�y
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

            // �R�W�Ŷ�
            sb.AppendLine("namespace FhirCore.R4.Resources");
            sb.AppendLine("{");

            // ���O����
            sb.AppendLine("    /// <summary>");
            sb.AppendLine($"    /// FHIR R4 {resourceName} �귽");
            sb.AppendLine("    /// ");
            sb.AppendLine("    /// <para>");
            
            if (resource.TryGetProperty("description", out var descElement))
            {
                sb.AppendLine($"    /// {descElement.GetString()}");
            }
            else
            {
                sb.AppendLine($"    /// {resourceName} �귽���ԲӴy�z�N�b���B�K�[�C");
                sb.AppendLine("    /// �o�O FHIR R4 �зǤ������n�귽�����C");
            }
            
            sb.AppendLine("    /// </para>");
            sb.AppendLine("    /// ");
            sb.AppendLine("    /// <example>");
            sb.AppendLine("    /// <code>");
            sb.AppendLine($"    /// var {resourceName.ToLower()} = new {resourceName}(\"{resourceName.ToLower()}-001\");");
            sb.AppendLine("    /// // �]�w�귽�ݩ�...");
            sb.AppendLine("    /// </code>");
            sb.AppendLine("    /// </example>");
            sb.AppendLine("    /// </summary>");
            sb.AppendLine("    /// <remarks>");
            sb.AppendLine("    /// <para>");
            sb.AppendLine($"    /// R4 ������ {resourceName} �귽�㦳�H�U�S�I�G");
            sb.AppendLine("    /// - �W�j����Ƶ��c");
            sb.AppendLine("    /// - ��i�����ҳW�h");
            sb.AppendLine("    /// - ��n�����ާ@��");
            sb.AppendLine("    /// </para>");
            sb.AppendLine("    /// </remarks>");

            // ���O�ŧi
            sb.AppendLine($"    public class {resourceName} : ResourceBase<R4Version>");
            sb.AppendLine("    {");

            // �ͦ��ݩ�
            GenerateProperties(sb, resource);

            // �귽�����ݩ�
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// �귽����");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine($"        public override string ResourceType => \"{resourceName}\";");
            sb.AppendLine();

            // �غc���
            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// �إ߷s�� {resourceName} �귽���");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine($"        public {resourceName}()");
            sb.AppendLine("        {");
            sb.AppendLine("        }");
            sb.AppendLine();

            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// �إ߷s�� {resourceName} �귽���");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        /// <param name=\"id\">�귽���ߤ@�ѧO�X</param>");
            sb.AppendLine($"        public {resourceName}(string id)");
            sb.AppendLine("        {");
            sb.AppendLine("            Id = id;");
            sb.AppendLine("        }");
            sb.AppendLine();

            // ToString ��k
            sb.AppendLine("        /// <summary>");
            sb.AppendLine("        /// �ഫ���r����");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        public override string ToString()");
            sb.AppendLine("        {");
            sb.AppendLine($"            return $\"{resourceName}(Id: {{Id}})\";");
            sb.AppendLine("        }");

            // ���O����
            sb.AppendLine("    }");
            sb.AppendLine("}");

            return sb.ToString();
        }

        /// <summary>
        /// �ͦ��ݩ�
        /// </summary>
        private void GenerateProperties(StringBuilder sb, JsonElement resource)
        {
            if (resource.TryGetProperty("snapshot", out var snapshot) &&
                snapshot.TryGetProperty("element", out var elements))
            {
                var properties = new List<string>();
                
                foreach (var element in elements.EnumerateArray())
                {
                    if (element.TryGetProperty("path", out var pathElement))
                    {
                        var path = pathElement.GetString();
                        if (!string.IsNullOrEmpty(path) && path.Contains('.') && !path.EndsWith("[x]"))
                        {
                            var propertyName = path.Split('.').Last();
                            if (!properties.Contains(propertyName) && IsValidPropertyName(propertyName))
                            {
                                properties.Add(propertyName);
                                GenerateProperty(sb, element, propertyName);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// �ͦ���@�ݩ�
        /// </summary>
        private void GenerateProperty(StringBuilder sb, JsonElement element, string propertyName)
        {
            var propertyType = DeterminePropertyType(element);
            var fieldName = $"_{propertyName.ToLower()}";

            // �p�����
            sb.AppendLine($"        private {propertyType}? {fieldName};");
            sb.AppendLine();

            // �ݩʵ���
            sb.AppendLine("        /// <summary>");
            sb.AppendLine($"        /// {propertyName}");
            sb.AppendLine("        /// </summary>");
            sb.AppendLine("        /// <remarks>");
            sb.AppendLine("        /// <para>");
            sb.AppendLine($"        /// {propertyName} ���ԲӴy�z�C");
            sb.AppendLine("        /// </para>");
            sb.AppendLine("        /// </remarks>");

            // �ݩʫŧi
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
        /// �M�w�ݩ�����
        /// </summary>
        private string DeterminePropertyType(JsonElement element)
        {
            if (element.TryGetProperty("type", out var typeArray) && typeArray.ValueKind == JsonValueKind.Array)
            {
                var firstType = typeArray.EnumerateArray().FirstOrDefault();
                if (firstType.TryGetProperty("code", out var codeElement))
                {
                    var code = codeElement.GetString();
                    return MapFhirTypeToCs(code);
                }
            }

            return "FhirString";
        }

        /// <summary>
        /// �N FHIR ���������� C# ����
        /// </summary>
        private string MapFhirTypeToCs(string? fhirType)
        {
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
                "Extension" => "List<Extension>",
                _ => "FhirString"
            };
        }

        /// <summary>
        /// �ˬd�O�_�����Ī��ݩʦW��
        /// </summary>
        private bool IsValidPropertyName(string name)
        {
            return !string.IsNullOrEmpty(name) && 
                   char.IsLetter(name[0]) && 
                   name.All(c => char.IsLetterOrDigit(c)) &&
                   name != "ResourceType" &&
                   name != "Id" &&
                   name != "Meta" &&
                   name != "ImplicitRules" &&
                   name != "Language";
        }
    }
}