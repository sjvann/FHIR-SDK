
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AdministrableProductDefinitionSub.RouteOfAdministrationSub.TargetSpeciesSub
{
    public class WithdrawalPeriod : BackboneElement<WithdrawalPeriod>
    {

        #region Property
        [Element("tissue", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Tissue {get; set;}
[Element("value", typeof(Quantity), false, false, false, false)]
public Quantity Value {get; set;}
[Element("supportingInformation", typeof(FhirString), true, false, false, false)]
public FhirString SupportingInformation {get; set;}

        #endregion
        #region Constructor
        public  WithdrawalPeriod() { }
        public  WithdrawalPeriod(string value) : base(value) { }
        public  WithdrawalPeriod(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "WithdrawalPeriod";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
