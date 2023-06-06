
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExampleScenarioSub.InstanceSub
{
    public class ContainedInstance : BackboneElement<ContainedInstance>
    {

        #region Property
        [Element("instanceReference", typeof(FhirString), true, false, false, false)]
public FhirString InstanceReference {get; set;}
[Element("versionReference", typeof(FhirString), true, false, false, false)]
public FhirString VersionReference {get; set;}

        #endregion
        #region Constructor
        public  ContainedInstance() { }
        public  ContainedInstance(string value) : base(value) { }
        public  ContainedInstance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ContainedInstance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
