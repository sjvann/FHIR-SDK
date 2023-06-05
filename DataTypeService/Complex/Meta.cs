
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace DataTypeService.Complex
{
    public class Meta : ComplexType<Meta>
    {

        #region Property
        [Element("versionId", typeof(FhirId), true, false, false, false)]
        public FhirId? VersionId { get; init; }
        [Element("lastUpdated", typeof(FhirInstant), true, false, false, false)]
        public FhirInstant? LastUpdated { get; init; }
        [Element("source", typeof(FhirUri), true, false, false, false)]
        public FhirUri? Source { get; init; }
        [Element("profile", typeof(FhirCanonical), true, true, false, false)]
        public IEnumerable<FhirCanonical>? Profile { get; init; }
        [Element("security", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Security { get; init; }
        [Element("tag", typeof(Coding), false, true, false, false)]
        public IEnumerable<Coding>? Tag { get; init; }
        #endregion
        #region Constructor
        public Meta() { }

        public Meta(string? value) : base(value) { }
        public Meta(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Meta";


        #endregion

        #region Public Method

        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
