
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub.NameSub
{
    public class Usage : BackboneElement<Usage>
    {

        #region Property
        [Element("country", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Country {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Jurisdiction {get; set;}
[Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}

        #endregion
        #region Constructor
        public  Usage() { }
        public  Usage(string value) : base(value) { }
        public  Usage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Usage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
