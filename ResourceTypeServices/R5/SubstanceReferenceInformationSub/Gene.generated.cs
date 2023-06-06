
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceReferenceInformationSub
{
    public class Gene : BackboneElement<Gene>
    {

        #region Property
        [Element("geneSequenceOrigin", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept GeneSequenceOrigin {get; set;}
[Element("gene", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept GeneProp {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Gene() { }
        public  Gene(string value) : base(value) { }
        public  Gene(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Gene";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
