
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationRequestSub
{
    public class Substitution : BackboneElement<Substitution>
    {

        #region Property
        [Element("allowed", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Allowed {get; set;}
[Element("reason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Reason {get; set;}

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
