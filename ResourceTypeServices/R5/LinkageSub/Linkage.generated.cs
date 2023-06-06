

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.LinkageSub
{
    public class Linkage : DomainResource<Linkage>
    {
        #region Property
        [Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}

        #endregion
        #region Constructor
        public  Linkage() { }

        public  Linkage(string value) : base(value) { }
        public  Linkage(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Linkage";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
