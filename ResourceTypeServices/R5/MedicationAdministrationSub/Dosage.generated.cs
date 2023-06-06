
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationAdministrationSub
{
    public class Dosage : BackboneElement<Dosage>
    {

        #region Property
        [Element("site", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Site {get; set;}
[Element("route", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Route {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("dose", typeof(Quantity), false, false, false, false)]
public Quantity Dose {get; set;}
[Element("rate", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Rate {get; set;}

        #endregion
        #region Constructor
        public  Dosage() { }
        public  Dosage(string value) : base(value) { }
        public  Dosage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Dosage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
