

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub
{
    public class SubstanceSourceMaterial : DomainResource<SubstanceSourceMaterial>
    {
        #region Property
        [Element("sourceMaterialClass", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SourceMaterialClass {get; set;}
[Element("sourceMaterialType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SourceMaterialType {get; set;}
[Element("sourceMaterialState", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SourceMaterialState {get; set;}
[Element("organismId", typeof(Identifier), false, false, false, false)]
public Identifier OrganismId {get; set;}
[Element("organismName", typeof(FhirString), true, false, false, false)]
public FhirString OrganismName {get; set;}
[Element("parentSubstanceId", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> ParentSubstanceId {get; set;}
[Element("parentSubstanceName", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> ParentSubstanceName {get; set;}
[Element("countryOfOrigin", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> CountryOfOrigin {get; set;}
[Element("geographicalLocation", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> GeographicalLocation {get; set;}
[Element("developmentStage", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DevelopmentStage {get; set;}
[Element("fractionDescription", typeof(FractionDescription), false, true, false, true)]
public IEnumerable<FractionDescription> FractionDescription {get; set;}
[Element("organism", typeof(Organism), false, false, false, true)]
public Organism Organism {get; set;}
[Element("partDescription", typeof(PartDescription), false, true, false, true)]
public IEnumerable<PartDescription> PartDescription {get; set;}

        #endregion
        #region Constructor
        public  SubstanceSourceMaterial() { }

        public  SubstanceSourceMaterial(string value) : base(value) { }
        public  SubstanceSourceMaterial(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstanceSourceMaterial";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
