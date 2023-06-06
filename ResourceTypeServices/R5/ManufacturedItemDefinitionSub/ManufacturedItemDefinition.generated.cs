

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ManufacturedItemDefinitionSub
{
    public class ManufacturedItemDefinition : DomainResource<ManufacturedItemDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("manufacturedDoseForm", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ManufacturedDoseForm {get; set;}
[Element("unitOfPresentation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept UnitOfPresentation {get; set;}
[Element("manufacturer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manufacturer {get; set;}
[Element("marketingStatus", typeof(MarketingStatus), false, true, false, false)]
public IEnumerable<MarketingStatus> MarketingStatus {get; set;}
[Element("ingredient", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Ingredient {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("component", typeof(Component), false, true, false, true)]
public IEnumerable<Component> Component {get; set;}

        #endregion
        #region Constructor
        public  ManufacturedItemDefinition() { }

        public  ManufacturedItemDefinition(string value) : base(value) { }
        public  ManufacturedItemDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ManufacturedItemDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
