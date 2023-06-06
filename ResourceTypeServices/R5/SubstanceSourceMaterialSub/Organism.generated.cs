
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstanceSourceMaterialSub.OrganismSub;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub
{
    public class Organism : BackboneElement<Organism>
    {

        #region Property
        [Element("family", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Family {get; set;}
[Element("genus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Genus {get; set;}
[Element("species", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Species {get; set;}
[Element("intraspecificType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept IntraspecificType {get; set;}
[Element("intraspecificDescription", typeof(FhirString), true, false, false, false)]
public FhirString IntraspecificDescription {get; set;}
[Element("author", typeof(Author), false, true, false, true)]
public IEnumerable<Author> Author {get; set;}
[Element("hybrid", typeof(Hybrid), false, false, false, true)]
public Hybrid Hybrid {get; set;}
[Element("organismGeneral", typeof(OrganismGeneral), false, false, false, true)]
public OrganismGeneral OrganismGeneral {get; set;}

        #endregion
        #region Constructor
        public  Organism() { }
        public  Organism(string value) : base(value) { }
        public  Organism(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Organism";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
