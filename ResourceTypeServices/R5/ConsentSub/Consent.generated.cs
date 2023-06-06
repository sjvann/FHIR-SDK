

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConsentSub
{
    public class Consent : DomainResource<Consent>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("date", typeof(FhirDate), true, false, false, false)]
public FhirDate Date {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("grantor", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Grantor {get; set;}
[Element("grantee", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Grantee {get; set;}
[Element("manager", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manager {get; set;}
[Element("controller", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Controller {get; set;}
[Element("sourceAttachment", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> SourceAttachment {get; set;}
[Element("sourceReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SourceReference {get; set;}
[Element("regulatoryBasis", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> RegulatoryBasis {get; set;}
[Element("policyBasis", typeof(PolicyBasis), false, false, false, true)]
public PolicyBasis PolicyBasis {get; set;}
[Element("policyText", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PolicyText {get; set;}
[Element("verification", typeof(Verification), false, true, false, true)]
public IEnumerable<Verification> Verification {get; set;}
[Element("decision", typeof(FhirCode), true, false, false, false)]
public FhirCode Decision {get; set;}
[Element("provision", typeof(Provision), false, true, false, true)]
public IEnumerable<Provision> Provision {get; set;}

        #endregion
        #region Constructor
        public  Consent() { }

        public  Consent(string value) : base(value) { }
        public  Consent(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Consent";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
