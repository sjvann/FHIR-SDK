
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.EpisodeOfCareSub
{
    public class Diagnosis : BackboneElement<Diagnosis>
    {

        #region Property
        [Element("condition", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Condition {get; set;}
[Element("use", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Use {get; set;}

        #endregion
        #region Constructor
        public  Diagnosis() { }
        public  Diagnosis(string value) : base(value) { }
        public  Diagnosis(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Diagnosis";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
