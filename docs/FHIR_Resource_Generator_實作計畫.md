# ??? FHIR Resource Generator ��@�p�e

## ?? **�M�׷��z**

**�ؼ�**: �إߤ@�Ӱ�� FHIR �x��w�q�ɪ�����귽���;��A����۰ʥͦ��ŦX�{�N�� SDK �n�D�� R4 �귽�M�סA�ì����ӷs�����]�p R6�^���ѥi���Ϊ��ѨM��סC

**��@��H**: R4 ���� (R5 �w�����AR6 �|�����i)

## ?? **�M�ץؼ�**

### **�֤ߥؼ�**
1. **�۰ʤƸ귽�ͦ�**: ��� FHIR �x�� StructureDefinition �۰ʥͦ� R4 �귽
2. **�{�N�Ƭ[�c**: �ϥλP R5 �ۦP�� `ResourceBase<TVersion>` �]�p
3. **���~�ū~��**: ���㪺���ɡB���ҩM�u�t��k
4. **�i�X�i�[�c**: �����Ӫ����]R6/R7�^���w��¦

### **�q�ƫ���**
- **�ͦ��t��**: 3-5�������������� R4 �귽�]��100�ӡ^
- **�{���X�~��**: 100% �sĶ���\�A0 ĵ�i
- **�����л\**: 90% �H�W�{���X�л\�v
- **���ɧ���**: 100% �귽������ XML ����

## ??? **�t�ά[�c�]�p**

### **�M�׵��c**
```
Fhir_SDK/
�u�w�w Tools/
�x   �|�w�w FhirResourceGenerator/
�x       �u�w�w FhirResourceGenerator.csproj
�x       �u�w�w Program.cs                      # CLI �D�{��
�x       �u�w�w Core/
�x       �x   �u�w�w IDefinitionParser.cs        # �w�q�ɸѪR����
�x       �x   �u�w�w IResourceGenerator.cs       # �귽�ͦ�����
�x       �x   �u�w�w ITemplateEngine.cs          # �ҪO��������
�x       �x   �u�w�w GeneratorContext.cs         # �ͦ��W�U��
�x       �x   �|�w�w GenerationResult.cs         # �ͦ����G
�x       �u�w�w Parsers/
�x       �x   �u�w�w StructureDefinitionParser.cs # SD �ѪR��
�x       �x   �u�w�w ElementDefinitionParser.cs   # �����w�q�ѪR��
�x       �x   �u�w�w FhirTypeResolver.cs         # �����ѪR��
�x       �x   �|�w�w ConstraintProcessor.cs      # �����B�z��
�x       �u�w�w Generators/
�x       �x   �u�w�w ResourceClassGenerator.cs   # �귽���O�ͦ���
�x       �x   �u�w�w BackboneElementGenerator.cs # �I�������ͦ���
�x       �x   �u�w�w ChoiceTypeGenerator.cs      # ��������ͦ���
�x       �x   �u�w�w FactoryMethodGenerator.cs   # �u�t��k�ͦ���
�x       �x   �|�w�w ProjectGenerator.cs         # �M���ɥͦ���
�x       �u�w�w Templates/
�x       �x   �u�w�w ResourceTemplate.cs         # �귽�ҪO
�x       �x   �u�w�w PropertyTemplate.cs         # �ݩʼҪO
�x       �x   �u�w�w DocumentationTemplate.cs    # ���ɼҪO
�x       �x   �|�w�w FactoryTemplate.cs          # �u�t�ҪO
�x       �u�w�w Configuration/
�x       �x   �u�w�w GeneratorConfig.cs          # �ͦ����t�m
�x       �x   �u�w�w R4MappingConfig.cs          # R4 �M�g�t�m
�x       �x   �|�w�w TypeMappings.json           # �����M�g��
�x       �|�w�w Utilities/
�x           �u�w�w NamingUtils.cs              # �R�W�u��
�x           �u�w�w ValidationUtils.cs          # ���Ҥu��
�x           �|�w�w FileUtils.cs                # �ɮפu��
�u�w�w Definitions/
�x   �u�w�w R4/
�x   �x   �u�w�w profiles-resources.json         # �귽�w�q��
�x   �x   �u�w�w profiles-types.json             # �����w�q��
�x   �x   �u�w�w valuesets.json                  # �ȶ��w�q��
�x   �x   �|�w�w metadata.json                   # ���������
�x   �u�w�w R5/ (�w�s�b)
�x   �|�w�w R6/ (����)
�u�w�w FhirCore.R4/ (�N�ͦ�)
�x   �u�w�w Resources/                          # �ͦ����귽���O
�x   �u�w�w Factory/                            # �ͦ����u�t���O
�x   �u�w�w FhirCore.R4.csproj                  # �M����
�x   �|�w�w R4Version.cs                        # ������@
�|�w�w FhirCore.R4.Tests/ (�N�ͦ�)
    �u�w�w ResourceTests/                      # �귽����
    �u�w�w FactoryTests/                       # �u�t����
    �|�w�w FhirCore.R4.Tests.csproj            # ���ձM����
```

### **�֤߲ե�]�p**

#### **1. �w�q�ɸѪR�� (Definition Parser)**
```csharp
public interface IDefinitionParser
{
    Task<IEnumerable<ResourceDefinition>> ParseResourceDefinitionsAsync(string definitionPath);
    Task<IEnumerable<DataTypeDefinition>> ParseDataTypeDefinitionsAsync(string definitionPath);
    Task<VersionMetadata> ExtractVersionMetadataAsync(string definitionPath);
}

public class StructureDefinitionParser : IDefinitionParser
{
    // �ѪR StructureDefinition JSON �ɮ�
    // �����귽�ݩʡB�����B���ɵ�
    // �B�z�~�����Y�M profile �X�i
}
```

#### **2. �귽�ͦ��� (Resource Generator)**
```csharp
public interface IResourceGenerator
{
    Task<GenerationResult> GenerateResourceAsync(ResourceDefinition definition, GeneratorContext context);
    Task<GenerationResult> GenerateProjectAsync(IEnumerable<ResourceDefinition> definitions, string targetPath);
}

public class ResourceClassGenerator : IResourceGenerator
{
    // �ͦ��D�n�귽���O
    // �ͦ��ݩʡB�غc�禡�B���Ҥ�k
    // �ͦ� BackboneElement �l���O
    // �ͦ� ChoiceType ���O
}
```

#### **3. �ҪO���� (Template Engine)**
```csharp
public interface ITemplateEngine
{
    string GenerateResourceClass(ResourceDefinition definition, TemplateContext context);
    string GenerateProperty(PropertyDefinition property, TemplateContext context);
    string GenerateDocumentation(DocumentationData docs, TemplateContext context);
}
```

## ?? **��@���q�W��**

### **�Ĥ@���q�G��¦�]�I�إ�** (Week 1)

#### **1.1 �M�׬[�c�إ�** (Day 1-2)
- [ ] �Ы� `Tools/FhirResourceGenerator` �M��
- [ ] �]�p�֤ߤ����M��H���O
- [ ] �إߨ̿�`�J�e��
- [ ] �]�w��¦�t�m�t��

#### **1.2 �w�q�ɺ޲z** (Day 3-4)
- [ ] �إ� `Definitions/R4` �ؿ����c
- [ ] ��@�w�q�ɤU���}��
- [ ] �إߪ�������ƺ޲z
- [ ] �]�p�w�q�ɧ֨�����

#### **1.3 ��¦�ѪR����@** (Day 5-7)
- [ ] ��@ JSON StructureDefinition �ѪR
- [ ] ��@ ElementDefinition �ѪR
- [ ] �إ� FHIR �����M�g�t��
- [ ] �B�z�~�����Y�M����

### **�ĤG���q�G�֤ߥͦ�����@** (Week 2)

#### **2.1 �귽���O�ͦ�** (Day 8-10)
- [ ] ��@�򥻸귽���O�ҪO
- [ ] ��@�ݩʥͦ��޿�
- [ ] ��@�غc�禡�ͦ�
- [ ] ��@���Ҥ�k�ͦ�

#### **2.2 ���������B�z** (Day 11-12)
- [ ] BackboneElement �ͦ��޿�
- [ ] ChoiceType �ͦ��޿�
- [ ] �����_�����c�B�z
- [ ] ���������ഫ

#### **2.3 ���ɥͦ��t��** (Day 13-14)
- [ ] XML ���ѥͦ�
- [ ] �ϥνd�ҥͦ�
- [ ] �������ɥͦ�
- [ ] DocFX �ۮe�ʽT�O

### **�ĤT���q�GR4 �S��B�z** (Week 3)

#### **3.1 R4 vs R5 �t���B�z** (Day 15-17)
- [ ] �����t�����R�u��
- [ ] R4 �S�������B�z
- [ ] �w�����ݩʳB�z
- [ ] ��������t���B�z

#### **3.2 �u�t��k�ͦ�** (Day 18-19)
- [ ] �򥻤u�t��k�ͦ�
- [ ] �M�~�Ƥu�t��k
- [ ] ���ո�ƥͦ���k
- [ ] ���һ��U��k

#### **3.3 �����޲z��X** (Day 20-21)
- [ ] R4Version ���O�ͦ�
- [ ] �����޲z����s
- [ ] �䴩�귽�C��ͦ�
- [ ] �ۮe���ˬd��@

### **�ĥ|���q�G�~��O�һP�u��** (Week 4)

#### **4.1 ���Ҩt�ξ�X** (Day 22-24)
- [ ] �۰����ҳW�h�ͦ�
- [ ] R4 �S�w���ҹ�@
- [ ] ���~�T�����a��
- [ ] ���Үį��u��

#### **4.2 ���եͦ�** (Day 25-26)
- [ ] �椸���զ۰ʥͦ�
- [ ] ��X���եͦ�
- [ ] �į���հ��
- [ ] ���ո�ƥͦ�

#### **4.3 �M���ɩM�t�m** (Day 27-28)
- [ ] .csproj �ɮץͦ�
- [ ] NuGet �M��t�m
- [ ] �ظm�}���ͦ�
- [ ] CI/CD �t�m��s

## ??? **�޳N��@�Ӹ`**

### **�w�q�ɸѪR����**

#### **StructureDefinition �ѪR**
```csharp
public class StructureDefinitionParser
{
    public async Task<ResourceDefinition> ParseAsync(JsonElement structureDef)
    {
        var resourceDef = new ResourceDefinition
        {
            Name = structureDef.GetProperty("name").GetString(),
            Kind = structureDef.GetProperty("kind").GetString(),
            Abstract = structureDef.GetProperty("abstract").GetBoolean(),
            BaseDefinition = structureDef.GetProperty("baseDefinition").GetString(),
            Elements = await ParseElementsAsync(structureDef.GetProperty("snapshot").GetProperty("element")),
            Documentation = ExtractDocumentation(structureDef),
            Constraints = ExtractConstraints(structureDef)
        };
        
        return resourceDef;
    }
}
```

#### **��������M�g**
```csharp
public static class FhirTypeMapper
{
    private static readonly Dictionary<string, TypeMapping> R4TypeMappings = new()
    {
        ["string"] = new("FhirString", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["boolean"] = new("FhirBoolean", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["integer"] = new("FhirInteger", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["dateTime"] = new("FhirDateTime", "DataTypeServices.DataTypes.PrimitiveTypes"),
        ["Reference"] = new("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes"),
        ["CodeableConcept"] = new("CodeableConcept", "DataTypeServices.DataTypes.ComplexTypes"),
        // ... ���㪺 R4 �����M�g
    };
    
    public static TypeMapping MapFhirTypeToCSharp(string fhirType, bool isArray = false)
    {
        var mapping = R4TypeMappings.TryGetValue(fhirType, out var mapped) ? mapped : new(fhirType, "");
        return isArray ? mapping.AsArray() : mapping;
    }
}
```

### **�{���X�ͦ��ҪO**

#### **�귽���O�ҪO**
```csharp
public class ResourceTemplate
{
    public static string Generate(ResourceDefinition definition, TemplateContext context)
    {
        return $@"
using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using System.ComponentModel.DataAnnotations;

namespace FhirCore.R4.Resources
{{
    /// <summary>
    /// FHIR R4 {definition.Name} �귽
    /// 
    /// <para>
    /// {definition.Documentation.Summary}
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// {GenerateUsageExample(definition)}
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>FHIR R4 �����S�I�G</para>
    /// <list type="bullet">
    /// {GenerateR4Features(definition)}
    /// </list>
    /// 
    /// <para>��������G</para>
    /// <list type="bullet">
    /// {GenerateConstraints(definition)}
    /// </list>
    /// </remarks>
    public class {definition.Name} : ResourceBase<R4Version>
    {{
        {GeneratePrivateFields(definition)}
        
        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => ""{definition.Name}"";
        
        {GeneratePublicProperties(definition)}
        
        {GenerateConstructors(definition)}
        
        {GenerateValidationMethod(definition)}
        
        {GenerateUtilityMethods(definition)}
    }}
    
    {GenerateBackboneElements(definition)}
    
    {GenerateChoiceTypes(definition)}
}}";
    }
}
```

### **�۰ʤƤu�@�y�{**

#### **PowerShell �۰ʤƸ}��**
```powershell
# Generate-R4Resources.ps1
param(
    [string]$DefinitionsPath = "Definitions\R4",
    [string]$OutputPath = "FhirCore.R4",
    [switch]$Force = $false,
    [switch]$IncludeTests = $true,
    [switch]$UpdateSolution = $true
)

Write-Host "?? �}�l FHIR R4 �귽�ͦ�..." -ForegroundColor Green

# 1. ���ҩw�q��
Write-Host "?? ���ҩw�q��..." -ForegroundColor Yellow
if (-not (Test-Path $DefinitionsPath)) {
    Write-Error "�w�q�ɸ��|���s�b: $DefinitionsPath"
    exit 1
}

# 2. ����귽�ͦ���
Write-Host "?? ����귽�ͦ���..." -ForegroundColor Yellow
$args = @(
    "--definitions-path", $DefinitionsPath,
    "--output-path", $OutputPath,
    "--version", "R4"
)

if ($Force) { $args += "--force" }
if ($IncludeTests) { $args += "--include-tests" }

dotnet run --project Tools\FhirResourceGenerator -- $args

if ($LASTEXITCODE -ne 0) {
    Write-Error "�귽�ͦ����ѡA���~�N�X: $LASTEXITCODE"
    exit 1
}

# 3. ��s�ѨM�����
if ($UpdateSolution) {
    Write-Host "?? ��s�ѨM�����..." -ForegroundColor Yellow
    dotnet sln add "$OutputPath\FhirCore.R4.csproj"
    if ($IncludeTests) {
        dotnet sln add "$OutputPath.Tests\FhirCore.R4.Tests.csproj"
    }
}

# 4. �ظm����
Write-Host "?? ���ҥͦ����G..." -ForegroundColor Yellow
dotnet build "$OutputPath\FhirCore.R4.csproj" --configuration Release

if ($LASTEXITCODE -eq 0) {
    Write-Host "? R4 �귽�ͦ������I" -ForegroundColor Green
    
    # ��ܲέp��T
    $resourceCount = (Get-ChildItem "$OutputPath\Resources" -Filter "*.cs").Count
    $factoryCount = (Get-ChildItem "$OutputPath\Factory" -Filter "*.cs").Count
    
    Write-Host "?? �ͦ��έp�G" -ForegroundColor Cyan
    Write-Host "  - �귽�ɮ�: $resourceCount" -ForegroundColor White
    Write-Host "  - �u�t�ɮ�: $factoryCount" -ForegroundColor White
} else {
    Write-Error "�ظm���ҥ��ѡA���ˬd�ͦ����{���X"
    exit 1
}
```

#### **�R�O�C�����]�p**
```sh
# �ͦ� R4 �Ҧ��귽
dotnet run --project Tools/FhirResourceGenerator -- generate --version R4

# �ͦ��S�w�귽
dotnet run --project Tools/FhirResourceGenerator -- generate --version R4 --resources Patient,Observation,Condition

# ��s�{���M��
dotnet run --project Tools/FhirResourceGenerator -- update --version R4 --target FhirCore.R4

# ���ҩw�q��
dotnet run --project Tools/FhirResourceGenerator -- validate --definitions-path Definitions/R4

# ��������t��
dotnet run --project Tools/FhirResourceGenerator -- compare --from R4 --to R5 --output docs/R4-R5-differences.md

# �ͦ��M�׳��i
dotnet run --project Tools/FhirResourceGenerator -- report --version R4 --output reports/R4-generation-report.md
```

## ?? **�~��O�ұ��I**

### **1. �۰ʤƴ���**
```csharp
[TestFixture]
public class GeneratedResourceValidationTests
{
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_CompileSuccessfully(Type resourceType)
    {
        // ���ҩҦ��ͦ����귽���ॿ�`�sĶ
        var instance = Activator.CreateInstance(resourceType);
        Assert.That(instance, Is.Not.Null);
        Assert.That(instance, Is.InstanceOf<ResourceBase<R4Version>>());
    }
    
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_HaveFactoryMethods(Type resourceType)
    {
        // ���ҩҦ��귽�����������u�t��k
        var factoryMethod = typeof(R4Factory).GetMethod($"Create{resourceType.Name}");
        Assert.That(factoryMethod, Is.Not.Null);
    }
    
    [Test]
    [TestCaseSource(nameof(GetAllR4Resources))]
    public void AllResources_Should_HaveCompleteDocumentation(Type resourceType)
    {
        // ���ҩҦ��귽�������㪺 XML ����
        var xmlDoc = resourceType.GetCustomAttribute<System.ComponentModel.DescriptionAttribute>();
        Assert.That(xmlDoc, Is.Not.Null);
    }
}
```

### **2. �{���X�~���ˬd**
```yaml
# .github/workflows/r4-generation-quality.yml
name: R4 Resource Generation Quality Check
on: 
  push:
    paths: ['Tools/FhirResourceGenerator/**', 'Definitions/R4/**']
  pull_request:
    paths: ['Tools/FhirResourceGenerator/**', 'Definitions/R4/**']

