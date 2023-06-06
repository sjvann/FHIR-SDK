
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConsentSub.ProvisionSub
{
    public class Data : BackboneElement<Data>
    {

        #region Property
        [Element("meaning", typeof(FhirCode), true, false, false, false)]
public FhirCode Meaning {get; set;}
[Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}

        #endregion
        #region Constructor
        public  Data() { }
        public  Data(string value) : base(value) { }
        public  Data(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Data";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
