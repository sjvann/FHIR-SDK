
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationSub
{
    public class Batch : BackboneElement<Batch>
    {

        #region Property
        [Element("lotNumber", typeof(FhirString), true, false, false, false)]
public FhirString LotNumber {get; set;}
[Element("expirationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ExpirationDate {get; set;}

        #endregion
        #region Constructor
        public  Batch() { }
        public  Batch(string value) : base(value) { }
        public  Batch(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Batch";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
