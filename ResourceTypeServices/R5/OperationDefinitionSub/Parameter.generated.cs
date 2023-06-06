
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.OperationDefinitionSub.ParameterSub;

namespace ResourceTypeServices.R5.OperationDefinitionSub
{
    public class Parameter : BackboneElement<Parameter>
    {

        #region Property
        [Element("name", typeof(FhirCode), true, false, false, false)]
public FhirCode Name {get; set;}
[Element("use", typeof(FhirCode), true, false, false, false)]
public FhirCode Use {get; set;}
[Element("scope", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Scope {get; set;}
[Element("min", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Min {get; set;}
[Element("max", typeof(FhirString), true, false, false, false)]
public FhirString Max {get; set;}
[Element("documentation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Documentation {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("allowedType", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> AllowedType {get; set;}
[Element("targetProfile", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> TargetProfile {get; set;}
[Element("searchType", typeof(FhirCode), true, false, false, false)]
public FhirCode SearchType {get; set;}
[Element("binding", typeof(Binding), false, false, false, true)]
public Binding Binding {get; set;}
[Element("referencedFrom", typeof(ReferencedFrom), false, true, false, true)]
public IEnumerable<ReferencedFrom> ReferencedFrom {get; set;}

        #endregion
        #region Constructor
        public  Parameter() { }
        public  Parameter(string value) : base(value) { }
        public  Parameter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Parameter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
