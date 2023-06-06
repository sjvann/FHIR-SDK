using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRLocation : MRBased<Location>
    {
        #region Constructor
        public MRLocation(List<Location> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Location";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Location current = GetCurrentResource();
            if (current != null)
            {
                if (current.ManagingOrganization != null && current.ManagingOrganization.IsContainedReference)
                {
                    string _ref = current.ManagingOrganization.Reference;
                    ManagingOrganization = new SubElement("managingOrganization", _ref, _fs);
                }
                if (current.PartOf != null && current.PartOf.IsContainedReference)
                {
                    string _ref = current.PartOf.Reference;
                    PartOf = new SubElement("partOf", _ref, _fs);
                }
                if (current.Endpoint != null && current.Endpoint.Count > 0)
                {
                    foreach (var item in current.Endpoint.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        EndPoint.Add(new SubElement("endpoint", _ref, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement ManagingOrganization { get; private set; }
        public SubElement PartOf { get; private set; }
        public List<SubElement> EndPoint { get; private set; }

        #endregion
    }
}