jobs:
  generate-and-test:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v4
      
      - name: Setup .NET 9
        uses: actions/setup-dotnet@v4
        with:
          dotnet-version: '9.0.x'
      
      - name: Download R4 Definitions
        run: |
          ./Tools/Scripts/Download-FhirDefinitions.ps1 -Version R4
      
      - name: Generate R4 Resources
        run: |
          dotnet run --project Tools/FhirResourceGenerator -- generate --version R4
      
      - name: Build Generated Code
        run: |
          dotnet build FhirCore.R4/FhirCore.R4.csproj --configuration Release
      
      - name: Run Tests
        run: |
          dotnet test FhirCore.R4.Tests/FhirCore.R4.Tests.csproj --configuration Release
      
      - name: Code Quality Analysis
        run: |
          dotnet format FhirCore.R4/FhirCore.R4.csproj --verify-no-changes
          dotnet build FhirCore.R4/FhirCore.R4.csproj --verbosity normal /p:TreatWarningsAsErrors=true
```

### **3. �į��Ǵ���**
```csharp
[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net90)]
public class ResourceGenerationBenchmarks
{
    [Benchmark]
    public async Task GenerateSingleResource()
    {
        var parser = new StructureDefinitionParser();
        var generator = new ResourceClassGenerator();
        
        var definition = await parser.ParseAsync("Definitions/R4/Patient.json");
        await generator.GenerateResourceAsync(definition, new GeneratorContext());
    }
    
