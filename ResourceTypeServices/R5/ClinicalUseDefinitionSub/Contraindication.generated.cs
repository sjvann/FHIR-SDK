
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.ClinicalUseDefinitionSub.ContraindicationSub;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class Contraindication : BackboneElement<Contraindication>
    {

        #region Property
        [Element("diseaseSymptomProcedure", typeof(CodeableReference), false, false, false, false)]
public CodeableReference DiseaseSymptomProcedure {get; set;}
[Element("diseaseStatus", typeof(CodeableReference), false, false, false, false)]
public CodeableReference DiseaseStatus {get; set;}
[Element("comorbidity", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Comorbidity {get; set;}
[Element("indication", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Indication {get; set;}
[Element("applicability", typeof(Expression), false, false, false, false)]
public Expression Applicability {get; set;}
[Element("otherTherapy", typeof(OtherTherapy), false, true, false, true)]
public IEnumerable<OtherTherapy> OtherTherapy {get; set;}

        #endregion
        #region Constructor
        public  Contraindication() { }
        public  Contraindication(string value) : base(value) { }
        public  Contraindication(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Contraindication";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
