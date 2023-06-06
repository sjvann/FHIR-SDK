
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstanceDefinitionSub.StructureSub;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Structure : BackboneElement<Structure>
    {

        #region Property
        [Element("stereochemistry", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Stereochemistry {get; set;}
[Element("opticalActivity", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OpticalActivity {get; set;}
[Element("molecularFormula", typeof(FhirString), true, false, false, false)]
public FhirString MolecularFormula {get; set;}
[Element("molecularFormulaByMoiety", typeof(FhirString), true, false, false, false)]
public FhirString MolecularFormulaByMoiety {get; set;}
[Element("technique", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Technique {get; set;}
[Element("sourceDocument", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SourceDocument {get; set;}
[Element("representation", typeof(Representation), false, true, false, true)]
public IEnumerable<Representation> Representation {get; set;}

        #endregion
        #region Constructor
        public  Structure() { }
        public  Structure(string value) : base(value) { }
        public  Structure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Structure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
