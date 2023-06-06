
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceReferenceInformationSub
{
    public class Target : BackboneElement<Target>
    {

        #region Property
        [Element("target", typeof(Identifier), false, false, false, false)]
public Identifier TargetProp {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("interaction", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Interaction {get; set;}
[Element("organism", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Organism {get; set;}
[Element("organismType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OrganismType {get; set;}
[Element("amount", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Amount {get; set;}
[Element("amountType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AmountType {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Target() { }
        public  Target(string value) : base(value) { }
        public  Target(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Target";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
