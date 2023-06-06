
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationSub
{
    public class ProtocolApplied : BackboneElement<ProtocolApplied>
    {

        #region Property
        [Element("series", typeof(FhirString), true, false, false, false)]
public FhirString Series {get; set;}
[Element("authority", typeof(Reference), false, false, false, false)]
public Reference Authority {get; set;}
[Element("targetDisease", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> TargetDisease {get; set;}
[Element("doseNumber", typeof(FhirString), true, false, false, false)]
public FhirString DoseNumber {get; set;}
[Element("seriesDoses", typeof(FhirString), true, false, false, false)]
public FhirString SeriesDoses {get; set;}

        #endregion
        #region Constructor
        public  ProtocolApplied() { }
        public  ProtocolApplied(string value) : base(value) { }
        public  ProtocolApplied(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ProtocolApplied";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
