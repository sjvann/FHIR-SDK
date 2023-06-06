using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRProcedure : MRBased<Procedure>
    {
        #region Constructor
        public MRProcedure(List<Procedure> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Procedure";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Procedure current = GetCurrentResource();
            if (current != null)
            {
                if (current.BasedOn != null && current.BasedOn.Count > 0)
                {
                    foreach (var item in current.BasedOn)
                    {
                        string _ref = item.Reference;
                        BasedOn.Add(new SubElement("basedOn", _ref, _fs));
                    }
                }
                if (current.PartOf != null && current.PartOf.Count > 0)
                {
                    foreach (var item in current.PartOf)
                    {
                        string _ref = item.Reference;
                        PartOf.Add(new SubElement("partOf", _ref, _fs));
                    }
                }
                if (current.ReasonReference != null && current.ReasonReference.Count > 0)
                {
                    foreach (var item in current.ReasonReference)
                    {
                        string _ref = item.Reference;
                        ReasonReference.Add(new SubElement("reasonReference", _ref, _fs));
                    }
                }
                if (current.Report != null && current.Report.Count > 0)
                {
                    foreach (var item in current.Report)
                    {
                        string _ref = item.Reference;
                        Report.Add(new SubElement("report", _ref, _fs));
                    }
                }
                if (current.ComplicationDetail != null && current.ComplicationDetail.Count > 0)
                {
                    foreach (var item in current.ComplicationDetail)
                    {
                        string _ref = item.Reference;
                        ComplicationDetail.Add(new SubElement("complicationDetail", _ref, _fs));
                    }
                }
                if (current.UsedReference != null && current.UsedReference.Count > 0)
                {
                    foreach (var item in current.UsedReference)
                    {
                        string _ref = item.Reference;
                        UsedReference.Add(new SubElement("usedReference", _ref, _fs));
                    }
                }
                if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
                if (current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    string _ref = current.Encounter.Reference;
                    Encounter = new SubElement("encounter", _ref, _fs);
                }
                if(current.Performed != null)
                {
                    Performed = new SubElement("performed", current.Performed.TypeName, current.Performed);
                }
                if(current.Performer != null && current.Performer.Count > 0)
                {
                    foreach(var item in current.Performer)
                    {
                        Performer.Add(new GroupElementPerformer(item, _fs));
                    }
                }
                if(current.FocalDevice != null && current.FocalDevice.Count >0)
                {
                    foreach(var item in current.FocalDevice)
                    {
                        FocalDevice.Add(new GroupElementFocalDevice(item, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement

        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> PartOf { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Performed { get; private set; }
        public SubElement Recorder { get; private set; }
        public SubElement Asserter { get; private set; }
        public List<GroupElementPerformer> Performer { get; private set; }
        public SubElement Location { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<SubElement> Report { get; private set; }
        public List<SubElement> ComplicationDetail { get; private set; }
        public List<GroupElementFocalDevice> FocalDevice { get; private set; }
        public List<SubElement> UsedReference { get; private set; }
        #endregion
    }
}
