
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NamingSystemSub
{
    public class UniqueId : BackboneElement<UniqueId>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}
[Element("preferred", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Preferred {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("authoritative", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Authoritative {get; set;}

        #endregion
        #region Constructor
        public  UniqueId() { }
        public  UniqueId(string value) : base(value) { }
        public  UniqueId(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "UniqueId";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
