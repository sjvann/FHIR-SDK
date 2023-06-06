

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationRecommendationSub
{
    public class ImmunizationRecommendation : DomainResource<ImmunizationRecommendation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("authority", typeof(Reference), false, false, false, false)]
public Reference Authority {get; set;}
[Element("recommendation", typeof(Recommendation), false, true, false, true)]
public IEnumerable<Recommendation> Recommendation {get; set;}

        #endregion
        #region Constructor
        public  ImmunizationRecommendation() { }

        public  ImmunizationRecommendation(string value) : base(value) { }
        public  ImmunizationRecommendation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ImmunizationRecommendation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
