# TypeFramework

**單一** `Fhir.TypeFramework` NuGet 承載跨 R4／R4B／R5 共用的 Normative primitives、基底類別（`Resource`、`DomainResource`）、通用複合型別，以及 `FhirJsonSerializer`。

## 設計約束

- **不要**依 FHIR 大版本再拆 TypeFramework。線別差異落在產生的 `Fhir.Resources.{Line}`，不是再做一份「R5 專用 TypeFramework」。
- 複合型別或資源基底不足時，優先在同一 TypeFramework 內擴充。
- `Fhir.TypeFramework.Interop` 提供 POCO 建構與 choice 存取輔助。
- `Base.Overflow`、`TryGetValue`／`SetValue`／`EnumerateElements` 保留未知元素。
- Primitive 預設延遲解析（`PrimitiveTypeOptions.TypedParseTiming = Deferred`）。
- `Fhir.TypeFramework.Metadata` 為產生式／反射 metadata 契約。

## 與資源組件的邊界

資源組件只承載該 Registry 套件 StructureDefinition 所定義的資源形狀，並 `ProjectReference`／`PackageReference` 同一條 TypeFramework。

歷史設計筆記仍留在 `Fhir.TypeFramework/Docs/`（實作過程紀錄，不納入本站導覽）。

## 延伸閱讀

- [套件分層](architecture.md)
- [資源產生管線](resource-generation.md)
- [API 參考](../api/index.md)
