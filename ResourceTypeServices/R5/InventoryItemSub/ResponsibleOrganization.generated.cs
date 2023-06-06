
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.InventoryItemSub
{
    public class ResponsibleOrganization : BackboneElement<ResponsibleOrganization>
    {

        #region Property
        [Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("organization", typeof(Reference), false, false, false, false)]
public Reference Organization {get; set;}

        #endregion
        #region Constructor
        public  ResponsibleOrganization() { }
        public  ResponsibleOrganization(string value) : base(value) { }
        public  ResponsibleOrganization(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ResponsibleOrganization";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
