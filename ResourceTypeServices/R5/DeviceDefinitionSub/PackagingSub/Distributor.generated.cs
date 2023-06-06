
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub.PackagingSub
{
    public class Distributor : BackboneElement<Distributor>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("organizationReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> OrganizationReference {get; set;}

        #endregion
        #region Constructor
        public  Distributor() { }
        public  Distributor(string value) : base(value) { }
        public  Distributor(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Distributor";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
