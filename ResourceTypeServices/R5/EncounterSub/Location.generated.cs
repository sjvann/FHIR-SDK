
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EncounterSub
{
    public class Location : BackboneElement<Location>
    {

        #region Property
        [Element("location", typeof(Reference), false, false, false, false)]
public Reference LocationProp {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("form", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Form {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  Location() { }
        public  Location(string value) : base(value) { }
        public  Location(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Location";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
