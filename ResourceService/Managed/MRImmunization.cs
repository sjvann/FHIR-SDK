using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRImmunization:MRBased<Immunization>
    {
        #region Constructor
        public MRImmunization(List<Immunization> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Immunization";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Immunization current = GetCurrentResource();
            if (current != null)
            {
                if(current.Patient != null && current.Patient.IsContainedReference)
                {
                    Patient = new SubElement("patient", current.Patient.Reference, _fs);
                }
                if(current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    Encounter = new SubElement("encounter", current.Encounter.Reference, _fs);
                }
                if(current.Occurrence != null)
                {
                    Occurrence = new SubElement("occurrence", current.Occurrence.TypeName, current.Occurrence);
                }
                if(current.Location != null && current.Location.IsContainedReference)
                {
                    Location = new SubElement("location", current.Location.Reference, _fs);
                }
                if(current.Manufacturer != null && current.Manufacturer.IsContainedReference)
                {
                    Manufacturer = new SubElement("manufacturer", current.Manufacturer.Reference, _fs);
                }
                if(current.Performer != null && current.Performer.Any())
                {
                    List<GroupElementPerformer> temp = new();
                    foreach(var item in current.Performer)
                    {
                        temp.Add(new GroupElementPerformer(item, _fs));
                    }
                    Performer = temp;
                }
                if(current.ReasonReference != null && current.ReasonReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.ReasonReference.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("reasonReference", item.Reference, _fs));
                    }
                    ReasonReference = temp;
                }
                if(current.Reaction != null && current.Reaction.Any())
                {
                    List<GroupElementReaction> temp = new();
                    foreach(var item in current.Reaction)
                    {
                        temp.Add(new GroupElementReaction(item, _fs));
                    }
                    Reaction = temp;
                }
                if(current.ProtocolApplied != null && current.ProtocolApplied.Any())
                {
                    List<GroupElementProtocolApplied> temp = new();
                    foreach (var item in current.ProtocolApplied)
                    {
                        temp.Add(new GroupElementProtocolApplied(item, _fs));
                    }
                    ProtocolApplied = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Patient { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Occurrence { get; private set; }
        public SubElement Location { get; private set; }
        public SubElement Manufacturer { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<GroupElementPerformer> Performer { get; private set; }
        public List<GroupElementReaction> Reaction { get; private set; }
        public List<GroupElementProtocolApplied> ProtocolApplied { get; private set; }

        #endregion
    }
}
