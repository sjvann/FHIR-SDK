
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.AdministrableProductDefinitionSub.RouteOfAdministrationSub;

namespace ResourceTypeServices.R5.AdministrableProductDefinitionSub
{
    public class RouteOfAdministration : BackboneElement<RouteOfAdministration>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("firstDose", typeof(Quantity), false, false, false, false)]
public Quantity FirstDose {get; set;}
[Element("maxSingleDose", typeof(Quantity), false, false, false, false)]
public Quantity MaxSingleDose {get; set;}
[Element("maxDosePerDay", typeof(Quantity), false, false, false, false)]
public Quantity MaxDosePerDay {get; set;}
[Element("maxDosePerTreatmentPeriod", typeof(Ratio), false, false, false, false)]
public Ratio MaxDosePerTreatmentPeriod {get; set;}
[Element("maxTreatmentPeriod", typeof(Duration), false, false, false, false)]
public Duration MaxTreatmentPeriod {get; set;}
[Element("targetSpecies", typeof(TargetSpecies), false, true, false, true)]
public IEnumerable<TargetSpecies> TargetSpecies {get; set;}

        #endregion
        #region Constructor
        public  RouteOfAdministration() { }
        public  RouteOfAdministration(string value) : base(value) { }
        public  RouteOfAdministration(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RouteOfAdministration";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
