
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CoverageSub.CostToBeneficiarySub
{
    public class Exception : BackboneElement<Exception>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  Exception() { }
        public  Exception(string value) : base(value) { }
        public  Exception(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Exception";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
