
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub
{
    public class DependsOn : BackboneElement<DependsOn>
    {

        #region Property
        [Element("uri", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Uri {get; set;}
[Element("packageId", typeof(FhirId), true, false, false, false)]
public FhirId PackageId {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("reason", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Reason {get; set;}

        #endregion
        #region Constructor
        public  DependsOn() { }
        public  DependsOn(string value) : base(value) { }
        public  DependsOn(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DependsOn";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
