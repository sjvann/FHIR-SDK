
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.BodyStructureSub.IncludedStructureSub.BodyLandmarkOrientationSub;

namespace ResourceTypeServices.R5.BodyStructureSub.IncludedStructureSub
{
    public class BodyLandmarkOrientation : BackboneElement<BodyLandmarkOrientation>
    {

        #region Property
        [Element("landmarkDescription", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> LandmarkDescription {get; set;}
[Element("clockFacePosition", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ClockFacePosition {get; set;}
[Element("distanceFromLandmark", typeof(DistanceFromLandmark), false, true, false, true)]
public IEnumerable<DistanceFromLandmark> DistanceFromLandmark {get; set;}
[Element("surfaceOrientation", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SurfaceOrientation {get; set;}

        #endregion
        #region Constructor
        public  BodyLandmarkOrientation() { }
        public  BodyLandmarkOrientation(string value) : base(value) { }
        public  BodyLandmarkOrientation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "BodyLandmarkOrientation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
