using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
using System.Linq;
namespace ResourceMgr.Managed
{
    public class MRCondition:MRBased<Condition>
    {
        #region Constructor
        public MRCondition(List<Condition> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Condition";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Condition current = GetCurrentResource();
            if (current != null)
            {
               if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
               if(current.Encounter != null &&  current.Encounter.IsContainedReference)
                {
                    string _ref = current.Encounter.Reference;
                    Encounter = new SubElement("encounter", _ref, _fs);
                }
                if (current.Onset != null)
                {
                   
                    OnSet = new SubElement("onset" , current.Onset.TypeName, current.Onset);
                }
                if(current.Abatement != null)
                {
                    Abatement = new SubElement("abatement", current.Abatement.TypeName, current.Abatement);
                }
                if(current.Recorder != null && current.Recorder.IsContainedReference)
                {
                    string _ref = current.Recorder.Reference;
                    Recorder = new SubElement("recorder", _ref, _fs);
                }
                if(current.Asserter != null && current.Asserter.IsContainedReference)
                {
                    string _ref = current.Asserter.Reference;
                    Asserter = new SubElement("asserter", _ref, _fs);
                }
                if(current.Stage != null && current.Stage.Any())
                {
                    foreach(var item in current.Stage)
                    {
                        Stage.Add(new GroupElementStage(item, _fs));
                    }
                }
                if(current.Evidence != null && current.Evidence.Any())
                {
                    foreach(var item in current.Evidence)
                    {
                        Evidence.Add(new GroupElementEvidence(item, _fs));
                    }
                }
            }

        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement OnSet { get; private set; }
        public SubElement Abatement { get; private set; }
        public SubElement Recorder { get; private set; }
        public SubElement Asserter { get; private set; }
        public List<GroupElementStage> Stage { get; set; }
        public List<GroupElementEvidence> Evidence { get; private set; }



        #endregion
    }
}
