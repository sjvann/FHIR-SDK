
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.BodyStructureSub.IncludedStructureSub.BodyLandmarkOrientationSub
{
    public class DistanceFromLandmark : BackboneElement<DistanceFromLandmark>
    {

        #region Property
        [Element("device", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Device {get; set;}
[Element("value", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> Value {get; set;}

        #endregion
        #region Constructor
        public  DistanceFromLandmark() { }
        public  DistanceFromLandmark(string value) : base(value) { }
        public  DistanceFromLandmark(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DistanceFromLandmark";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
