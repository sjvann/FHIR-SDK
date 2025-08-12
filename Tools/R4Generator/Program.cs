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
        private readonly string _definitionsPath;
        private readonly string _outputPath;
        private readonly HashSet<string> _processedResources = new();

        public R4ResourceGenerator()
        {
            // ����ѨM��ת��ڥؿ�
            var solutionDir = GetSolutionDirectory();
            if (solutionDir == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("? ���~: �䤣��ѨM��׮ڥؿ��C");
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
        /// �ͦ��Ҧ� R4 �귽
        /// </summary>
        public async Task GenerateAllResourcesAsync()
        {
            Console.WriteLine($"?? Ū���w�q�ɮ�: {_definitionsPath}");
            
            // �T�O��X�ؿ��s�b
            Directory.CreateDirectory(_outputPath);

            // �B�z definitions.json.zip
            var definitionsZip = Path.Combine(_definitionsPath, "definitions.json.zip");
            if (!File.Exists(definitionsZip))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"? ���~: �䤣��w�q�ɮ�: {Path.GetFullPath(definitionsZip)}");
                Console.WriteLine("�нT�{ 'definitions.json.zip' �ɮפw��m�b���T���ؿ����C");
                Console.ResetColor();
                Environment.Exit(1); // �䤣���ɮסA�פ����
                return;
            }

            await ProcessDefinitionsZipAsync(definitionsZip);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"? �w���\�B�z {_processedResources.Count} �Ӹ귽�C");
            Console.ResetColor();
        }

        /// <summary>
        /// �B�z definitions.json.zip �ɮ�
        /// </summary>
        private async Task ProcessDefinitionsZipAsync(string zipPath)
        {
            Console.WriteLine($"?? �B�z���Y��: {zipPath}");
            
            using var archive = ZipFile.OpenRead(zipPath);

            Console.WriteLine("?? ���b�ˬd���Y�ɤ��e...");
            foreach (var entry in archive.Entries)
            {
                Console.WriteLine($"  - ����ɮ�: {entry.FullName}");
            }

            // �q�h�ӥi�઺�ӷ��ɮפ��M��귽�w�q
            var definitionFiles = new[] { "profiles-resources.json", "definitions.json" };
            var foundDefinition = false;

            foreach (var fileName in definitionFiles)
            {
                var definitionsEntry = archive.Entries.FirstOrDefault(e => 
                    e.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));

                if (definitionsEntry != null)
                {
                    Console.WriteLine($"?? ���ö}�l�B�z�w�q��: {fileName}");
                    foundDefinition = true;
                    using var stream = definitionsEntry.Open();
                    using var reader = new StreamReader(stream);
                    var jsonContent = await reader.ReadToEndAsync();
                    
                    var doc = JsonDocument.Parse(jsonContent);
                    if (doc.RootElement.TryGetProperty("entry", out var entries))
                    {
                        Console.WriteLine($"  - ��� {entries.GetArrayLength()} �өw�q����");
                        
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
                Console.WriteLine("? ���~: ���Y�ɤ��䤣����󦳮Ī��w�q�� (�p profiles-resources.json �� definitions.json)");
                Console.ResetColor();
                Environment.Exit(1); // �䤣���ɮסA�פ����
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
                if (!string.IsNullOrEmpty(resourceName) && 
                    !_processedResources.Contains(resourceName) &&
                    IsValidResourceName(resourceName))
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
        /// �ˬd�O�_�����Ī��귽�W��
        /// </summary>
        private bool IsValidResourceName(string name)
        {
            // �ư����������M�S��귽
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
                var desc = descElement.GetString()?.Replace("\n", " ").Replace("\r", "");
                if (!string.IsNullOrEmpty(desc))
                {
                    sb.AppendLine($"    /// {desc}");
                }
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
            // �������Ҧ��ݩ�
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
                            if (parts.Length == 2) // �u�n�Ĥ@�h�ݩ�
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

            // �ͦ��ݩ�
            foreach (var kvp in properties.OrderBy(x => x.Key))
            {
                GenerateProperty(sb, kvp.Value, kvp.Key);
            }
        }

        /// <summary>
        /// �ͦ���@�ݩ�
        /// </summary>
        private void GenerateProperty(StringBuilder sb, JsonElement element, string propertyName)
        {
            var propertyType = DeterminePropertyType(element, propertyName);
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
        private string DeterminePropertyType(JsonElement element, string propertyName)
        {
            // �ˬd�O�_���}�C
            var isArray = false;
            if (element.TryGetProperty("max", out var maxElement))
            {
                var max = maxElement.GetString();
                isArray = max == "*" || (int.TryParse(max, out var maxInt) && maxInt > 1);
            }

            // ���������
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
        /// �N FHIR ���������� C# ����
        /// </summary>
        private string MapFhirTypeToCs(string? fhirType, string propertyName)
        {
            if (fhirType == "BackboneElement")
            {
                // ��� BackboneElement�A�ڭ̻ݭn�@�ӧ�S�w�������W��
                // �q�`�O ResourceName + PropertyName (���r���j�g)
                // �o�����ݭn��������޿�ӳB�z�A�Ȯɪ�^�@�Ӧ����
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
        /// �ˬd�O�_�����Ī��ݩʦW��
        /// </summary>
        private bool IsValidPropertyName(string name)
        {
            // �ư���¦�귽�ݩ�
            var excludedProperties = new HashSet<string>
            {
                "ResourceType", "Id", "Meta", "ImplicitRules", "Language", 
                "Text", "Contained", "Extension", "ModifierExtension"
            };

            return !string.IsNullOrEmpty(name) && 
                   char.IsLetter(name[0]) && 
                   !name.Contains('-') && // �ư��]�t�s�r�����L�ĸ��|����
                   name.All(c => char.IsLetterOrDigit(c) || c == '_') &&
                   !excludedProperties.Contains(name);
        }
    }
}