
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageHeaderSub
{
    public class Source : BackboneElement<Source>
    {

        #region Property
        [Element("endpoint", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Endpoint {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("software", typeof(FhirString), true, false, false, false)]
public FhirString Software {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("contact", typeof(ContactPoint), false, false, false, false)]
public ContactPoint Contact {get; set;}

        #endregion
        #region Constructor
        public  Source() { }
        public  Source(string value) : base(value) { }
        public  Source(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Source";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
