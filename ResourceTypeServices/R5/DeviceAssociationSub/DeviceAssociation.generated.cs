

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceAssociationSub
{
    public class DeviceAssociation : DomainResource<DeviceAssociation>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> StatusReason {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("bodyStructure", typeof(Reference), false, false, false, false)]
public Reference BodyStructure {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("operation", typeof(Operation), false, true, false, true)]
public IEnumerable<Operation> Operation {get; set;}

        #endregion
        #region Constructor
        public  DeviceAssociation() { }

        public  DeviceAssociation(string value) : base(value) { }
        public  DeviceAssociation(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceAssociation";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
