using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementFocalDevice
    {
       
        public GroupElementFocalDevice(Procedure.FocalDeviceComponent source, IFhirServer fs)
        {
            if(source != null && source.Manipulated != null && source.Manipulated.IsContainedReference)
            {
                string _ref = source.Manipulated.Reference;
                Manipulated = new SubElement("manipulated", _ref, fs);
            }
            
        }

        public SubElement Manipulated { get; private set; }
    }
}
