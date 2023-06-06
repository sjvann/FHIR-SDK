
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImagingSelectionSub.InstanceSub
{
    public class ImageRegion3D : BackboneElement<ImageRegion3D>
    {

        #region Property
        [Element("regionType", typeof(FhirCode), true, false, false, false)]
public FhirCode RegionType {get; set;}
[Element("coordinate", typeof(FhirDecimal), true, true, false, false)]
public IEnumerable<FhirDecimal> Coordinate {get; set;}

        #endregion
        #region Constructor
        public  ImageRegion3D() { }
        public  ImageRegion3D(string value) : base(value) { }
        public  ImageRegion3D(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ImageRegion3D";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
