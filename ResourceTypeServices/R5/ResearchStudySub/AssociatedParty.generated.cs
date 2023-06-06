
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchStudySub
{
    public class AssociatedParty : BackboneElement<AssociatedParty>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("period", typeof(Period), false, true, false, false)]
public IEnumerable<Period> Period {get; set;}
[Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}

        #endregion
        #region Constructor
        public  AssociatedParty() { }
        public  AssociatedParty(string value) : base(value) { }
        public  AssociatedParty(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "AssociatedParty";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
