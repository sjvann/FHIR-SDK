
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.SpecimenDefinitionSub.TypeTestedSub.ContainerSub
{
    public class Additive : BackboneElement<Additive>
    {

        #region Property
        [Element("additive", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased AdditiveProp {get; set;}

        #endregion
        #region Constructor
        public  Additive() { }
        public  Additive(string value) : base(value) { }
        public  Additive(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Additive";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
