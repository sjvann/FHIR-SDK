
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ContractSub.TermSub
{
    public class SecurityLabel : BackboneElement<SecurityLabel>
    {

        #region Property
        [Element("number", typeof(FhirUnsignedInt), true, true, false, false)]
public IEnumerable<FhirUnsignedInt> Number {get; set;}
[Element("classification", typeof(Coding), false, false, false, false)]
public Coding Classification {get; set;}
[Element("category", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Category {get; set;}
[Element("control", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Control {get; set;}

        #endregion
        #region Constructor
        public  SecurityLabel() { }
        public  SecurityLabel(string value) : base(value) { }
        public  SecurityLabel(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SecurityLabel";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
