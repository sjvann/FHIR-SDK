

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ObservationSub
{
    public class Observation : DomainResource<Observation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
        public IEnumerable<Identifier> Identifier { get; set; }
        [Element("instantiates", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased Instantiates { get; set; }
        [Element("basedOn", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> BasedOn { get; set; }
        [Element("triggeredBy", typeof(TriggeredBy), false, true, false, true)]
        public IEnumerable<TriggeredBy> TriggeredBy { get; set; }
        [Element("partOf", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> PartOf { get; set; }
        [Element("status", typeof(FhirCode), true, false, false, false)]
        public FhirCode Status { get; set; }
        [Element("category", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept> Category { get; set; }
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept Code { get; set; }
        [Element("subject", typeof(Reference), false, false, false, false)]
        public Reference Subject { get; set; }
        [Element("focus", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> Focus { get; set; }
        [Element("encounter", typeof(Reference), false, false, false, false)]
        public Reference Encounter { get; set; }
        [Element("effective", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased Effective { get; set; }
        [Element("issued", typeof(FhirInstant), true, false, false, false)]
        public FhirInstant Issued { get; set; }
        [Element("performer", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> Performer { get; set; }
        [Element("value", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased Value { get; set; }
        [Element("dataAbsentReason", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept DataAbsentReason { get; set; }
        [Element("interpretation", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept> Interpretation { get; set; }
        [Element("note", typeof(Annotation), false, true, false, false)]
        public IEnumerable<Annotation> Note { get; set; }
        [Element("bodySite", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept BodySite { get; set; }
        [Element("bodyStructure", typeof(Reference), false, false, false, false)]
        public Reference BodyStructure { get; set; }
        [Element("method", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept Method { get; set; }
        [Element("specimen", typeof(Reference), false, false, false, false)]
        public Reference Specimen { get; set; }
        [Element("device", typeof(Reference), false, false, false, false)]
        public Reference Device { get; set; }
        [Element("referenceRange", typeof(ReferenceRange), false, true, false, true)]
        public IEnumerable<ReferenceRange> ReferenceRange { get; set; }
        [Element("hasMember", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> HasMember { get; set; }
        [Element("derivedFrom", typeof(Reference), false, true, false, false)]
        public IEnumerable<Reference> DerivedFrom { get; set; }
        [Element("component", typeof(Component), false, true, false, true)]
        public IEnumerable<Component> Component { get; set; }

        #endregion
        #region Constructor
        public Observation() { }

        public Observation(string value) : base(value) { }
        public Observation(JsonNode source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "Observation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
