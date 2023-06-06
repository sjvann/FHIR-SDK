
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DiagnosticReportSub
{
    public class Media : BackboneElement<Media>
    {

        #region Property
        [Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}
[Element("link", typeof(Reference), false, false, false, false)]
public Reference Link {get; set;}

        #endregion
        #region Constructor
        public  Media() { }
        public  Media(string value) : base(value) { }
        public  Media(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Media";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
