
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PermissionSub
{
    public class Justification : BackboneElement<Justification>
    {

        #region Property
        [Element("basis", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Basis {get; set;}
[Element("evidence", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Evidence {get; set;}

        #endregion
        #region Constructor
        public  Justification() { }
        public  Justification(string value) : base(value) { }
        public  Justification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Justification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
