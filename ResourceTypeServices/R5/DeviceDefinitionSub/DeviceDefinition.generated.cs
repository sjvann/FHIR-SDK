

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class DeviceDefinition : DomainResource<DeviceDefinition>
    {
        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("udiDeviceIdentifier", typeof(UdiDeviceIdentifier), false, true, false, true)]
public IEnumerable<UdiDeviceIdentifier> UdiDeviceIdentifier {get; set;}
[Element("regulatoryIdentifier", typeof(RegulatoryIdentifier), false, true, false, true)]
public IEnumerable<RegulatoryIdentifier> RegulatoryIdentifier {get; set;}
[Element("partNumber", typeof(FhirString), true, false, false, false)]
public FhirString PartNumber {get; set;}
[Element("manufacturer", typeof(Reference), false, false, false, false)]
public Reference Manufacturer {get; set;}
[Element("deviceName", typeof(DeviceName), false, true, false, true)]
public IEnumerable<DeviceName> DeviceName {get; set;}
[Element("modelNumber", typeof(FhirString), true, false, false, false)]
public FhirString ModelNumber {get; set;}
[Element("classification", typeof(Classification), false, true, false, true)]
public IEnumerable<Classification> Classification {get; set;}
[Element("conformsTo", typeof(ConformsTo), false, true, false, true)]
public IEnumerable<ConformsTo> ConformsTo {get; set;}
[Element("hasPart", typeof(HasPart), false, true, false, true)]
public IEnumerable<HasPart> HasPart {get; set;}
[Element("packaging", typeof(Packaging), false, true, false, true)]
public IEnumerable<Packaging> Packaging {get; set;}
[Element("version", typeof(ResourceTypeServices.R5.DeviceDefinitionSub.Version), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.DeviceDefinitionSub.Version> Version {get; set;}
[Element("safety", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Safety {get; set;}
[Element("shelfLifeStorage", typeof(ProductShelfLife), false, true, false, false)]
public IEnumerable<ProductShelfLife> ShelfLifeStorage {get; set;}
[Element("languageCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> LanguageCode {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("owner", typeof(Reference), false, false, false, false)]
public Reference Owner {get; set;}
[Element("contact", typeof(ContactPoint), false, true, false, false)]
public IEnumerable<ContactPoint> Contact {get; set;}
[Element("link", typeof(Link), false, true, false, true)]
public IEnumerable<Link> Link {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("material", typeof(Material), false, true, false, true)]
public IEnumerable<Material> Material {get; set;}
[Element("productionIdentifierInUDI", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> ProductionIdentifierInUDI {get; set;}
[Element("guideline", typeof(Guideline), false, false, false, true)]
public Guideline Guideline {get; set;}
[Element("correctiveAction", typeof(CorrectiveAction), false, false, false, true)]
public CorrectiveAction CorrectiveAction {get; set;}
[Element("chargeItem", typeof(ChargeItem), false, true, false, true)]
public IEnumerable<ChargeItem> ChargeItem {get; set;}

        #endregion
        #region Constructor
        public  DeviceDefinition() { }

        public  DeviceDefinition(string value) : base(value) { }
        public  DeviceDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
