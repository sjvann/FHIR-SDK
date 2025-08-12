# FHIR SDK �[�c���c��ĳ

## �s�[�c���z

### �֤߮M�󵲺c
```
FhirCore/                          # �֤ߦ@�ήM��
�u�w�w FhirCore.csproj               # ��¦�����M��H��
�u�w�w Interfaces/                   # �@�Τ���
�u�w�w Base/                         # ��¦���O
�u�w�w Validation/                   # �@�������޿�
�|�w�w Common/                       # �@�Τu��

DataTypeServices/                  # ��������@�ήM��
�u�w�w DataTypeServices.csproj       # ��¦�������
�u�w�w PrimitiveTypes/               # ��l�������
�u�w�w ComplexTypes/                 # �ƦX�������
�|�w�w Common/                       # �@�θ�������޿�

FhirCore.R4/                      # R4 �����S�w�M��
�u�w�w FhirCore.R4.csproj           # R4 �֤�
�u�w�w Resources/                    # R4 �귽�w�q
�u�w�w DataTypes/                    # R4 �S�w�������
�u�w�w Validation/                   # R4 �����޿�
�|�w�w Extensions/                   # R4 �X�i

FhirCore.R5/                      # R5 �����S�w�M��
�u�w�w FhirCore.R5.csproj           # R5 �֤�
�u�w�w Resources/                    # R5 �귽�w�q
�u�w�w DataTypes/                    # R5 �S�w�������
�u�w�w Validation/                   # R5 �����޿�
�|�w�w Extensions/                   # R5 �X�i

FhirCore.R6/                      # R6 �����S�w�M�� (����)
�u�w�w FhirCore.R6.csproj           # R6 �֤�
�|�w�w ...

TerminologyService/               # �N�y�A�� (�����L��)
�u�w�w TerminologyService.csproj
�|�w�w ValueSets/

FhirCore.Tools/                   # �}�o�u��M��
�u�w�w FhirCore.Tools.csproj
�u�w�w CodeGeneration/              # �{���X���ͤu��
�|�w�w Migration/                   # �����E���u��
```

### �M��̩ۨʬ[�c
```
FhirCore (��¦)
�u�w�w DataTypeServices �� FhirCore
�u�w�w TerminologyService �� FhirCore
�u�w�w FhirCore.R4 �� FhirCore + DataTypeServices
�u�w�w FhirCore.R5 �� FhirCore + DataTypeServices
�|�w�w FhirCore.R6 �� FhirCore + DataTypeServices
```

## ��@�Ӹ`

### 1. �֤ߤ����w�q (FhirCore)
```csharp
namespace FhirCore.Interfaces
{
    public interface IFhirResource<TVersion> where TVersion : IFhirVersion
    {
        string Id { get; set; }
        string ResourceType { get; }
        TVersion Version { get; }
    }
    
    public interface IFhirVersion
    {
        string VersionNumber { get; }
        string DisplayName { get; }
    }
}
```

### 2. �����S�w��@ (FhirCore.R5)
```csharp
namespace FhirCore.R5
{
    public class R5Version : IFhirVersion
    {
        public string VersionNumber => "5.0.0";
        public string DisplayName => "FHIR R5";
    }
    
    public class Patient : ResourceBase<R5Version>, IFhirResource<R5Version>
    {
        public R5Version Version => new();
        public string ResourceType => "Patient";
        
        // R5 �S�w�ݩ�
        public List<HumanName>? Name { get; set; }
        public CodeableConcept? Gender { get; set; }
        // ... ��L R5 Patient �ݩ�
    }
}
```

