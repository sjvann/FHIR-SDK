
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub.OrganismSub
{
    public class Hybrid : BackboneElement<Hybrid>
    {

        #region Property
        [Element("maternalOrganismId", typeof(FhirString), true, false, false, false)]
public FhirString MaternalOrganismId {get; set;}
[Element("maternalOrganismName", typeof(FhirString), true, false, false, false)]
public FhirString MaternalOrganismName {get; set;}
[Element("paternalOrganismId", typeof(FhirString), true, false, false, false)]
public FhirString PaternalOrganismId {get; set;}
[Element("paternalOrganismName", typeof(FhirString), true, false, false, false)]
public FhirString PaternalOrganismName {get; set;}
[Element("hybridType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept HybridType {get; set;}

        #endregion
        #region Constructor
        public  Hybrid() { }
        public  Hybrid(string value) : base(value) { }
        public  Hybrid(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Hybrid";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
