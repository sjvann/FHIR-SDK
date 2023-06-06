

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MolecularSequenceSub
{
    public class MolecularSequence : DomainResource<MolecularSequence>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("focus", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Focus {get; set;}
[Element("specimen", typeof(Reference), false, false, false, false)]
public Reference Specimen {get; set;}
[Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("performer", typeof(Reference), false, false, false, false)]
public Reference Performer {get; set;}
[Element("literal", typeof(FhirString), true, false, false, false)]
public FhirString Literal {get; set;}
[Element("formatted", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> Formatted {get; set;}
[Element("relative", typeof(Relative), false, true, false, true)]
public IEnumerable<Relative> Relative {get; set;}

        #endregion
        #region Constructor
        public  MolecularSequence() { }

        public  MolecularSequence(string value) : base(value) { }
        public  MolecularSequence(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MolecularSequence";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
