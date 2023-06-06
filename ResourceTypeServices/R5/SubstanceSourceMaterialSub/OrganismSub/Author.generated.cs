
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceSourceMaterialSub.OrganismSub
{
    public class Author : BackboneElement<Author>
    {

        #region Property
        [Element("authorType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AuthorType {get; set;}
[Element("authorDescription", typeof(FhirString), true, false, false, false)]
public FhirString AuthorDescription {get; set;}

        #endregion
        #region Constructor
        public  Author() { }
        public  Author(string value) : base(value) { }
        public  Author(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Author";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
