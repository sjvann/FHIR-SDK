using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRGoal:MRBased<Goal>
    {
        #region Constructor
        public MRGoal(List<Goal> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Goal";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Goal current = GetCurrentResource();
            if (current != null)
            {
                if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if(current.Start != null)
                {
                    Start = new SubElement("start", current.Start.TypeName, current.Start);
                }
                if(current.Target!= null && current.Target.Any())
                {
                    List<GroupElementTarget> temp = new();
                    foreach(var item in current.Target)
                    {
                        temp.Add(new GroupElementTarget(item, _fs));
                    }
                    Target = temp;
                }
                if(current.ExpressedBy != null && current.ExpressedBy.IsContainedReference)
                {
                    ExpressedBy = new SubElement("expressedBy", current.ExpressedBy.Reference, _fs);
                }
                if(current.Addresses != null && current.Addresses.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.Addresses.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("addresses", item.Reference, _fs));
                    }
                    Addresses = temp;
                }
                if(current.OutcomeReference != null && current.OutcomeReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.OutcomeReference.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("outcomeReference", item.Reference, _fs));
                    }
                    OutcomeReference = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public SubElement Start { get; private set; }
        public SubElement ExpressedBy { get; private set; }
        public List<SubElement> Addresses { get; private set; }
        public List<SubElement> OutcomeReference { get; private set; }
        public List<GroupElementTarget> Target { get; private set; }
        #endregion
    }
}
