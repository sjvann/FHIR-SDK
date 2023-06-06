
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImplementationGuideSub.DefinitionSub
{
    public class Resource : BackboneElement<Resource>
    {

        #region Property
        [Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}
[Element("fhirVersion", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> FhirVersion {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("isExample", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean IsExample {get; set;}
[Element("profile", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Profile {get; set;}
[Element("groupingId", typeof(FhirId), true, false, false, false)]
public FhirId GroupingId {get; set;}

        #endregion
        #region Constructor
        public  Resource() { }
        public  Resource(string value) : base(value) { }
        public  Resource(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Resource";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
