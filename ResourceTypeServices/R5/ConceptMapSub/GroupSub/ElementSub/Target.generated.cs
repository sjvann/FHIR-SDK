
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ConceptMapSub.GroupSub.ElementSub.TargetSub;

namespace ResourceTypeServices.R5.ConceptMapSub.GroupSub.ElementSub
{
    public class Target : BackboneElement<Target>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}
[Element("relationship", typeof(FhirCode), true, false, false, false)]
public FhirCode Relationship {get; set;}
[Element("comment", typeof(FhirString), true, false, false, false)]
public FhirString Comment {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("dependsOn", typeof(DependsOn), false, true, false, true)]
public IEnumerable<DependsOn> DependsOn {get; set;}

        #endregion
        #region Constructor
        public  Target() { }
        public  Target(string value) : base(value) { }
        public  Target(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Target";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
