
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub.StatisticSub
{
    public class SampleSize : BackboneElement<SampleSize>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("numberOfStudies", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfStudies {get; set;}
[Element("numberOfParticipants", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfParticipants {get; set;}
[Element("knownDataCount", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt KnownDataCount {get; set;}

        #endregion
        #region Constructor
        public  SampleSize() { }
        public  SampleSize(string value) : base(value) { }
        public  SampleSize(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SampleSize";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
