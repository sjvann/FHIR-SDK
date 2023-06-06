using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MROrganization:MRBased<Organization>
    {
        #region Constructor
        public MROrganization(List<Organization> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Organization";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Organization current = GetCurrentResource();
            if (current != null)
            {
               if(current.PartOf != null && current.PartOf.IsContainedReference)
                {
                    PartOf = new SubElement("partOf", current.PartOf.Reference, _fs);
                }
               if(current.Endpoint != null && current.Endpoint.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.Endpoint.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("endpoint", item.Reference, _fs));
                    }
                    Endpoint = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement PartOf { get; private set; }
        public List<SubElement> Endpoint { get; private set; }
        #endregion
    }
}
