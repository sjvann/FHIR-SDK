
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ContractSub.TermSub.OfferSub
{
    public class Party : BackboneElement<Party>
    {

        #region Property
        [Element("reference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Reference {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}

        #endregion
        #region Constructor
        public  Party() { }
        public  Party(string value) : base(value) { }
        public  Party(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Party";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
