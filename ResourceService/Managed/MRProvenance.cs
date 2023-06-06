using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRProvenance:MRBased<Provenance>
    {
        #region Constructor
        public MRProvenance(List<Provenance> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Provenance";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Provenance current = GetCurrentResource();
            if (current != null)
            {
               if(current.Target != null && current.Target.Any())
                {
                    List<SubElement> tmp = new();
                    foreach(var item in current.Target)
                    {
                        tmp.Add(new SubElement("target", item.Reference, _fs));
                    }
                    Target = tmp;
                }
               if(current.Occurred != null)
                {
                    Occured = new SubElement("occurred", current.Occurred.TypeName, current.Occurred);
                }
               if(current.Location != null && current.Location.IsContainedReference)
                {
                    Location = new SubElement("location", current.Location.Reference, _fs);
                }
               if(current.Agent != null && current.Agent.Any())
                {
                    List<GroupElementAgent> tmp = new();
                    foreach(var item in current.Agent)
                    {
                        tmp.Add(new GroupElementAgent(item, _fs));
                    }
                    Agent = tmp;
                }
               if(current.Entity != null && current.Entity.Any())
                {
                    List<GroupElementEntity> tmp = new();
                    foreach(var item in current.Entity)
                    {
                        tmp.Add(new GroupElementEntity(item, _fs));
                    }
                    Entity = tmp;
                }

            }
        }
        #endregion
        #region SubElement
       
        public IEnumerable<SubElement> Target { get; private set; }
        public SubElement Occured { get; private set;}
        public SubElement Location { get; private set;}
        public IEnumerable<GroupElementAgent> Agent { get; private set;}
        public IEnumerable<GroupElementEntity> Entity { get; private set;}
        #endregion
    }
}
