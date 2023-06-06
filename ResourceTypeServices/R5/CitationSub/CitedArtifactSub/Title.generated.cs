
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Title : BackboneElement<Title>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}

        #endregion
        #region Constructor
        public  Title() { }
        public  Title(string value) : base(value) { }
        public  Title(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Title";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
