
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MolecularSequenceSub.RelativeSub
{
    public class StartingSequence : BackboneElement<StartingSequence>
    {

        #region Property
        [Element("genomeAssembly", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept GenomeAssembly {get; set;}
[Element("chromosome", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Chromosome {get; set;}
[Element("sequence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Sequence {get; set;}
[Element("windowStart", typeof(FhirInteger), true, false, false, false)]
public FhirInteger WindowStart {get; set;}
[Element("windowEnd", typeof(FhirInteger), true, false, false, false)]
public FhirInteger WindowEnd {get; set;}
[Element("orientation", typeof(FhirCode), true, false, false, false)]
public FhirCode Orientation {get; set;}
[Element("strand", typeof(FhirCode), true, false, false, false)]
public FhirCode Strand {get; set;}

        #endregion
        #region Constructor
        public  StartingSequence() { }
        public  StartingSequence(string value) : base(value) { }
        public  StartingSequence(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StartingSequence";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
