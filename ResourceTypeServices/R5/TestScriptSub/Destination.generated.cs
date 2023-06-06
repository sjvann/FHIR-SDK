
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Destination : BackboneElement<Destination>
    {

        #region Property
        [Element("index", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Index {get; set;}
[Element("profile", typeof(Coding), false, false, false, false)]
public Coding Profile {get; set;}
[Element("url", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Url {get; set;}

        #endregion
        #region Constructor
        public  Destination() { }
        public  Destination(string value) : base(value) { }
        public  Destination(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Destination";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
