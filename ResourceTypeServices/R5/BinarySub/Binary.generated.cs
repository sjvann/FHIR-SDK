

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BinarySub
{
    public class Binary : DomainResource<Binary>
    {
        #region Property
        [Element("contentType", typeof(FhirCode), true, false, false, false)]
public FhirCode ContentType {get; set;}
[Element("securityContext", typeof(Reference), false, false, false, false)]
public Reference SecurityContext {get; set;}
[Element("data", typeof(FhirBase64Binary), true, false, false, false)]
public FhirBase64Binary Data {get; set;}

        #endregion
        #region Constructor
        public  Binary() { }

        public  Binary(string value) : base(value) { }
        public  Binary(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Binary";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
