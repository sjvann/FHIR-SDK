
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MolecularSequenceSub.RelativeSub
{
    public class Edit : BackboneElement<Edit>
    {

        #region Property
        [Element("start", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Start {get; set;}
[Element("end", typeof(FhirInteger), true, false, false, false)]
public FhirInteger End {get; set;}
[Element("replacementSequence", typeof(FhirString), true, false, false, false)]
public FhirString ReplacementSequence {get; set;}
[Element("replacedSequence", typeof(FhirString), true, false, false, false)]
public FhirString ReplacedSequence {get; set;}

        #endregion
        #region Constructor
        public  Edit() { }
        public  Edit(string value) : base(value) { }
        public  Edit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Edit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
