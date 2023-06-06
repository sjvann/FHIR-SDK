using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementQualification
    {
       
        public GroupElementQualification(Practitioner.QualificationComponent source, IFhirServer fs)
        {
            if(source != null && source.Issuer != null && source.Issuer.IsContainedReference)
            {
                string _ref = source.Issuer.Reference;
                Issuer = new SubElement("issuer", _ref, fs);
            }
            
        }

        public SubElement Issuer { get; private set; }
    }
}
