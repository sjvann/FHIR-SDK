

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class ClinicalUseDefinition : DomainResource<ClinicalUseDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("subject", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Subject {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("contraindication", typeof(Contraindication), false, false, false, true)]
public Contraindication Contraindication {get; set;}
[Element("indication", typeof(Indication), false, false, false, true)]
public Indication Indication {get; set;}
[Element("interaction", typeof(Interaction), false, false, false, true)]
public Interaction Interaction {get; set;}
[Element("population", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Population {get; set;}
[Element("library", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Library {get; set;}
[Element("undesirableEffect", typeof(UndesirableEffect), false, false, false, true)]
public UndesirableEffect UndesirableEffect {get; set;}
[Element("warning", typeof(Warning), false, false, false, true)]
public Warning Warning {get; set;}

        #endregion
        #region Constructor
        public  ClinicalUseDefinition() { }

        public  ClinicalUseDefinition(string value) : base(value) { }
        public  ClinicalUseDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ClinicalUseDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
