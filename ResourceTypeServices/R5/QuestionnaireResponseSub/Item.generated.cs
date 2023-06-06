
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.QuestionnaireResponseSub.ItemSub;

namespace ResourceTypeServices.R5.QuestionnaireResponseSub
{
    public class Item : BackboneElement<Item>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("definition", typeof(FhirUri), true, false, false, false)]
public FhirUri Definition {get; set;}
[Element("answer", typeof(Answer), false, true, false, true)]
public IEnumerable<Answer> Answer {get; set;}

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
