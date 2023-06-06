
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.GenomicStudySub.AnalysisSub
{
    public class Performer : BackboneElement<Performer>
    {

        #region Property
        [Element("actor", typeof(Reference), false, false, false, false)]
public Reference Actor {get; set;}
[Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}

        #endregion
        #region Constructor
        public  Performer() { }
        public  Performer(string value) : base(value) { }
        public  Performer(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Performer";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
