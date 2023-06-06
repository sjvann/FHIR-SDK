
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MedicationKnowledgeSub.StorageGuidelineSub;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class StorageGuideline : BackboneElement<StorageGuideline>
    {

        #region Property
        [Element("reference", typeof(FhirUri), true, false, false, false)]
public FhirUri Reference {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("stabilityDuration", typeof(Duration), false, false, false, false)]
public Duration StabilityDuration {get; set;}
[Element("environmentalSetting", typeof(EnvironmentalSetting), false, true, false, true)]
public IEnumerable<EnvironmentalSetting> EnvironmentalSetting {get; set;}

        #endregion
        #region Constructor
        public  StorageGuideline() { }
        public  StorageGuideline(string value) : base(value) { }
        public  StorageGuideline(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StorageGuideline";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
