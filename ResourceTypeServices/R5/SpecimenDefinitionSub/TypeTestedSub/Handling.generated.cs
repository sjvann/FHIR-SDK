
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SpecimenDefinitionSub.TypeTestedSub
{
    public class Handling : BackboneElement<Handling>
    {

        #region Property
        [Element("temperatureQualifier", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept TemperatureQualifier {get; set;}
[Element("temperatureRange", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range TemperatureRange {get; set;}
[Element("maxDuration", typeof(Duration), false, false, false, false)]
public Duration MaxDuration {get; set;}
[Element("instruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Instruction {get; set;}

        #endregion
        #region Constructor
        public  Handling() { }
        public  Handling(string value) : base(value) { }
        public  Handling(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Handling";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
