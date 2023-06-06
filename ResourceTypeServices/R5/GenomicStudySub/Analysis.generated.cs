
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.GenomicStudySub.AnalysisSub;

namespace ResourceTypeServices.R5.GenomicStudySub
{
    public class Analysis : BackboneElement<Analysis>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("methodType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> MethodType {get; set;}
[Element("changeType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ChangeType {get; set;}
[Element("genomeBuild", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept GenomeBuild {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, false, false, false)]
public FhirUri InstantiatesUri {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("focus", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Focus {get; set;}
[Element("specimen", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Specimen {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("protocolPerformed", typeof(Reference), false, false, false, false)]
public Reference ProtocolPerformed {get; set;}
[Element("regionsStudied", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RegionsStudied {get; set;}
[Element("regionsCalled", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RegionsCalled {get; set;}
[Element("input", typeof(Input), false, true, false, true)]
public IEnumerable<Input> Input {get; set;}
[Element("output", typeof(Output), false, true, false, true)]
public IEnumerable<Output> Output {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("device", typeof(Device), false, true, false, true)]
public IEnumerable<Device> Device {get; set;}

        #endregion
        #region Constructor
        public  Analysis() { }
        public  Analysis(string value) : base(value) { }
        public  Analysis(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Analysis";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
