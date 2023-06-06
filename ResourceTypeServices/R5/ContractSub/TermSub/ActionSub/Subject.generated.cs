
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ContractSub.TermSub.ActionSub
{
    public class Subject : BackboneElement<Subject>
    {

        #region Property
        [Element("reference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Reference {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}

        #endregion
        #region Constructor
        public  Subject() { }
        public  Subject(string value) : base(value) { }
        public  Subject(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Subject";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
