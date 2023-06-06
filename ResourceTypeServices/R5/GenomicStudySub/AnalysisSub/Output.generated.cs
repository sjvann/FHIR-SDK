
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.GenomicStudySub.AnalysisSub
{
    public class Output : BackboneElement<Output>
    {

        #region Property
        [Element("file", typeof(Reference), false, false, false, false)]
public Reference File {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}

        #endregion
        #region Constructor
        public  Output() { }
        public  Output(string value) : base(value) { }
        public  Output(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Output";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
