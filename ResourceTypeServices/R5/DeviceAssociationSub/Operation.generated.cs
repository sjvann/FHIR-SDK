
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceAssociationSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("operator", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Operator {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
