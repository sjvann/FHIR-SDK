

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceNucleicAcidSub
{
    public class SubstanceNucleicAcid : DomainResource<SubstanceNucleicAcid>
    {
        #region Property
        [Element("sequenceType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SequenceType {get; set;}
[Element("numberOfSubunits", typeof(FhirInteger), true, false, false, false)]
public FhirInteger NumberOfSubunits {get; set;}
[Element("areaOfHybridisation", typeof(FhirString), true, false, false, false)]
public FhirString AreaOfHybridisation {get; set;}
[Element("oligoNucleotideType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OligoNucleotideType {get; set;}
[Element("subunit", typeof(Subunit), false, true, false, true)]
public IEnumerable<Subunit> Subunit {get; set;}

        #endregion
        #region Constructor
        public  SubstanceNucleicAcid() { }

        public  SubstanceNucleicAcid(string value) : base(value) { }
        public  SubstanceNucleicAcid(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstanceNucleicAcid";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
