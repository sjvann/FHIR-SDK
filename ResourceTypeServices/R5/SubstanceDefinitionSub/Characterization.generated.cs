
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Characterization : BackboneElement<Characterization>
    {

        #region Property
        [Element("technique", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Technique {get; set;}
[Element("form", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Form {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("file", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> File {get; set;}

        #endregion
        #region Constructor
        public  Characterization() { }
        public  Characterization(string value) : base(value) { }
        public  Characterization(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Characterization";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
