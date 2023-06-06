
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.AuditEventSub
{
    public class Source : BackboneElement<Source>
    {

        #region Property
        [Element("site", typeof(Reference), false, false, false, false)]
public Reference Site {get; set;}
[Element("observer", typeof(Reference), false, false, false, false)]
public Reference Observer {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}

        #endregion
        #region Constructor
        public  Source() { }
        public  Source(string value) : base(value) { }
        public  Source(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Source";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
