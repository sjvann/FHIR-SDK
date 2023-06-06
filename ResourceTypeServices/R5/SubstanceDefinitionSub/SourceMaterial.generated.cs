
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class SourceMaterial : BackboneElement<SourceMaterial>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("genus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Genus {get; set;}
[Element("species", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Species {get; set;}
[Element("part", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Part {get; set;}
[Element("countryOfOrigin", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> CountryOfOrigin {get; set;}

        #endregion
        #region Constructor
        public  SourceMaterial() { }
        public  SourceMaterial(string value) : base(value) { }
        public  SourceMaterial(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SourceMaterial";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
