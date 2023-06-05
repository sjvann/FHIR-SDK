using Core.Attribute;
using DataTypeService.BaseTypes;

using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace DataTypeService.Complex
{
    public class Attachment : ComplexType<Attachment>
    {
        #region Property
        [Element("contentType", typeof(FhirCode), true, false, false, false)]
        public FhirCode? ContentType { get; set; }
        [Element("language", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Language { get; set; }
        [Element("data",  typeof(FhirBase64Binary), true, false, false, false)]
        public FhirBase64Binary? Data { get; set; }
        [Element("url", typeof(FhirUrl), true, false, false, false)]
        public FhirUrl? Url { get; set; }
        [Element("size", typeof(FhirInteger64), true, false, false, false)]
        public FhirInteger64? Size { get; set; }
        [Element("hash", typeof(FhirBase64Binary), true, false, false, false)]
        public FhirBase64Binary? Hash { get; set; }
        [Element("title", typeof(FhirString), true, false, false, false)]
        public FhirString? Title { get; set; }
        [Element("creation", typeof(FhirDateTime), true, false, false, false)]
        public FhirDateTime? Creation { get; set; }
        [Element("height", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Height { get; set; }
        [Element("width", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Width { get; set; }
        [Element("frames", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Frames { get; set; }
        [Element("duration", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Duration { get; set; }
        [Element("pages", typeof(FhirPositiveInt), true, false, false, false)]
        public FhirPositiveInt? Pages { get; set; }

        #endregion
        #region Constructor
        public Attachment() { }
        public Attachment(string? value) : base(value) { }
        public Attachment(JsonNode? source) : base(source) { }


        #endregion
        #region From Parent
        protected override string _TypeName => "Attachment";


        #endregion

        #region public Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
