
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RequirementsSub
{
    public class Statement : BackboneElement<Statement>
    {

        #region Property
        [Element("key", typeof(FhirId), true, false, false, false)]
public FhirId Key {get; set;}
[Element("label", typeof(FhirString), true, false, false, false)]
public FhirString Label {get; set;}
[Element("conformance", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Conformance {get; set;}
[Element("conditionality", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Conditionality {get; set;}
[Element("requirement", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Requirement {get; set;}
[Element("derivedFrom", typeof(FhirString), true, false, false, false)]
public FhirString DerivedFrom {get; set;}
[Element("parent", typeof(FhirString), true, false, false, false)]
public FhirString Parent {get; set;}
[Element("satisfiedBy", typeof(FhirUrl), true, true, false, false)]
public IEnumerable<FhirUrl> SatisfiedBy {get; set;}
[Element("reference", typeof(FhirUrl), true, true, false, false)]
public IEnumerable<FhirUrl> Reference {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  Statement() { }
        public  Statement(string value) : base(value) { }
        public  Statement(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Statement";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
