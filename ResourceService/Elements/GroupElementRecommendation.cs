using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementRecommendation
    {

        public GroupElementRecommendation(ImmunizationRecommendation.RecommendationComponent source, IFhirServer fs)
        {
            if (source != null)
            {
                if(source.DoseNumber != null)
                {
                    DoseNumber = new SubElement("doseNumber", source.DoseNumber.TypeName, source.DoseNumber);
                }
                if(source.SeriesDoses != null)
                {
                    SeriesDoses = new SubElement("seriesDoses", source.SeriesDoses.TypeName, source.SeriesDoses);
                }
                if(source.SupportingImmunization != null && source.SupportingImmunization.Any())
                {
                    List<SubElement> tmp = new();
                    foreach(var item in source.SupportingImmunization.Where(x=>x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("supportingImmunization", item.Reference, fs));
                    }
                    SupportingImmunization = tmp;
                }
                if (source.SupportingPatientInformation != null && source.SupportingPatientInformation.Any())
                {
                    List<SubElement> tmp = new();
                    foreach (var item in source.SupportingPatientInformation.Where(x => x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("supportingPatientInformation", item.Reference, fs));
                    }
                    SupportingPatientInformation = tmp;
                }

            }

        }

        public SubElement DoseNumber { get; private set; }
        public SubElement SeriesDoses { get; private set; }
        public List<SubElement> SupportingImmunization { get; private set; }
        public List<SubElement> SupportingPatientInformation { get; private set; }
    }
}
