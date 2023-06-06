
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstanceNucleicAcidSub.SubunitSub;

namespace ResourceTypeServices.R5.SubstanceNucleicAcidSub
{
    public class Subunit : BackboneElement<Subunit>
    {

        #region Property
        [Element("subunit", typeof(FhirInteger), true, false, false, false)]
public FhirInteger SubunitProp {get; set;}
[Element("sequence", typeof(FhirString), true, false, false, false)]
public FhirString Sequence {get; set;}
[Element("length", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Length {get; set;}
[Element("sequenceAttachment", typeof(Attachment), false, false, false, false)]
public Attachment SequenceAttachment {get; set;}
[Element("fivePrime", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FivePrime {get; set;}
[Element("threePrime", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ThreePrime {get; set;}
[Element("linkage", typeof(Linkage), false, true, false, true)]
public IEnumerable<Linkage> Linkage {get; set;}
[Element("sugar", typeof(Sugar), false, true, false, true)]
public IEnumerable<Sugar> Sugar {get; set;}

        #endregion
        #region Constructor
        public  Subunit() { }
        public  Subunit(string value) : base(value) { }
        public  Subunit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Subunit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
