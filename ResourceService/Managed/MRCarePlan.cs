using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRCarePlan : MRBased<CarePlan>
    {
        #region Constructor
        public MRCarePlan(List<CarePlan> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "CarePlan";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            CarePlan current = GetCurrentResource();
            if (current != null)
            {
                if (current.InstantiatesCanonical != null && current.InstantiatesCanonical.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.InstantiatesCanonical)
                    {
                        temp.Add(new SubElement("instantiatesCanonical", item.Split("/")[0], item));
                    }
                }
                if (current.BasedOn != null && current.BasedOn.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.BasedOn.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("basedOn", item.Reference, _fs));
                    }
                    BasedOn = temp;
                }
                if (current.Replaces != null && current.Replaces.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Replaces.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("replaces", item.Reference, _fs));
                    }
                    Replaces = temp;
                }
                if (current.PartOf != null && current.PartOf.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.PartOf.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("partOf", item.Reference, _fs));
                    }
                    PartOf = temp;
                }
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if (current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    Encounter = new SubElement("encounter", current.Encounter.Reference, _fs);
                }
                if (current.Author != null && current.Author.IsContainedReference)
                {
                    Author = new SubElement("author", current.Author.Reference, _fs);
                }
                if (current.Contributor != null && current.Contributor.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Contributor.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("contributor", item.Reference, _fs));
                    }
                    Contributor = temp;
                }
                if (current.CareTeam != null && current.CareTeam.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.CareTeam.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("careTeam", item.Reference, _fs));
                    }
                    CareTeam = temp;
                }
                if (current.Addresses != null && current.Addresses.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Addresses.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("addresses", item.Reference, _fs));
                    }
                    Addresses = temp;
                }
                if (current.SupportingInfo != null && current.SupportingInfo.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.SupportingInfo.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("supportingInfo", item.Reference, _fs));
                    }
                    SupportingInfo = temp;
                }
                if (current.Goal != null && current.Goal.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Goal.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("goal", item.Reference, _fs));
                    }
                    Goal = temp;
                }
                if(current.Activity != null && current.Activity.Any())
                {
                    List<GroupElementActivity> temp = new();
                    foreach(var item in current.Activity)
                    {
                        temp.Add(new GroupElementActivity(item, _fs));
                    }
                    Activity = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement InstantiatesCanonical { get; private set; }
        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> PartOf { get; private set; }
        public List<SubElement> Replaces { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Author { get; private set; }
        public List<SubElement> Contributor { get; private set; }
        public List<SubElement> CareTeam { get; private set; }
        public List<SubElement> Addresses { get; private set; }
        public List<SubElement> SupportingInfo { get; private set; }
        public List<SubElement> Goal { get; private set; }
        public List<GroupElementActivity> Activity { get; private set; }

        #endregion
    }
}