    [Benchmark]
    public async Task GenerateAllR4Resources()
    {
        var generator = new ProjectGenerator();
        await generator.GenerateProjectAsync("Definitions/R4", "temp/R4");
    }
    
    [Benchmark]
    public void R4Factory_CreatePatient()
    {
        var patient = R4Factory.CreatePatient("test-001");
    }
}
```

## ?? **�����X�i�p��**

### **R6 �䴩�ǳ�**
�� R6 �w�q�ɵo���ɡA�u�ݭn�G
1. **�U�� R6 �w�q��**: `./Download-FhirDefinitions.ps1 -Version R6`
2. **����ͦ���**: `dotnet run --project Tools/FhirResourceGenerator -- generate --version R6`
3. **�B�z�����t��**: �s�W R6 �S�w�����M�g
4. **��s�����޲z**: �s�W `FhirR6Version` ���O

### **�󪩥��E���u��**
```csharp
// �۰ʥͦ������E����
public static class ResourceMigrator
{
    public static FhirCore.R5.Resources.Patient MigrateToR5(FhirCore.R4.Resources.Patient r4Patient)
    {
        // ���w�q�ɮt���۰ʥͦ��E���޿�
        return new FhirCore.R5.Resources.Patient
        {
            Id = r4Patient.Id,
            Identifier = r4Patient.Identifier,
            Name = r4Patient.Name,
            // �B�z R4 -> R5 ���ݩ��ܤ�
        };
    }
}
```

### **Visual Studio ��X**
```xml
<!-- FhirResourceGenerator.targets -->
<Project>
  <PropertyGroup>
    <GenerateFhirResourcesOnBuild Condition="'$(GenerateFhirResourcesOnBuild)' == ''">false</GenerateFhirResourcesOnBuild>
  </PropertyGroup>
  
  <Target Name="GenerateR4Resources" BeforeTargets="BeforeBuild" Condition="'$(GenerateFhirResourcesOnBuild)' == 'true'">
    <Exec Command="dotnet run --project $(MSBuildThisFileDirectory)Tools\FhirResourceGenerator -- generate --version R4" />
  </Target>
