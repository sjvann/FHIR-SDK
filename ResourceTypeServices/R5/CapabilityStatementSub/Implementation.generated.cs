
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class Implementation : BackboneElement<Implementation>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("url", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Url {get; set;}
[Element("custodian", typeof(Reference), false, false, false, false)]
public Reference Custodian {get; set;}

        #endregion
        #region Constructor
        public  Implementation() { }
        public  Implementation(string value) : base(value) { }
        public  Implementation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Implementation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
