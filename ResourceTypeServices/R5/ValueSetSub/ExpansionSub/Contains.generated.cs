
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ValueSetSub.ExpansionSub.ContainsSub;

namespace ResourceTypeServices.R5.ValueSetSub.ExpansionSub
{
    public class Contains : BackboneElement<Contains>
    {

        #region Property
        [Element("system", typeof(FhirUri), true, false, false, false)]
public FhirUri System {get; set;}
[Element("abstract", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Abstract {get; set;}
[Element("inactive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Inactive {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}

        #endregion
        #region Constructor
        public  Contains() { }
        public  Contains(string value) : base(value) { }
        public  Contains(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Contains";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
