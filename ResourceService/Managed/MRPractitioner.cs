using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRPractitioner:MRBased<Practitioner>
    {
        #region Constructor
        public MRPractitioner(List<Practitioner> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Practitioner";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Practitioner current = GetCurrentResource();
            if (current != null && current.Qualification != null && current.Qualification.Count > 0)
            {
                foreach(var item in current.Qualification)
                {
                    Qualification.Add(new GroupElementQualification(item, _fs));
                }
               
            }
        }
        #endregion
        #region SubElement
        public List<GroupElementQualification> Qualification { get; private set; }
        #endregion
    }
}
