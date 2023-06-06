
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceProteinSub
{
    public class Subunit : BackboneElement<Subunit>
    {

        #region Property
        [Element("subunit", typeof(FhirInteger), true, false, false, false)]
public FhirInteger SubunitProp {get; set;}
[Element("sequence", typeof(FhirString), true, false, false, false)]
public FhirString Sequence {get; set;}
[Element("length", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Length {get; set;}
[Element("sequenceAttachment", typeof(Attachment), false, false, false, false)]
public Attachment SequenceAttachment {get; set;}
[Element("nTerminalModificationId", typeof(Identifier), false, false, false, false)]
public Identifier NTerminalModificationId {get; set;}
[Element("nTerminalModification", typeof(FhirString), true, false, false, false)]
public FhirString NTerminalModification {get; set;}
[Element("cTerminalModificationId", typeof(Identifier), false, false, false, false)]
public Identifier CTerminalModificationId {get; set;}
[Element("cTerminalModification", typeof(FhirString), true, false, false, false)]
public FhirString CTerminalModification {get; set;}

        #endregion
        #region Constructor
        public  Subunit() { }
        public  Subunit(string value) : base(value) { }
        public  Subunit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Subunit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
