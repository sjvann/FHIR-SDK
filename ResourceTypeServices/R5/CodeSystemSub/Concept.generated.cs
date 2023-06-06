
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CodeSystemSub.ConceptSub;

namespace ResourceTypeServices.R5.CodeSystemSub
{
    public class Concept : BackboneElement<Concept>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("definition", typeof(FhirString), true, false, false, false)]
public FhirString Definition {get; set;}
[Element("designation", typeof(Designation), false, true, false, true)]
public IEnumerable<Designation> Designation {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}

        #endregion
        #region Constructor
        public  Concept() { }
        public  Concept(string value) : base(value) { }
        public  Concept(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Concept";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
