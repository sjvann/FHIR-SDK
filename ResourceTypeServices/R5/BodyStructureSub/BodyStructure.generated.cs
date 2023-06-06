

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BodyStructureSub
{
    public class BodyStructure : DomainResource<BodyStructure>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("morphology", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Morphology {get; set;}
[Element("includedStructure", typeof(IncludedStructure), false, true, false, true)]
public IEnumerable<IncludedStructure> IncludedStructure {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("image", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> Image {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}

        #endregion
        #region Constructor
        public  BodyStructure() { }

        public  BodyStructure(string value) : base(value) { }
        public  BodyStructure(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "BodyStructure";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
