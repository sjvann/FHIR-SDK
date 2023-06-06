
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConceptMapSub.GroupSub.ElementSub.TargetSub
{
    public class DependsOn : BackboneElement<DependsOn>
    {

        #region Property
        [Element("attribute", typeof(FhirCode), true, false, false, false)]
public FhirCode Attribute {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}

        #endregion
        #region Constructor
        public  DependsOn() { }
        public  DependsOn(string value) : base(value) { }
        public  DependsOn(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DependsOn";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
