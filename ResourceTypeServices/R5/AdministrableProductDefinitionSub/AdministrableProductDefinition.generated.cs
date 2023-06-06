

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AdministrableProductDefinitionSub
{
    public class AdministrableProductDefinition : DomainResource<AdministrableProductDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("formOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> FormOf {get; set;}
[Element("administrableDoseForm", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AdministrableDoseForm {get; set;}
[Element("unitOfPresentation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept UnitOfPresentation {get; set;}
[Element("producedFrom", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ProducedFrom {get; set;}
[Element("ingredient", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Ingredient {get; set;}
[Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("routeOfAdministration", typeof(RouteOfAdministration), false, true, false, true)]
public IEnumerable<RouteOfAdministration> RouteOfAdministration {get; set;}

        #endregion
        #region Constructor
        public  AdministrableProductDefinition() { }

        public  AdministrableProductDefinition(string value) : base(value) { }
        public  AdministrableProductDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "AdministrableProductDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
