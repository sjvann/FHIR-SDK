
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CoverageEligibilityResponseSub.InsuranceSub.ItemSub;

namespace ResourceTypeServices.R5.CoverageEligibilityResponseSub.InsuranceSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("productOrService", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductOrService {get; set;}
[Element("modifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modifier {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("excluded", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Excluded {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("network", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Network {get; set;}
[Element("unit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Unit {get; set;}
[Element("term", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Term {get; set;}
[Element("benefit", typeof(Benefit), false, true, false, true)]
public IEnumerable<Benefit> Benefit {get; set;}
[Element("authorizationRequired", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AuthorizationRequired {get; set;}
[Element("authorizationSupporting", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> AuthorizationSupporting {get; set;}
[Element("authorizationUrl", typeof(FhirUri), true, false, false, false)]
public FhirUri AuthorizationUrl {get; set;}

        #endregion
        #region Constructor
        public  Item() { }
        public  Item(string value) : base(value) { }
        public  Item(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Item";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
