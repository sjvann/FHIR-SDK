
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.DeviceDefinitionSub.PackagingSub;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Packaging : BackboneElement<Packaging>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("count", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Count {get; set;}
[Element("distributor", typeof(Distributor), false, true, false, true)]
public IEnumerable<Distributor> Distributor {get; set;}

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
