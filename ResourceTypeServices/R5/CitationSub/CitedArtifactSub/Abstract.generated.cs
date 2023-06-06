
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Abstract : BackboneElement<Abstract>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}

        #endregion
        #region Constructor
        public  Abstract() { }
        public  Abstract(string value) : base(value) { }
        public  Abstract(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Abstract";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
