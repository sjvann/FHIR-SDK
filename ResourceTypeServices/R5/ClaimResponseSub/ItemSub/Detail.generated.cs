
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ClaimResponseSub.ItemSub.DetailSub;

namespace ResourceTypeServices.R5.ClaimResponseSub.ItemSub
{
    public class Detail : BackboneElement<Detail>
    {

        #region Property
        [Element("detailSequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt DetailSequence {get; set;}
[Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("noteNumber", typeof(FhirPositiveInt), true, true, false, false)]
public IEnumerable<FhirPositiveInt> NoteNumber {get; set;}
[Element("subDetail", typeof(SubDetail), false, true, false, true)]
public IEnumerable<SubDetail> SubDetail {get; set;}

        #endregion
        #region Constructor
        public  Detail() { }
        public  Detail(string value) : base(value) { }
        public  Detail(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Detail";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
