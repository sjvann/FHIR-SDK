
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceReportSub.RelatesToSub
{
    public class Target : BackboneElement<Target>
    {

        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("display", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Display {get; set;}
[Element("resource", typeof(Reference), false, false, false, false)]
public Reference Resource {get; set;}

        #endregion
        #region Constructor
        public  Target() { }
        public  Target(string value) : base(value) { }
        public  Target(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Target";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
