
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ImagingSelectionSub.InstanceSub;

namespace ResourceTypeServices.R5.ImagingSelectionSub
{
    public class Instance : BackboneElement<Instance>
    {

        #region Property
        [Element("uid", typeof(FhirId), true, false, false, false)]
public FhirId Uid {get; set;}
[Element("number", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Number {get; set;}
[Element("sopClass", typeof(Coding), false, false, false, false)]
public Coding SopClass {get; set;}
[Element("subset", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Subset {get; set;}
[Element("imageRegion2D", typeof(ImageRegion2D), false, true, false, true)]
public IEnumerable<ImageRegion2D> ImageRegion2D {get; set;}
[Element("imageRegion3D", typeof(ImageRegion3D), false, true, false, true)]
public IEnumerable<ImageRegion3D> ImageRegion3D {get; set;}

        #endregion
        #region Constructor
        public  Instance() { }
        public  Instance(string value) : base(value) { }
        public  Instance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Instance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
