
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub.NameSub
{
    public class Official : BackboneElement<Official>
    {

        #region Property
        [Element("authority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Authority {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}

        #endregion
        #region Constructor
        public  Official() { }
        public  Official(string value) : base(value) { }
        public  Official(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Official";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
