
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceReportSub
{
    public class Section : BackboneElement<Section>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("focus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Focus {get; set;}
[Element("focusReference", typeof(Reference), false, false, false, false)]
public Reference FocusReference {get; set;}
[Element("author", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Author {get; set;}
[Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("orderedBy", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OrderedBy {get; set;}
[Element("entryClassifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> EntryClassifier {get; set;}
[Element("entryReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EntryReference {get; set;}
[Element("entryQuantity", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> EntryQuantity {get; set;}
[Element("emptyReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept EmptyReason {get; set;}

        #endregion
        #region Constructor
        public  Section() { }
        public  Section(string value) : base(value) { }
        public  Section(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Section";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
