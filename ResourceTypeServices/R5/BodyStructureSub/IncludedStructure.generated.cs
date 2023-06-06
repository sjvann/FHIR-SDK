
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.BodyStructureSub.IncludedStructureSub;

namespace ResourceTypeServices.R5.BodyStructureSub
{
    public class IncludedStructure : BackboneElement<IncludedStructure>
    {

        #region Property
        [Element("structure", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Structure {get; set;}
[Element("laterality", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Laterality {get; set;}
[Element("bodyLandmarkOrientation", typeof(BodyLandmarkOrientation), false, true, false, true)]
public IEnumerable<BodyLandmarkOrientation> BodyLandmarkOrientation {get; set;}
[Element("spatialReference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SpatialReference {get; set;}
[Element("qualifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Qualifier {get; set;}

        #endregion
        #region Constructor
        public  IncludedStructure() { }
        public  IncludedStructure(string value) : base(value) { }
        public  IncludedStructure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "IncludedStructure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
