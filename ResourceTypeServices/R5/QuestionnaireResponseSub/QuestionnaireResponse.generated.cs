

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.QuestionnaireResponseSub
{
    public class QuestionnaireResponse : DomainResource<QuestionnaireResponse>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("questionnaire", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Questionnaire {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("authored", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Authored {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("source", typeof(Reference), false, false, false, false)]
public Reference Source {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}

        #endregion
        #region Constructor
        public  QuestionnaireResponse() { }

        public  QuestionnaireResponse(string value) : base(value) { }
        public  QuestionnaireResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "QuestionnaireResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
