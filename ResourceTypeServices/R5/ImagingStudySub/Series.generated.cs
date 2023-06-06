
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ImagingStudySub.SeriesSub;

namespace ResourceTypeServices.R5.ImagingStudySub
{
    public class Series : BackboneElement<Series>
    {

        #region Property
        [Element("uid", typeof(FhirId), true, false, false, false)]
public FhirId Uid {get; set;}
[Element("number", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Number {get; set;}
[Element("modality", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Modality {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("numberOfInstances", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt NumberOfInstances {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("bodySite", typeof(CodeableReference), false, false, false, false)]
public CodeableReference BodySite {get; set;}
[Element("laterality", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Laterality {get; set;}
[Element("specimen", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Specimen {get; set;}
[Element("started", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Started {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("instance", typeof(Instance), false, true, false, true)]
public IEnumerable<Instance> Instance {get; set;}

        #endregion
        #region Constructor
        public  Series() { }
        public  Series(string value) : base(value) { }
        public  Series(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Series";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
