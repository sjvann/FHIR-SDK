
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.GraphDefinitionSub.LinkSub;

namespace ResourceTypeServices.R5.GraphDefinitionSub
{
    public class Link : BackboneElement<Link>
    {

        #region Property
        [Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("min", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Min {get; set;}
[Element("max", typeof(FhirString), true, false, false, false)]
public FhirString Max {get; set;}
[Element("sourceId", typeof(FhirId), true, false, false, false)]
public FhirId SourceId {get; set;}
[Element("path", typeof(FhirString), true, false, false, false)]
public FhirString Path {get; set;}
[Element("sliceName", typeof(FhirString), true, false, false, false)]
public FhirString SliceName {get; set;}
[Element("targetId", typeof(FhirId), true, false, false, false)]
public FhirId TargetId {get; set;}
[Element("params", typeof(FhirString), true, false, false, false)]
public FhirString Params {get; set;}
[Element("compartment", typeof(Compartment), false, true, false, true)]
public IEnumerable<Compartment> Compartment {get; set;}

        #endregion
        #region Constructor
        public  Link() { }
        public  Link(string value) : base(value) { }
        public  Link(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Link";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
