

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ListSub
{
    public class List : DomainResource<List>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("source", typeof(Reference), false, false, false, false)]
public Reference Source {get; set;}
[Element("orderedBy", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OrderedBy {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("entry", typeof(Entry), false, true, false, true)]
public IEnumerable<Entry> Entry {get; set;}
[Element("emptyReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept EmptyReason {get; set;}

        #endregion
        #region Constructor
        public  List() { }

        public  List(string value) : base(value) { }
        public  List(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "List";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
