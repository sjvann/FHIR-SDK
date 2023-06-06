
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SpecimenDefinitionSub.TypeTestedSub.ContainerSub;

namespace ResourceTypeServices.R5.SpecimenDefinitionSub.TypeTestedSub
{
    public class Container : BackboneElement<Container>
    {

        #region Property
        [Element("material", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Material {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("cap", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Cap {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("capacity", typeof(Quantity), false, false, false, false)]
public Quantity Capacity {get; set;}
[Element("minimumVolume", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased MinimumVolume {get; set;}
[Element("additive", typeof(Additive), false, true, false, true)]
public IEnumerable<Additive> Additive {get; set;}
[Element("preparation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Preparation {get; set;}

        #endregion
        #region Constructor
        public  Container() { }
        public  Container(string value) : base(value) { }
        public  Container(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Container";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
