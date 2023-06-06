

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RegulatedAuthorizationSub
{
    public class RegulatedAuthorization : DomainResource<RegulatedAuthorization>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("subject", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Subject {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("region", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Region {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("statusDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusDate {get; set;}
[Element("validityPeriod", typeof(Period), false, false, false, false)]
public Period ValidityPeriod {get; set;}
[Element("indication", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Indication {get; set;}
[Element("intendedUse", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept IntendedUse {get; set;}
[Element("basis", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Basis {get; set;}
[Element("holder", typeof(Reference), false, false, false, false)]
public Reference Holder {get; set;}
[Element("regulator", typeof(Reference), false, false, false, false)]
public Reference Regulator {get; set;}
[Element("attachedDocument", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AttachedDocument {get; set;}
[Element("case", typeof(Case), false, false, false, true)]
public Case Case {get; set;}

        #endregion
        #region Constructor
        public  RegulatedAuthorization() { }

        public  RegulatedAuthorization(string value) : base(value) { }
        public  RegulatedAuthorization(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "RegulatedAuthorization";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
