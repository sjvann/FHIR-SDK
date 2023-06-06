
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.VisionPrescriptionSub.LensSpecificationSub;

namespace ResourceTypeServices.R5.VisionPrescriptionSub
{
    public class LensSpecification : BackboneElement<LensSpecification>
    {

        #region Property
        [Element("product", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Product {get; set;}
[Element("eye", typeof(FhirCode), true, false, false, false)]
public FhirCode Eye {get; set;}
[Element("sphere", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Sphere {get; set;}
[Element("cylinder", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Cylinder {get; set;}
[Element("axis", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Axis {get; set;}
[Element("prism", typeof(Prism), false, true, false, true)]
public IEnumerable<Prism> Prism {get; set;}
[Element("add", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Add {get; set;}
[Element("power", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Power {get; set;}
[Element("backCurve", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal BackCurve {get; set;}
[Element("diameter", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Diameter {get; set;}
[Element("duration", typeof(Quantity), false, false, false, false)]
public Quantity Duration {get; set;}
[Element("color", typeof(FhirString), true, false, false, false)]
public FhirString Color {get; set;}
[Element("brand", typeof(FhirString), true, false, false, false)]
public FhirString Brand {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  LensSpecification() { }
        public  LensSpecification(string value) : base(value) { }
        public  LensSpecification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "LensSpecification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
