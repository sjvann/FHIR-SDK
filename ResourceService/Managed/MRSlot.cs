using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRSlot:MRBased<Slot>
    {
        #region Constructor
        public MRSlot(List<Slot> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Slot";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Slot current = GetCurrentResource();
            if (current != null && current.Schedule != null && current.Schedule.IsContainedReference)
            {
                Schedule = new SubElement("schedule", current.Schedule.Reference, _fs);
            }
        }
        #endregion
        #region SubElement
       
        public SubElement Schedule { get; private set; } 
        #endregion
    }
}
