
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Moiety : BackboneElement<Moiety>
    {

        #region Property
        [Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("stereochemistry", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Stereochemistry {get; set;}
[Element("opticalActivity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OpticalActivity {get; set;}
[Element("molecularFormula", typeof(FhirString), true, false, false, false)]
public FhirString MolecularFormula {get; set;}
[Element("amount", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Amount {get; set;}
[Element("measurementType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept MeasurementType {get; set;}

        #endregion
        #region Constructor
        public  Moiety() { }
        public  Moiety(string value) : base(value) { }
        public  Moiety(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Moiety";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
