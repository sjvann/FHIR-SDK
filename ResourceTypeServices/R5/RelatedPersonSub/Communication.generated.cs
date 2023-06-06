
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RelatedPersonSub
{
    public class Communication : BackboneElement<Communication>
    {

        #region Property
        [Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}
[Element("preferred", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Preferred {get; set;}

        #endregion
        #region Constructor
        public  Communication() { }
        public  Communication(string value) : base(value) { }
        public  Communication(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Communication";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
