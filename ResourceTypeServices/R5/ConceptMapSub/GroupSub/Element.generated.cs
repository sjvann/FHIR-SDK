
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ConceptMapSub.GroupSub.ElementSub;

namespace ResourceTypeServices.R5.ConceptMapSub.GroupSub
{
    public class Element : BackboneElement<Element>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}
[Element("noMap", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean NoMap {get; set;}
[Element("target", typeof(Target), false, true, false, true)]
public IEnumerable<Target> Target {get; set;}

        #endregion
        #region Constructor
        public  Element() { }
        public  Element(string value) : base(value) { }
        public  Element(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Element";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
