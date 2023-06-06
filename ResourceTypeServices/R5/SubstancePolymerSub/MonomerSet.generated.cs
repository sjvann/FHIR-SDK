
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.SubstancePolymerSub.MonomerSetSub;

namespace ResourceTypeServices.R5.SubstancePolymerSub
{
    public class MonomerSet : BackboneElement<MonomerSet>
    {

        #region Property
        [Element("ratioType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept RatioType {get; set;}
[Element("startingMaterial", typeof(StartingMaterial), false, true, false, true)]
public IEnumerable<StartingMaterial> StartingMaterial {get; set;}

        #endregion
        #region Constructor
        public  MonomerSet() { }
        public  MonomerSet(string value) : base(value) { }
        public  MonomerSet(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MonomerSet";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
