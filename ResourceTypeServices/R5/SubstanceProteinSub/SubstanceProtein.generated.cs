

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceProteinSub
{
    public class SubstanceProtein : DomainResource<SubstanceProtein>
    {
        #region Property
        [Element("sequenceType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SequenceType {get; set;}
[Element("numberOfSubunits", typeof(FhirInteger), true, false, false, false)]
public FhirInteger NumberOfSubunits {get; set;}
[Element("disulfideLinkage", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> DisulfideLinkage {get; set;}
[Element("subunit", typeof(Subunit), false, true, false, true)]
public IEnumerable<Subunit> Subunit {get; set;}

        #endregion
        #region Constructor
        public  SubstanceProtein() { }

        public  SubstanceProtein(string value) : base(value) { }
        public  SubstanceProtein(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstanceProtein";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
