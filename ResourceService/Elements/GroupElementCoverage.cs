using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementCoverage
    {
       
        public GroupElementCoverage(Account.CoverageComponent source, IFhirServer fs)
        {
            if(source != null && source.Coverage != null && source.Coverage.IsContainedReference)
            {
               
                Coverage = new SubElement("coverage", source.Coverage.Reference, fs);
            }
            
        }

        public SubElement Coverage { get; private set; }
    }
}
