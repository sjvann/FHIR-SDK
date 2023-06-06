using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementDiagnosis
    {
       
        public GroupElementDiagnosis(Encounter.DiagnosisComponent source, IFhirServer fs)
        {
            if(source != null && source.Condition != null && source.Condition.IsContainedReference)
            {
                string _ref = source.Condition.Reference;
                Condition = new SubElement("condition", _ref, fs);
            }
            
        }

        public SubElement Condition { get; private set; }
    }
}
