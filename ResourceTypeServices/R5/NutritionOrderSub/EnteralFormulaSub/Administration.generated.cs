
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.NutritionOrderSub.EnteralFormulaSub.AdministrationSub;

namespace ResourceTypeServices.R5.NutritionOrderSub.EnteralFormulaSub
{
    public class Administration : BackboneElement<Administration>
    {

        #region Property
        [Element("schedule", typeof(Schedule), false, false, false, true)]
public Schedule Schedule {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("rate", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Rate {get; set;}

        #endregion
        #region Constructor
        public  Administration() { }
        public  Administration(string value) : base(value) { }
        public  Administration(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Administration";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
