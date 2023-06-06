using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRAllergyIntolerance:MRBased<AllergyIntolerance>
    {
        #region Constructor
        public MRAllergyIntolerance(List<AllergyIntolerance> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "AllergyIntolerance";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            AllergyIntolerance current = GetCurrentResource();
            if (current != null)
            {
                if(current.Patient != null && current.Patient.IsContainedReference)
                {
                    string _ref = current.Patient.Reference;
                    this.Patient = new SubElement("patient", _ref, _fs);
                }
                if(current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    string _ref = current.Encounter.Reference;
                    this.Encounter = new SubElement("encounter", _ref, _fs);
                }
                if(current.Onset != null)
                {
                    Onset = new SubElement("onset", current.Onset.TypeName, current.Onset);
                }
                if(current.Recorder!= null && current.Recorder.IsContainedReference)
                {
                    string _ref = current.Recorder.Reference;
                    Recorder = new SubElement("recorder", _ref, _fs);
                }
                if(current.Asserter != null && current.Asserter.IsContainedReference)
                {
                    string _ref = current.Asserter.Reference;
                    Asserter = new SubElement("asserter", _ref, _fs);
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Patient { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Onset { get; private set; }
        public SubElement Recorder { get; private set; }
        public SubElement Asserter { get; private set; }

        #endregion
    }
}
