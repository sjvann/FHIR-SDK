using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRDevice:MRBased<Device>
    {
        #region Constructor
        public MRDevice(List<Device> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Template";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Device current = GetCurrentResource();
            if (current != null)
            {
               if(current.Definition != null && current.Definition.IsContainedReference)
                {
                    Definition = new SubElement("definition", current.Definition.Reference, _fs);
                }
                if (current.Patient != null && current.Patient.IsContainedReference)
                {
                    Patient = new SubElement("patient", current.Patient.Reference, _fs);
                }
                if (current.Owner != null && current.Owner.IsContainedReference)
                {
                    Owner = new SubElement("owner", current.Owner.Reference, _fs);
                }
                if (current.Location != null && current.Location.IsContainedReference)
                {
                    Location = new SubElement("location", current.Location.Reference, _fs);
                }
                if (current.Parent != null && current.Parent.IsContainedReference)
                {
                    Parent = new SubElement("parent", current.Parent.Reference, _fs);
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Definition { get; private set; }
        public SubElement Patient { get; private set; }
        public SubElement Owner { get; private set; }
        public SubElement Location { get; private set; }
        public SubElement Parent { get; private set; }
        #endregion
    }
}
