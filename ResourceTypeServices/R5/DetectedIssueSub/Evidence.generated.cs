
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DetectedIssueSub
{
    public class Evidence : BackboneElement<Evidence>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Code {get; set;}
[Element("detail", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Detail {get; set;}

        #endregion
        #region Constructor
        public  Evidence() { }
        public  Evidence(string value) : base(value) { }
        public  Evidence(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Evidence";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
