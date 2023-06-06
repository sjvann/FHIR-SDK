
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationDispenseSub
{
    public class Substitution : BackboneElement<Substitution>
    {

        #region Property
        [Element("wasSubstituted", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean WasSubstituted {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("reason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Reason {get; set;}
[Element("responsibleParty", typeof(Reference), false, false, false, false)]
public Reference ResponsibleParty {get; set;}

        #endregion
        #region Constructor
        public  Substitution() { }
        public  Substitution(string value) : base(value) { }
        public  Substitution(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Substitution";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
