
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.AuditEventSub.EntitySub;

namespace ResourceTypeServices.R5.AuditEventSub
{
    public class Entity : BackboneElement<Entity>
    {

        #region Property
        [Element("what", typeof(Reference), false, false, false, false)]
public Reference What {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("securityLabel", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> SecurityLabel {get; set;}
[Element("query", typeof(FhirBase64Binary), true, false, false, false)]
public FhirBase64Binary Query {get; set;}
[Element("detail", typeof(Detail), false, true, false, true)]
public IEnumerable<Detail> Detail {get; set;}

        #endregion
        #region Constructor
        public  Entity() { }
        public  Entity(string value) : base(value) { }
        public  Entity(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Entity";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
