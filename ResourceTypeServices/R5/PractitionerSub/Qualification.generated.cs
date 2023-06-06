
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PractitionerSub
{
    public class Qualification : BackboneElement<Qualification>
    {

        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("issuer", typeof(Reference), false, false, false, false)]
public Reference Issuer {get; set;}

        #endregion
        #region Constructor
        public  Qualification() { }
        public  Qualification(string value) : base(value) { }
        public  Qualification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Qualification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
