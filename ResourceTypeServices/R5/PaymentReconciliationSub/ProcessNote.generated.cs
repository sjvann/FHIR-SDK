
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PaymentReconciliationSub
{
    public class ProcessNote : BackboneElement<ProcessNote>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}

        #endregion
        #region Constructor
        public  ProcessNote() { }
        public  ProcessNote(string value) : base(value) { }
        public  ProcessNote(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ProcessNote";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
