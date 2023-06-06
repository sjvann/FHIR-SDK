
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.SubstanceDefinitionSub.NameSub;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class Name : BackboneElement<Name>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString NameProp {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("preferred", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Preferred {get; set;}
[Element("language", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Language {get; set;}
[Element("domain", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Domain {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Jurisdiction {get; set;}
[Element("official", typeof(Official), false, true, false, true)]
public IEnumerable<Official> Official {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Name() { }
        public  Name(string value) : base(value) { }
        public  Name(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Name";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
