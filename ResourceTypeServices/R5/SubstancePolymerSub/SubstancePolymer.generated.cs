

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstancePolymerSub
{
    public class SubstancePolymer : DomainResource<SubstancePolymer>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("class", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Class {get; set;}
[Element("geometry", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Geometry {get; set;}
[Element("copolymerConnectivity", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> CopolymerConnectivity {get; set;}
[Element("modification", typeof(FhirString), true, false, false, false)]
public FhirString Modification {get; set;}
[Element("monomerSet", typeof(MonomerSet), false, true, false, true)]
public IEnumerable<MonomerSet> MonomerSet {get; set;}
[Element("repeat", typeof(Repeat), false, true, false, true)]
public IEnumerable<Repeat> Repeat {get; set;}

        #endregion
        #region Constructor
        public  SubstancePolymer() { }

        public  SubstancePolymer(string value) : base(value) { }
        public  SubstancePolymer(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstancePolymer";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
