using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRImmunizationRecommendation:MRBased<ImmunizationRecommendation>
    {
        #region Constructor
        public MRImmunizationRecommendation(List<ImmunizationRecommendation> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "ImmunizationRecommendation";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            ImmunizationRecommendation current = GetCurrentResource();
            if (current != null)
            {
               if(current.Patient != null && current.Patient.IsContainedReference)
                {
                    Patient = new SubElement("patient", current.Patient.Reference, _fs);
                }
                if (current.Authority != null && current.Authority.IsContainedReference)
                {
                    Authority = new SubElement("authority", current.Authority.Reference, _fs);
                }
                if (current.Recommendation != null && current.Recommendation.Any())
                {
                    List<GroupElementRecommendation> tmp = new();
                    foreach(var item in current.Recommendation)
                    {
                        tmp.Add(new GroupElementRecommendation(item, _fs));
                    }
                    Recommendation = tmp;
                }
            }
        }
        #endregion
        #region SubElement
      
        public SubElement Patient { get; private set; } 
        public SubElement Authority { get; private set; } 
        public List<GroupElementRecommendation> Recommendation { get; private set; }
        #endregion
    }
}
