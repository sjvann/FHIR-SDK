
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ValueSetSub.ExpansionSub;

namespace ResourceTypeServices.R5.ValueSetSub
{
    public class Expansion : BackboneElement<Expansion>
    {

        #region Property
        [Element("identifier", typeof(FhirUri), true, false, false, false)]
public FhirUri Identifier {get; set;}
[Element("next", typeof(FhirUri), true, false, false, false)]
public FhirUri Next {get; set;}
[Element("timestamp", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Timestamp {get; set;}
[Element("total", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Total {get; set;}
[Element("offset", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Offset {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("contains", typeof(Contains), false, true, false, true)]
public IEnumerable<Contains> Contains {get; set;}

        #endregion
        #region Constructor
        public  Expansion() { }
        public  Expansion(string value) : base(value) { }
        public  Expansion(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Expansion";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
