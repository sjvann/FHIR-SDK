using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRAdverseEvent:MRBased<AdverseEvent>
    {
        #region Constructor
        public MRAdverseEvent(List<AdverseEvent> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Template";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            AdverseEvent current = GetCurrentResource();
            if (current != null)
            {
                if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
                if(current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    string _ref = current.Encounter.Reference;
                    Encounter = new SubElement("encounter", _ref, _fs);
                }
                if(current.ResultingCondition != null && current.ResultingCondition.Count > 0)
                {
                    foreach(var item in current.ResultingCondition.Where(x=>x.IsContainedReference))
                        {
                        string _ref = item.Reference;
                        ResultingCondition.Add(new SubElement("resultingCondition", _ref, _fs));
                    }
                }
                if(current.Location != null && current.Location.IsContainedReference)
                {
                    string _ref = current.Location.Reference;
                    Location = new SubElement("location", _ref, _fs);
                }
                if(current.Recorder != null && current.Recorder.IsContainedReference)
                {
                    string _ref = current.Recorder.Reference;
                    Recorder = new SubElement("recorder", _ref, _fs);
                }
                if(current.Contributor != null && current.Contributor.Count > 0)
                {
                    foreach(var item in current.Contributor.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Contributor.Add(new SubElement("contributor", _ref, _fs));
                    }
                }
                if(current.SuspectEntity != null && current.SuspectEntity.Count> 0)
                {
                    foreach(var item in current.SuspectEntity)
                    {
                        SuspectEntity.Add(new GroupElementSuspectEntity(item, _fs));
                    }
                }
                if(current.SubjectMedicalHistory != null && current.SubjectMedicalHistory.Count > 0)
                {
                    foreach(var item in current.SubjectMedicalHistory.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        SubjectMedicalHistory.Add(new SubElement("subjectMedicalHistory", _ref, _fs));
                    }
                }
                if (current.ReferenceDocument != null && current.ReferenceDocument.Count > 0)
                {
                    foreach (var item in current.ReferenceDocument.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        ReferenceDocument.Add(new SubElement("referenceDocument", _ref, _fs));
                    }
                }
                if (current.Study != null && current.Study.Count > 0)
                {
                    foreach (var item in current.Study.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Study.Add(new SubElement("study", _ref, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public List<SubElement> ResultingCondition { get; private set; }
        public SubElement Location { get; private set; }
        public SubElement Recorder { get; private set; }
        public List<SubElement> Contributor { get; private set; }
        public List<GroupElementSuspectEntity> SuspectEntity { get; private set; }
        public List<SubElement> SubjectMedicalHistory { get; private set; }
        public List<SubElement> ReferenceDocument { get; private set; }
        public List<SubElement> Study { get; private set; }
        #endregion
    }
}
