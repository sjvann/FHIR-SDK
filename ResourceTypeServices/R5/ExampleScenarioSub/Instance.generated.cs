
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ExampleScenarioSub.InstanceSub;

namespace ResourceTypeServices.R5.ExampleScenarioSub
{
    public class Instance : BackboneElement<Instance>
    {

        #region Property
        [Element("key", typeof(FhirString), true, false, false, false)]
public FhirString Key {get; set;}
[Element("structureType", typeof(Coding), false, false, false, false)]
public Coding StructureType {get; set;}
[Element("structureVersion", typeof(FhirString), true, false, false, false)]
public FhirString StructureVersion {get; set;}
[Element("structureProfile", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased StructureProfile {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("content", typeof(Reference), false, false, false, false)]
public Reference Content {get; set;}
[Element("version", typeof(ResourceTypeServices.R5.ExampleScenarioSub.InstanceSub.Version), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.ExampleScenarioSub.InstanceSub.Version> Version {get; set;}
[Element("containedInstance", typeof(ContainedInstance), false, true, false, true)]
public IEnumerable<ContainedInstance> ContainedInstance {get; set;}

        #endregion
        #region Constructor
        public  Instance() { }
        public  Instance(string value) : base(value) { }
        public  Instance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Instance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
