
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Scope : BackboneElement<Scope>
    {

        #region Property
        [Element("artifact", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Artifact {get; set;}
[Element("conformance", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Conformance {get; set;}
[Element("phase", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Phase {get; set;}

        #endregion
        #region Constructor
        public  Scope() { }
        public  Scope(string value) : base(value) { }
        public  Scope(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Scope";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
