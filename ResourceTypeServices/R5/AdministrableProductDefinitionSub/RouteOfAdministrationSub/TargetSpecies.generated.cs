
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.AdministrableProductDefinitionSub.RouteOfAdministrationSub.TargetSpeciesSub;

namespace ResourceTypeServices.R5.AdministrableProductDefinitionSub.RouteOfAdministrationSub
{
    public class TargetSpecies : BackboneElement<TargetSpecies>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("withdrawalPeriod", typeof(WithdrawalPeriod), false, true, false, true)]
public IEnumerable<WithdrawalPeriod> WithdrawalPeriod {get; set;}

        #endregion
        #region Constructor
        public  TargetSpecies() { }
        public  TargetSpecies(string value) : base(value) { }
        public  TargetSpecies(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TargetSpecies";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
