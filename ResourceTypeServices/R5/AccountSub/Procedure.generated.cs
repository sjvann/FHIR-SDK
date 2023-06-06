
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AccountSub
{
    public class Procedure : BackboneElement<Procedure>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("code", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Code {get; set;}
[Element("dateOfService", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime DateOfService {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("packageCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PackageCode {get; set;}
[Element("device", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Device {get; set;}

        #endregion
        #region Constructor
        public  Procedure() { }
        public  Procedure(string value) : base(value) { }
        public  Procedure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Procedure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
