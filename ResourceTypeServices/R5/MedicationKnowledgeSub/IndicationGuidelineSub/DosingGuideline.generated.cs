
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub.DosingGuidelineSub;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub
{
    public class DosingGuideline : BackboneElement<DosingGuideline>
    {

        #region Property
        [Element("treatmentIntent", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept TreatmentIntent {get; set;}
[Element("dosage", typeof(ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub.DosingGuidelineSub.Dosage), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub.DosingGuidelineSub.Dosage> Dosage {get; set;}
[Element("administrationTreatment", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AdministrationTreatment {get; set;}
[Element("patientCharacteristic", typeof(PatientCharacteristic), false, true, false, true)]
public IEnumerable<PatientCharacteristic> PatientCharacteristic {get; set;}

        #endregion
        #region Constructor
        public  DosingGuideline() { }
        public  DosingGuideline(string value) : base(value) { }
        public  DosingGuideline(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DosingGuideline";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
