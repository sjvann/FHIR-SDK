
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class Packaging : BackboneElement<Packaging>
    {

        #region Property
        [Element("packagedProduct", typeof(Reference), false, false, false, false)]
public Reference PackagedProduct {get; set;}

        #endregion
        #region Constructor
        public  Packaging() { }
        public  Packaging(string value) : base(value) { }
        public  Packaging(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Packaging";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
