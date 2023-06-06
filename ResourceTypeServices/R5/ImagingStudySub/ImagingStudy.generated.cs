

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImagingStudySub
{
    public class ImagingStudy : DomainResource<ImagingStudy>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("modality", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Modality {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("started", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Started {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("referrer", typeof(Reference), false, false, false, false)]
public Reference Referrer {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("numberOfSeries", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfSeries {get; set;}
[Element("numberOfInstances", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfInstances {get; set;}
[Element("procedure", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Procedure {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("series", typeof(Series), false, true, false, true)]
public IEnumerable<Series> Series {get; set;}

        #endregion
        #region Constructor
        public  ImagingStudy() { }

        public  ImagingStudy(string value) : base(value) { }
        public  ImagingStudy(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ImagingStudy";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
