
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub.PublicationFormSub
{
    public class PublishedIn : BackboneElement<PublishedIn>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("publisher", typeof(Reference), false, false, false, false)]
public Reference Publisher {get; set;}
[Element("publisherLocation", typeof(FhirString), true, false, false, false)]
public FhirString PublisherLocation {get; set;}

        #endregion
        #region Constructor
        public  PublishedIn() { }
        public  PublishedIn(string value) : base(value) { }
        public  PublishedIn(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PublishedIn";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
