

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.OrganizationSub
{
    public class Organization : DomainResource<Organization>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("alias", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Alias {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("contact", typeof(ExtendedContactDetail), false, true, false, false)]
public IEnumerable<ExtendedContactDetail> Contact {get; set;}
[Element("partOf", typeof(Reference), false, false, false, false)]
public Reference PartOf {get; set;}
[Element("endpoint", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Endpoint {get; set;}
[Element("qualification", typeof(Qualification), false, true, false, true)]
public IEnumerable<Qualification> Qualification {get; set;}

        #endregion
        #region Constructor
        public  Organization() { }

        public  Organization(string value) : base(value) { }
        public  Organization(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Organization";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
