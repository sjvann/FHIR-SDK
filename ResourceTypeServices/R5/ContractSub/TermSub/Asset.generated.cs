
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ContractSub.TermSub.AssetSub;

namespace ResourceTypeServices.R5.ContractSub.TermSub
{
    public class Asset : BackboneElement<Asset>
    {

        #region Property
        [Element("scope", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Scope {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("typeReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> TypeReference {get; set;}
[Element("subtype", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Subtype {get; set;}
[Element("relationship", typeof(Coding), false, false, false, false)]
public Coding Relationship {get; set;}
[Element("context", typeof(Context), false, true, false, true)]
public IEnumerable<Context> Context {get; set;}
[Element("condition", typeof(FhirString), true, false, false, false)]
public FhirString Condition {get; set;}
[Element("periodType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PeriodType {get; set;}
[Element("period", typeof(Period), false, true, false, false)]
public IEnumerable<Period> Period {get; set;}
[Element("usePeriod", typeof(Period), false, true, false, false)]
public IEnumerable<Period> UsePeriod {get; set;}
[Element("linkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> LinkId {get; set;}
[Element("securityLabelNumber", typeof(FhirUnsignedInt), true, true, false, false)]
public IEnumerable<FhirUnsignedInt> SecurityLabelNumber {get; set;}
[Element("valuedItem", typeof(ValuedItem), false, true, false, true)]
public IEnumerable<ValuedItem> ValuedItem {get; set;}

        #endregion
        #region Constructor
        public  Asset() { }
        public  Asset(string value) : base(value) { }
        public  Asset(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Asset";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
