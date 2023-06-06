
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ObservationDefinitionSub
{
    public class QualifiedValue : BackboneElement<QualifiedValue>
    {

        #region Property
        [Element("context", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Context {get; set;}
[Element("appliesTo", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> AppliesTo {get; set;}
[Element("gender", typeof(FhirCode), true, false, false, false)]
public FhirCode Gender {get; set;}
[Element("age", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range Age {get; set;}
[Element("gestationalAge", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range GestationalAge {get; set;}
[Element("condition", typeof(FhirString), true, false, false, false)]
public FhirString Condition {get; set;}
[Element("rangeCategory", typeof(FhirCode), true, false, false, false)]
public FhirCode RangeCategory {get; set;}
[Element("range", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range Range {get; set;}
[Element("validCodedValueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValidCodedValueSet {get; set;}
[Element("normalCodedValueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical NormalCodedValueSet {get; set;}
[Element("abnormalCodedValueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical AbnormalCodedValueSet {get; set;}
[Element("criticalCodedValueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical CriticalCodedValueSet {get; set;}

        #endregion
        #region Constructor
        public  QualifiedValue() { }
        public  QualifiedValue(string value) : base(value) { }
        public  QualifiedValue(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "QualifiedValue";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
