

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SlotSub
{
    public class Slot : DomainResource<Slot>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("serviceCategory", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ServiceCategory {get; set;}
[Element("serviceType", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> ServiceType {get; set;}
[Element("specialty", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Specialty {get; set;}
[Element("appointmentType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> AppointmentType {get; set;}
[Element("schedule", typeof(Reference), false, false, false, false)]
public Reference Schedule {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("start", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Start {get; set;}
[Element("end", typeof(FhirInstant), true, false, false, false)]
public FhirInstant End {get; set;}
[Element("overbooked", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Overbooked {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}

        #endregion
        #region Constructor
        public  Slot() { }

        public  Slot(string value) : base(value) { }
        public  Slot(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Slot";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
