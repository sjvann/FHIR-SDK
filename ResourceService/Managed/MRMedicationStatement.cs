using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRMedicationStatement : MRBased<MedicationStatement>
    {
        #region Constructor
        public MRMedicationStatement(List<MedicationStatement> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "MedicationStatement";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            MedicationStatement current = GetCurrentResource();
            if (current != null)
            {
               if(current.Medication != null)
                {
                    Medication = new SubElement("medication", current.Medication.TypeName, current.Medication);
                }
               if(current.Effective != null)
                {
                    Effective = new SubElement("effective", current.Effective.TypeName, current.Effective);
                }
               if(current.Subject!= null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
               if(current.Context != null && current.Context.IsContainedReference)
                {
                    string _ref = current.Context.Reference;
                    Context = new SubElement("context", _ref, _fs);
                }
                if (current.InformationSource != null && current.InformationSource.IsContainedReference)
                {
                    string _ref = current.InformationSource.Reference;
                    InformationSource = new SubElement("informationSource", _ref, _fs);
                }
                if (current.BasedOn != null && current.BasedOn.Count >0)
                {
                    foreach(var item in current.BasedOn.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        BasedOn.Add(new SubElement("basedOn", _ref, _fs));
                    }
                }
                if (current.PartOf != null && current.PartOf.Count > 0)
                {
                    foreach (var item in current.PartOf.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        PartOf.Add(new SubElement("partOf", _ref, _fs));
                    }
                }
                if (current.DerivedFrom != null && current.DerivedFrom.Count > 0)
                {
                    foreach (var item in current.DerivedFrom.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        DerivedFrom.Add(new SubElement("derivedFrom", _ref, _fs));
                    }
                }
                if (current.ReasonReference != null && current.ReasonReference.Count > 0)
                {
                    foreach (var item in current.ReasonReference.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        ReasonReference.Add(new SubElement("reasonReference", _ref, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> PartOf { get; private set; }
        public SubElement Medication { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Context { get; private set; }
        public SubElement Effective { get; private set; }
        public SubElement InformationSource { get; private set; }
        public List<SubElement> DerivedFrom { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }


        #endregion
    }
}
