
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CodeSystemSub.ConceptSub
{
    public class Designation : BackboneElement<Designation>
    {

        #region Property
        [Element("language", typeof(FhirCode), true, false, false, false)]
public FhirCode Language {get; set;}
[Element("use", typeof(Coding), false, false, false, false)]
public Coding Use {get; set;}
[Element("additionalUse", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> AdditionalUse {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  Designation() { }
        public  Designation(string value) : base(value) { }
        public  Designation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Designation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
