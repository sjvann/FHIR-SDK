
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ClaimResponseSub.ItemSub;

namespace ResourceTypeServices.R5.ClaimResponseSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("itemSequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt ItemSequence {get; set;}
[Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("noteNumber", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> NoteNumber {get; set;}
[Element("reviewOutcome", typeof(ReviewOutcome), false, false, false, true)]
public ReviewOutcome ReviewOutcome {get; set;}
[Element("adjudication", typeof(Adjudication), false, true, false, true)]
public IEnumerable<Adjudication> Adjudication {get; set;}
[Element("detail", typeof(Detail), false, true, false, true)]
public IEnumerable<Detail> Detail {get; set;}

        #endregion
        #region Constructor
        public  Item() { }
        public  Item(string value) : base(value) { }
        public  Item(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Item";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
