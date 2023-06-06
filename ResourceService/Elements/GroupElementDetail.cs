using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ResourceMgr.Elements
{
    public class GroupElementDetail
    {

        public GroupElementDetail(CarePlan.DetailComponent source, IFhirServer fs)
        {

            if (source != null )
            {
               if(source.InstantiatesCanonical != null && source.InstantiatesCanonical.Any())
                {
                     List<SubElement> temp = new();
                    foreach(var item in source.InstantiatesCanonical)
                    {
                        string _elementName = item.Split("/")[0];
                        temp.Add(new SubElement("instantiatesCanonical", _elementName, item));
                    }
                    InstantiatesCanonical = temp;
                }
               if(source.ReasonReference!= null && source.ReasonReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in source.ReasonReference.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("reasonReference", item.Reference, fs));
                    }
                    ReasonReference = temp;
                }
               if (source.Goal != null && source.Goal.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in source.Goal.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("goal", item.Reference, fs));
                    }
                }
               if(source.Scheduled != null )
                {
                    Scheduled = new SubElement("scheduled", source.Scheduled.TypeName, source.Scheduled);
                }
               if(source.Location != null && source.Location.IsContainedReference)
                {
                    Location = new SubElement("location", source.Location.Reference, fs);
                }
               if (source.Performer != null && source.Performer.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in source.Performer.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("performer", item.Reference, fs));
                    }
                    Performer = temp;
                }
               if(source.Product != null)
                {
                    Product = new SubElement("product", source.Product.TypeName, source.Product);
                }
            }

        }

        public List<SubElement> InstantiatesCanonical { get; private set; }
        public List<SubElement>ReasonReference {get; private set;}
        public List<SubElement> Goal { get; private set; }
        public SubElement Scheduled { get; private set; }
        public SubElement Location { get; private set; }
        public List<SubElement> Performer { get; private set; }
        public SubElement Product { get; private set; }

    }
}
