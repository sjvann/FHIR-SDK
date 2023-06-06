using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementGuarantor
    {
       
        public GroupElementGuarantor(Account.GuarantorComponent source, IFhirServer fs)
        {
            if(source != null && source.Party != null && source.Party.IsContainedReference)
            {
              
                Party = new SubElement("party", source.Party.Reference, fs);
            }
            
        }

        public SubElement Party { get; private set; }
    }
}
