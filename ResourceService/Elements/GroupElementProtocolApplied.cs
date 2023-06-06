using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementProtocolApplied
    {
       
        public GroupElementProtocolApplied(Immunization.ProtocolAppliedComponent source, IFhirServer fs)
        {
            if(source != null )
            {
                if(source.Authority != null && source.Authority.IsContainedReference)
                {
                    Authority = new SubElement("authority", source.Authority.Reference, fs);
                }
                if(source.DoseNumber != null)
                {
                    DoseNumber = new SubElement("doseNumber", source.DoseNumber.TypeName, source.DoseNumber);
                }
                if(source.SeriesDoses != null)
                {
                    SeriesDosed = new SubElement("seriesDosed", source.SeriesDoses.TypeName, source.SeriesDoses);
                }
            }
            
        }

        public SubElement Authority { get; private set; }
        public SubElement DoseNumber { get; private set; }
        public SubElement SeriesDosed { get; private set; }
    }
}
