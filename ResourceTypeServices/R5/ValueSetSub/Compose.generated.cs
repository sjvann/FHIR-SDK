
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ValueSetSub.ComposeSub;

namespace ResourceTypeServices.R5.ValueSetSub
{
    public class Compose : BackboneElement<Compose>
    {

        #region Property
        [Element("lockedDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LockedDate {get; set;}
[Element("inactive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Inactive {get; set;}
[Element("include", typeof(Include), false, true, false, true)]
public IEnumerable<Include> Include {get; set;}
[Element("property", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Property {get; set;}

        #endregion
        #region Constructor
        public  Compose() { }
        public  Compose(string value) : base(value) { }
        public  Compose(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Compose";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
