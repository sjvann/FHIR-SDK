

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceReferenceInformationSub
{
    public class SubstanceReferenceInformation : DomainResource<SubstanceReferenceInformation>
    {
        #region Property
        [Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}
[Element("gene", typeof(Gene), false, true, false, true)]
public IEnumerable<Gene> Gene {get; set;}
[Element("geneElement", typeof(GeneElement), false, true, false, true)]
public IEnumerable<GeneElement> GeneElement {get; set;}
[Element("target", typeof(Target), false, true, false, true)]
public IEnumerable<Target> Target {get; set;}

        #endregion
        #region Constructor
        public  SubstanceReferenceInformation() { }

        public  SubstanceReferenceInformation(string value) : base(value) { }
        public  SubstanceReferenceInformation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstanceReferenceInformation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
