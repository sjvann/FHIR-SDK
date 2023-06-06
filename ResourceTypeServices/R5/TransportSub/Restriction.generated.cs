
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TransportSub
{
    public class Restriction : BackboneElement<Restriction>
    {

        #region Property
        [Element("repetitions", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Repetitions {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("recipient", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Recipient {get; set;}

        #endregion
        #region Constructor
        public  Restriction() { }
        public  Restriction(string value) : base(value) { }
        public  Restriction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Restriction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
