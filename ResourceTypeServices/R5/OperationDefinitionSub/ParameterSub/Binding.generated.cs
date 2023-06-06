
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OperationDefinitionSub.ParameterSub
{
    public class Binding : BackboneElement<Binding>
    {

        #region Property
        [Element("strength", typeof(FhirCode), true, false, false, false)]
public FhirCode Strength {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}

        #endregion
        #region Constructor
        public  Binding() { }
        public  Binding(string value) : base(value) { }
        public  Binding(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Binding";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
