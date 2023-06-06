
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class Indication : BackboneElement<Indication>
    {

        #region Property
        [Element("diseaseSymptomProcedure", typeof(CodeableReference), false, false, false, false)]
public CodeableReference DiseaseSymptomProcedure {get; set;}
[Element("diseaseStatus", typeof(CodeableReference), false, false, false, false)]
public CodeableReference DiseaseStatus {get; set;}
[Element("comorbidity", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Comorbidity {get; set;}
[Element("intendedEffect", typeof(CodeableReference), false, false, false, false)]
public CodeableReference IntendedEffect {get; set;}
[Element("duration", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Duration {get; set;}
[Element("undesirableEffect", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> UndesirableEffect {get; set;}
[Element("applicability", typeof(Expression), false, false, false, false)]
public Expression Applicability {get; set;}

        #endregion
        #region Constructor
        public  Indication() { }
        public  Indication(string value) : base(value) { }
        public  Indication(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Indication";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