</Project>
```

## ?? **���\����**

### **�޳N����**
- **�ͦ��t��**: < 5������������ R4 �귽
- **�{���X�~��**: 100% �sĶ���\�A0 �R�A���Rĵ�i
- **�����л\**: > 90% �{���X�л\�v
- **���ɧ���**: 100% �귽�����~�� XML ����

### **��q����**
- **�[�c�@�P��**: �P R5 �ۦP���]�p�Ҧ�
- **�V�e�ۮe��**: �� R6 ���n�[�c�ǳ�
- **�}�o����**: ���㪺 IntelliSense �M�sĶ���ˬd
- **���@��**: �M�����{���X���c�M����

### **�~�ȫ���**
- **�}�o�Ĳv**: �ۤ��ʶ}�o���� 95% �Ĳv
- **���~���**: �۰ʤƮ����H�����~
- **�зǤ�**: 100% �ŦX FHIR �x��W�d
- **�i���Ω�**: �u��i�Ω󥼨өҦ�����

## ?? **����p��**

### **�ߧY�}�l**
1. **�T�{�p��**: �f�֨ýT�{����@�p��
2. **�إ߱M��**: �Ы� `Tools/FhirResourceGenerator` �M��
3. **�U���w�q��**: ���o FHIR R4 �x��w�q��
4. **�}�l�Ĥ@���q**: �إ߰�¦�]�I

### **���{�O�ˬd�I**
- **Week 1 ����**: ��¦�]�I�����A�򥻸ѪR���u�@
- **Week 2 ����**: ��ͦ��򥻪��귽���O
- **Week 3 ����**: R4 �S��B�z�����A�u�t��k�ͦ�
- **Week 4 ����**: ���㪺 R4 �M�ץͦ��A�Ҧ����ճq�L

### **���I�ޱ�**
- **�޳N���I**: ������ StructureDefinition �ѪR �� �q������@�A���B�z²��귽
- **�~�護�I**: �ͦ��{���X�~�褣�@�P �� �Y�檺�ҪO�M���Ҿ���
- **�ɵ{���I**: �C�������� �� �C�g�ˬd�I�A�ήɽվ�

---

**��󪩥�**: 1.0  
**�إߤ��**: 2025�~8��3��  
**�t�d�H**: GitHub Copilot  
**�f�֪��A**: �ݽT�{