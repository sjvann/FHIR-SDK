using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementEntity
    {
       
        public GroupElementEntity(Provenance.EntityComponent source, IFhirServer fs)
        {
            if(source != null)
            {
               if(source.What != null && source.What.IsContainedReference)
                {
                    What = new SubElement("what", source.What.Reference, fs);
                }
               if(source.Agent != null && source.Agent.Any())
                {
                    List<GroupElementAgent> tmp = new();
                    foreach(var item in source.Agent)
                    {
                        tmp.Add(new GroupElementAgent(item, fs));
                    }
                    Agent = tmp;
                }
            }
            
        }

        public SubElement What { get; private set; }
        public IEnumerable<GroupElementAgent> Agent { get; set; }
    }
}
