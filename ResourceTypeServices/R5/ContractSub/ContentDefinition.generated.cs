
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ContractSub
{
    public class ContentDefinition : BackboneElement<ContentDefinition>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubType {get; set;}
[Element("publisher", typeof(Reference), false, false, false, false)]
public Reference Publisher {get; set;}
[Element("publicationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PublicationDate {get; set;}
[Element("publicationStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode PublicationStatus {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}

        #endregion
        #region Constructor
        public  ContentDefinition() { }
        public  ContentDefinition(string value) : base(value) { }
        public  ContentDefinition(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ContentDefinition";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
