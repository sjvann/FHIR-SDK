using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRDiagnosticReport:MRBased<DiagnosticReport>
    {
        #region Constructor
        public MRDiagnosticReport(List<DiagnosticReport> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "DiagnosticReport";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            DiagnosticReport current = GetCurrentResource();
            if (current != null)
            {
                if (current.BasedOn != null && current.BasedOn.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.BasedOn.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("basedOn", item.Reference, _fs));
                    }
                    BasedOn = temp;
                }
                if(current.Subject != null  && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if(current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    Encounter = new SubElement("encounter", current.Encounter.Reference, _fs);
                }
                if(current.Effective != null)
                {
                    Effective = new SubElement("effective", current.Effective.TypeName, current.Effective);
                }
                if(current.Performer != null && current.Performer.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.Performer.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("performer", item.Reference, _fs));
                    }
                    Performer = temp;
                }
                if(current.ResultsInterpreter != null && current.ResultsInterpreter.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.ResultsInterpreter.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("resultsInterpreter", item.Reference, _fs));
                    }
                    ResultsInterpreter = temp;
                }
                if (current.Specimen != null && current.Specimen.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Specimen.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("specimen", item.Reference, _fs));
                    }
                    Specimen = temp;
                }
                if (current.Result != null && current.Result.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Result.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("result", item.Reference, _fs));
                    }
                    Result = temp;
                }
                if (current.ImagingStudy != null && current.ImagingStudy.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.ImagingStudy.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("imagingStudy", item.Reference, _fs));
                    }
                    ImagingStudy = temp;
                }
                if(current.Media != null && current.Media.Any())
                {
                    List<GroupElementMedia> temp = new();
                    foreach(var item in current.Media)
                    {
                        temp.Add(new GroupElementMedia(item, _fs));
                    }
                    Media = temp;

                }
            }
        }
        #endregion
        #region SubElement
        public List<SubElement> BasedOn { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Effective { get; private set; }
        public List<SubElement> Performer { get; private set; }
        public List<SubElement> ResultsInterpreter { get; private set; }
        public List<SubElement> Specimen { get; private set; }
        public List<SubElement> Result { get; private set; }
        public List<SubElement> ImagingStudy { get; private set; }
        public List<GroupElementMedia> Media { get; private set; }

        #endregion
    }
}
