# FHIR SDK �[�c���c��@�p�e

## ���D���R

### ��e�[�c���D
1. **�����V�X���D** - `ResourceTypeServices.R5` �R�W�Ŷ��U�V�X�F�Ҧ� R5 �귽
2. **IntelliSense �䴩����** - �}�o�̵L�k�b�sĶ�ɴ���o��T�������S�w����
3. **�����Ĭ��I** - ���P�������ۦP�귽�����i�ಣ�ͽĬ�
4. **���@�����װ�** - �����޲z���ݭn�����������M�g
5. **���p�]���l** - ���ε{���ݭn�]�t�Ҧ��������{���X

## ��ĳ���s�[�c

### �M�׵��c����
```
FhirSDK/
�u�w�w Docs/                           # ���ؿ�
�u�w�w FhirCore/                       # �֤ߦ@�αM��
�x   �u�w�w Interfaces/                 # �@�Τ���
�x   �u�w�w Base/                       # ��¦���O
�x   �u�w�w Validation/                 # �@�������޿�
�x   �|�w�w Common/                     # �@�Τu��
�u�w�w DataTypeServices/               # ��������A�� (�����L��)
�u�w�w TerminologyService/             # �N�y�A�� (�����L��)
�u�w�w FhirCore.R4/                   # R4 �����S�w�M��
�x   �u�w�w Resources/                  # R4 �귽
�x   �u�w�w DataTypes/                  # R4 �S�w�������
�x   �|�w�w Validation/                 # R4 �����޿�
�u�w�w FhirCore.R5/                   # R5 �����S�w�M��
�x   �u�w�w Resources/                  # R5 �귽
�x   �u�w�w DataTypes/                  # R5 �S�w�������
�x   �|�w�w Validation/                 # R5 �����޿�
�|�w�w FhirCore.R6/                   # R6 �����S�w�M�� (����)
```

### NuGet �M�󵦲�
```
FhirCore                           # ��¦�M��
�u�w�w DataTypeServices              # �������
�u�w�w TerminologyService            # �N�y�A��
�u�w�w FhirCore.R4                   # R4 ����M��
�u�w�w FhirCore.R5                   # R5 ����M��
�|�w�w FhirCore.Tools                # �}�o�u��M��
```

## ��@�B�J

### �Ĥ@���q�G�إ߷s���֤߬[�c (1-2 �g)

#### 1.1 ���c FhirCore �M��
```csharp
// FhirCore/Interfaces/IFhirVersion.cs
namespace FhirCore.Interfaces
{
    public interface IFhirVersion
    {
        string VersionNumber { get; }
        string DisplayName { get; }
        string Specification { get; }
    }
}

// FhirCore/Interfaces/IFhirResource.cs
namespace FhirCore.Interfaces
{
    public interface IFhirResource<TVersion> where TVersion : IFhirVersion
    {
        string Id { get; set; }
        string ResourceType { get; }
        TVersion Version { get; }
        ValidationResult Validate();
    }
}
```

#### 1.2 �إߪ����S�w��¦���O
```csharp
// FhirCore/Base/ResourceBase.cs
namespace FhirCore.Base
{
    public abstract class ResourceBase<TVersion> : IFhirResource<TVersion> 
        where TVersion : IFhirVersion, new()
    {
        public string Id { get; set; } = string.Empty;
        public abstract string ResourceType { get; }
        public TVersion Version => new();
        
        public virtual ValidationResult Validate()
        {
            // ��¦�����޿�
            return ValidationResult.Success();
        }
    }
}
```

### �ĤG���q�G�إ� R5 �����M�� (2-3 �g)

#### 2.1 �إ� FhirCore.R5 �M��
```xml
<!-- FhirCore.R5/FhirCore.R5.csproj -->
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net9.0</TargetFramework>
    <PackageId>FhirCore.R5</PackageId>
    <Version>1.0.0</Version>
    <Title>FHIR R5 Implementation</Title>
    <Description>FHIR R5 �귽�M���������@</Description>
  </PropertyGroup>
  
  <ItemGroup>
    <ProjectReference Include="../FhirCore/FhirCore.csproj" />
    <ProjectReference Include="../DataTypeServices/DataTypeServices.csproj" />
    <ProjectReference Include="../TerminologyService/TerminologyService.csproj" />
  </ItemGroup>
</Project>
```

#### 2.2 �w�q R5 ����
```csharp
// FhirCore.R5/R5Version.cs
namespace FhirCore.R5
{
    public class R5Version : IFhirVersion
    {
        public string VersionNumber => "5.0.0";
        public string DisplayName => "FHIR R5";
        public string Specification => "http://hl7.org/fhir/R5/";
    }
}
```

#### 2.3 �E�� R5 �귽
```csharp
// FhirCore.R5/Resources/Patient.cs
namespace FhirCore.R5.Resources
{
    public class Patient : ResourceBase<R5Version>
    {
        public override string ResourceType => "Patient";
        
        // R5 �S�w�ݩ�
        public List<HumanName>? Name { get; set; }
        public CodeableConcept? Gender { get; set; }
        public FhirDate? BirthDate { get; set; }
        
        // R5 �S�w����
        public override ValidationResult Validate()
        {
            var result = base.Validate();
            // R5 �S�w�����޿�
            return result;
        }
    }
}
```

### �ĤT���q�G�إ� R4 �����M�� (2-3 �g)

#### 3.1 �إ� FhirCore.R4 �M��
```csharp
// FhirCore.R4/R4Version.cs
namespace FhirCore.R4
{
    public class R4Version : IFhirVersion
    {
        public string VersionNumber => "4.0.1";
        public string DisplayName => "FHIR R4";
        public string Specification => "http://hl7.org/fhir/R4/";
    }
}

// FhirCore.R4/Resources/Patient.cs
namespace FhirCore.R4.Resources
{
    public class Patient : ResourceBase<R4Version>
    {
        public override string ResourceType => "Patient";
        
        // R4 �S�w�ݩ� (�i��P R5 �������P)
        public List<HumanName>? Name { get; set; }
        public FhirCode? Gender { get; set; }  // R4 �ϥ� code�AR5 �ϥ� CodeableConcept
        public FhirDate? BirthDate { get; set; }
        
        // R4 �S�w����
        public override ValidationResult Validate()
        {
            var result = base.Validate();
            // R4 �S�w�����޿�
            return result;
        }
    }
}
```

### �ĥ|���q�G�}�o�������u�� (1-2 �g)

#### 4.1 �u�t�Ҧ��䴩
```csharp
// FhirCore/Factory/FhirFactory.cs
namespace FhirCore.Factory
{
    public static class FhirFactory
    {
        public static class R4
        {
            public static FhirCore.R4.Resources.Patient CreatePatient() 
                => new FhirCore.R4.Resources.Patient();
            
            public static FhirCore.R4.Resources.Observation CreateObservation() 
                => new FhirCore.R4.Resources.Observation();
        }
        
        public static class R5
        {
            public static FhirCore.R5.Resources.Patient CreatePatient() 
                => new FhirCore.R5.Resources.Patient();
            
            public static FhirCore.R5.Resources.Observation CreateObservation() 
                => new FhirCore.R5.Resources.Observation();
        }
    }
}
```

#### 4.2 �����S�w�X�i��k
```csharp
// FhirCore.R5/Extensions/R5Extensions.cs
namespace FhirCore.R5.Extensions
{
    public static class R5Extensions
    {
        public static Patient WithName(this Patient patient, string given, string family)
        {
            patient.Name = new List<HumanName>
            {
                new HumanName
                {
                    Given = new List<FhirString> { new(given) },
                    Family = new FhirString(family)
                }
            };
            return patient;
        }
    }
}
```

## �}�o�̨ϥΤ覡

### ��� A�G���T�������
```csharp
// �M�ץu�ݤޥίS�w����
// <PackageReference Include="FhirCore.R5" Version="1.0.0" />

using FhirCore.R5.Resources;
using FhirCore.R5.Extensions;

// �sĶ�ɴ��T�w�����A���� IntelliSense �䴩
var patient = new Patient()
    .WithName("John", "Doe")
    .WithGender(GenderCodes.Male);
```

### ��� B�G�u�t�Ҧ�
```csharp
using FhirCore.Factory;

var r5Patient = FhirFactory.R5.CreatePatient();
var r4Patient = FhirFactory.R4.CreatePatient();
```

### ��� C�G�h�����䴩
```csharp
// �P�ɤޥΦh�Ӫ���
// <PackageReference Include="FhirCore.R4" Version="1.0.0" />
// <PackageReference Include="FhirCore.R5" Version="1.0.0" />

using R4 = FhirCore.R4.Resources;
using R5 = FhirCore.R5.Resources;

var r4Patient = new R4.Patient();
var r5Patient = new R5.Patient();
```

## �E������

### �۰ʾE���u��
```csharp
// FhirCore.Tools/Migration/VersionMigrator.cs
namespace FhirCore.Tools.Migration
{
    public static class VersionMigrator
    {
        public static FhirCore.R5.Resources.Patient MigrateToR5(
            FhirCore.R4.Resources.Patient r4Patient)
        {
            return new FhirCore.R5.Resources.Patient
            {
                Id = r4Patient.Id,
                Name = r4Patient.Name,
                // �B�z Gender ���ഫ
                Gender = ConvertGender(r4Patient.Gender),
                BirthDate = r4Patient.BirthDate
            };
        }
        
        private static CodeableConcept? ConvertGender(FhirCode? r4Gender)
        {
            if (r4Gender?.Value == null) return null;
            
            return new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = new FhirUri("http://hl7.org/fhir/administrative-gender"),
                        Code = new FhirCode(r4Gender.Value),
                        Display = new FhirString(GetGenderDisplay(r4Gender.Value))
                    }
                }
            };
        }
    }
}
```

## ��ĳ���U�@�B���

### �ߧY���
1. �إ� `Docs/` �ؿ��ñN���p�e����J
2. �}�l���c `FhirCore` �M�ת������w�q
3. �إ� `FhirCore.R5` �M�רþE���{�� R5 �귽

### �������
1. �إ� `FhirCore.R4` �M��
2. ��@���������E���u��
3. �إߧ��㪺�ϥΤ��M�d��

### �������
1. �����Ӫ� R6 �����w�d�[�c�Ŷ�
2. �إ� CI/CD �y�{�䴩�h��������
3. �إߪ��s�^�m���n

�o�ӷs�[�c�N�����ѨM��e�����D�A���ѧ�n���}�o������M��M���������޲z�C