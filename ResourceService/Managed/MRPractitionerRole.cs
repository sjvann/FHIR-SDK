using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRPractitionerRole : MRBased<PractitionerRole>
    {
        #region Constructor
        public MRPractitionerRole(List<PractitionerRole> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "PractitionerRole";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            PractitionerRole current = GetCurrentResource();
            if (current != null)
            {
                if (current.Practitioner != null && current.Practitioner.IsContainedReference)
                {
                    Practitioner = new SubElement("practitioner", current.Practitioner.Reference, _fs);
                }
                if (current.Organization != null && current.Organization.IsContainedReference)
                {
                    Organization = new SubElement("organization", current.Organization.Reference, _fs);
                }
                if (current.HealthcareService != null && current.HealthcareService.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.HealthcareService.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("healthcareService", item.Reference, _fs));
                    }
                    HealthcareService = temp;
                }
                if (current.Endpoint != null && current.Endpoint.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Endpoint.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("location", item.Reference, _fs));
                    }
                    Endpoint = temp;
                }

            }
        }
        #endregion
        #region SubElement
        public SubElement Practitioner { get; private set; }
        public SubElement Organization { get; private set; }
        public List<SubElement> Location { get; private set; }
        public List<SubElement> HealthcareService { get; private set; }
        public List<SubElement> Endpoint { get; private set; }
        #endregion
    }
}
