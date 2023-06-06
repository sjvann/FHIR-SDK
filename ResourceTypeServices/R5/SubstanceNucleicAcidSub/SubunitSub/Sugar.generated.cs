
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceNucleicAcidSub.SubunitSub
{
    public class Sugar : BackboneElement<Sugar>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("residueSite", typeof(FhirString), true, false, false, false)]
public FhirString ResidueSite {get; set;}

        #endregion
        #region Constructor
        public  Sugar() { }
        public  Sugar(string value) : base(value) { }
        public  Sugar(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Sugar";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
