using Core.Extension;
using DataTypeService.Based;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;


namespace DataTypeService.Special
{
    public class Narrative : ComplexType
    {

        #region Property
        public Code? Status { get; init; }
        public XHtml? Div { get; init; }
        #endregion
        #region Constructor
        public Narrative() { }
        public Narrative(Narrative source)
        {
            Status = source.Status;
            Div = source.Div;
           
        }
        public Narrative(string? value) : this(value.Parse()) { }
        public Narrative(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                if (source["status"] != null)
                {
                    Status = new Primitive.Code(source["status"]);
                }
                if (source["div"] != null)
                {
                    Div = new Primitive.XHtml(source["div"]);
                }
                
            }
        }

        #endregion
        #region From Parent
        protected override string _TypeName => "Narrative";

        #endregion

        #region public Method
        public override void SetProperties()
        {
            List<KeyValuePair<string, JsonNode?>> result = new();
            if (Status is Code status)
            {
                result.Add(ForPrimitiveType("status", status));
            }
            if (Div is XHtml div)
            {
                result.Add(ForPrimitiveType("div", div));
            }
            _Properties = result;
        }

        #endregion
    }
}
