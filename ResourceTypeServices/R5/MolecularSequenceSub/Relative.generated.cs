
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MolecularSequenceSub.RelativeSub;

namespace ResourceTypeServices.R5.MolecularSequenceSub
{
    public class Relative : BackboneElement<Relative>
    {

        #region Property
        [Element("coordinateSystem", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CoordinateSystem {get; set;}
[Element("ordinalPosition", typeof(FhirInteger), true, false, false, false)]
public FhirInteger OrdinalPosition {get; set;}
[Element("sequenceRange", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range SequenceRange {get; set;}
[Element("startingSequence", typeof(StartingSequence), false, false, false, true)]
public StartingSequence StartingSequence {get; set;}
[Element("edit", typeof(Edit), false, true, false, true)]
public IEnumerable<Edit> Edit {get; set;}

        #endregion
        #region Constructor
        public  Relative() { }
        public  Relative(string value) : base(value) { }
        public  Relative(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Relative";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
