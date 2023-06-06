

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.InsurancePlanSub
{
    public class InsurancePlan : DomainResource<InsurancePlan>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("alias", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Alias {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("ownedBy", typeof(Reference), false, false, false, false)]
public Reference OwnedBy {get; set;}
[Element("administeredBy", typeof(Reference), false, false, false, false)]
public Reference AdministeredBy {get; set;}
[Element("coverageArea", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CoverageArea {get; set;}
[Element("contact", typeof(ExtendedContactDetail), false, true, false, false)]
public IEnumerable<ExtendedContactDetail> Contact {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("network", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Network {get; set;}
[Element("coverage", typeof(Coverage), false, true, false, true)]
public IEnumerable<Coverage> Coverage {get; set;}
[Element("plan", typeof(Plan), false, true, false, true)]
public IEnumerable<Plan> Plan {get; set;}

        #endregion
        #region Constructor
        public  InsurancePlan() { }

        public  InsurancePlan(string value) : base(value) { }
        public  InsurancePlan(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "InsurancePlan";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
