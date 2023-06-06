
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.GenomicStudySub.AnalysisSub
{
    public class Input : BackboneElement<Input>
    {

        #region Property
        [Element("file", typeof(Reference), false, false, false, false)]
public Reference File {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("generatedBy", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased GeneratedBy {get; set;}

        #endregion
        #region Constructor
        public  Input() { }
        public  Input(string value) : base(value) { }
        public  Input(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Input";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
