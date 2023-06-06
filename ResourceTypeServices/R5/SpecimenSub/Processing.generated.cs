
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SpecimenSub
{
    public class Processing : BackboneElement<Processing>
    {

        #region Property
        [Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("additive", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Additive {get; set;}
[Element("time", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Time {get; set;}

        #endregion
        #region Constructor
        public  Processing() { }
        public  Processing(string value) : base(value) { }
        public  Processing(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Processing";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
