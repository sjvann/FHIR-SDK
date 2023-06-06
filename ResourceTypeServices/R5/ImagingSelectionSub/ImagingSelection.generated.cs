

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImagingSelectionSub
{
    public class ImagingSelection : DomainResource<ImagingSelection>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("issued", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Issued {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("studyUid", typeof(FhirId), true, false, false, false)]
public FhirId StudyUid {get; set;}
[Element("derivedFrom", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> DerivedFrom {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("seriesUid", typeof(FhirId), true, false, false, false)]
public FhirId SeriesUid {get; set;}
[Element("seriesNumber", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt SeriesNumber {get; set;}
[Element("frameOfReferenceUid", typeof(FhirId), true, false, false, false)]
public FhirId FrameOfReferenceUid {get; set;}
[Element("bodySite", typeof(CodeableReference), false, false, false, false)]
public CodeableReference BodySite {get; set;}
[Element("focus", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Focus {get; set;}
[Element("instance", typeof(Instance), false, true, false, true)]
public IEnumerable<Instance> Instance {get; set;}

        #endregion
        #region Constructor
        public  ImagingSelection() { }

        public  ImagingSelection(string value) : base(value) { }
        public  ImagingSelection(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ImagingSelection";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
