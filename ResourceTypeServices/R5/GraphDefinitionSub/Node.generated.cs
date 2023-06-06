
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GraphDefinitionSub
{
    public class Node : BackboneElement<Node>
    {

        #region Property
        [Element("nodeId", typeof(FhirId), true, false, false, false)]
public FhirId NodeId {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}

        #endregion
        #region Constructor
        public  Node() { }
        public  Node(string value) : base(value) { }
        public  Node(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Node";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
