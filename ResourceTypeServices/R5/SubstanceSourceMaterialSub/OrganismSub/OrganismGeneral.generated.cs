
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub.OrganismSub
{
    public class OrganismGeneral : BackboneElement<OrganismGeneral>
    {

        #region Property
        [Element("kingdom", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Kingdom {get; set;}
[Element("phylum", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Phylum {get; set;}
[Element("class", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Class {get; set;}
[Element("order", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Order {get; set;}

        #endregion
        #region Constructor
        public  OrganismGeneral() { }
        public  OrganismGeneral(string value) : base(value) { }
        public  OrganismGeneral(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "OrganismGeneral";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
