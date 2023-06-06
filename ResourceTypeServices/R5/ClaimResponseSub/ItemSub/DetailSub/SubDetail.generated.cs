
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClaimResponseSub.ItemSub.DetailSub
{
    public class SubDetail : BackboneElement<SubDetail>
    {

        #region Property
        [Element("subDetailSequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt SubDetailSequence {get; set;}
[Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("noteNumber", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> NoteNumber {get; set;}

        #endregion
        #region Constructor
        public  SubDetail() { }
        public  SubDetail(string value) : base(value) { }
        public  SubDetail(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SubDetail";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
