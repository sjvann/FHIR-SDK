

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.VisionPrescriptionSub
{
    public class VisionPrescription : DomainResource<VisionPrescription>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("dateWritten", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateWritten {get; set;}
[Element("prescriber", typeof(Reference), false, false, false, false)]
public Reference Prescriber {get; set;}
[Element("lensSpecification", typeof(LensSpecification), false, true, false, true)]
public IEnumerable<LensSpecification> LensSpecification {get; set;}

        #endregion
        #region Constructor
        public  VisionPrescription() { }

        public  VisionPrescription(string value) : base(value) { }
        public  VisionPrescription(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "VisionPrescription";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
