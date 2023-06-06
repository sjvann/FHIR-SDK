
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Relationship : BackboneElement<Relationship>
    {

        #region Property
        [Element("substanceDefinition", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased SubstanceDefinition {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("isDefining", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsDefining {get; set;}
[Element("amount", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Amount {get; set;}
[Element("ratioHighLimitAmount", typeof(Ratio), false, false, false, false)]
public Ratio RatioHighLimitAmount {get; set;}
[Element("comparator", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Comparator {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Relationship() { }
        public  Relationship(string value) : base(value) { }
        public  Relationship(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Relationship";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