### 3. �}�o�̨ϥΤ覡
```csharp
// ��� A: ���T�������
using FhirCore.R5;
using R5Patient = FhirCore.R5.Patient;

var patient = new R5Patient
{
    Name = new List<HumanName> { ... }
};

// ��� B: �u�t�Ҧ�
using FhirCore.Factory;

var factory = FhirFactory.ForVersion("R5");
var patient = factory.CreateResource<Patient>();

// ��� C: �j���O�������
using FhirCore.R5;

public class MyR5Service
{
    public void ProcessPatient(Patient patient) // ���T�� R5 Patient
    {
        // �sĶ�ɴ��N�T�w�����A���� IntelliSense �䴩
    }
}
```

## �u��

### 1. �sĶ�ɴ������w��
- �}�o�̦b�M�פ����T��ܪ���
- IDE ���ѧ��㪺�����S�w IntelliSense
- �sĶ�ɴ��N��o�{�������ۮe���D

### 2. ²�ƪ��̩ۨʺ޲z
```xml
<!-- �ϥ� R5 ���M�� -->
<PackageReference Include="FhirCore.R5" Version="1.0.0" />

<!-- �ϥ� R4 ���M�� -->
<PackageReference Include="FhirCore.R4" Version="1.0.0" />

<!-- �P�ɤ䴩�h�������M�� -->
<PackageReference Include="FhirCore.R4" Version="1.0.0" />
<PackageReference Include="FhirCore.R5" Version="1.0.0" />
```

### 3. �W�ߪ����t�i
- �C�Ӫ����i�H�W�ߧ�s
- ��֪��������ۤ��v�T
- �K����@�M����

### 4. ��n���}�o������
- �M�����M����
- ���㪺 IntelliSense �䴩
- ��ְ���ɴ����~

### 5. �F�������p�ﶵ
- �u���p�ݭn������
- ������ε{���j�p
- �������J�į�

## �E������

### ���q 1: ���c�֤߬[�c (2-3 �g)
1. �إ߷s�� FhirCore ��¦�M��
2. ���c DataTypeServices ���@�ήM��
3. �إߪ����S�w����¦�[�c

### ���q 2: �إ� R5 �����M�� (2-3 �g)
1. �إ� FhirCore.R5 �M��
2. �E���{�� R5 �귽��s�[�c
3. ��@ R5 �S�w�����޿�

### ���q 3: �إ� R4 �����M�� (2-3 �g)
1. �إ� FhirCore.R4 �M��
2. ��@ R4 �귽�M����
3. �T�O R4/R5 �æs

### ���q 4: �u��M��� (1-2 �g)
1. �إ߾E���u��
2. ���g�ϥΤ��
3. �إ߽d�ұM��

## �޳N�Ҷq

### �R�W�Ŷ�����
```csharp
// �M�����R�W�Ŷ��Ϥ�
FhirCore.R4.Resources.Patient
FhirCore.R5.Resources.Patient
FhirCore.R6.Resources.Patient

// �ΨϥΧO�W
using R4 = FhirCore.R4.Resources;
using R5 = FhirCore.R5.Resources;

var r4Patient = new R4.Patient();
var r5Patient = new R5.Patient();
```

### �@�ε{���X�B�z
```csharp
// �ϥΪx����¦���O�B�z�@���޿�
public abstract class ResourceBase<TVersion> 
    where TVersion : IFhirVersion, new()
{
    public string Id { get; set; }
    public abstract string ResourceType { get; }
    public TVersion Version => new();
    
    // �@�������޿�
    public virtual ValidationResult Validate()
    {
        // ��¦����
    }
}
```

### �ǦC�Ƥ䴩
```csharp
// �����P�����ǦC��
public class FhirJsonConverter<TVersion> : JsonConverter
    where TVersion : IFhirVersion
{
    public override object ReadJson(JsonReader reader, Type objectType, 
        object existingValue, JsonSerializer serializer)
    {
        // �����S�w���ϧǦC���޿�
    }
}
```

�o�Ӭ[�c�N���ѧ�n���}�o������B��M���������޲z�A�H�Χ��F�������p�ﶵ�C��ĳ�u����@�o�ӷs�[�c�ӸѨM�ثe�����D�C