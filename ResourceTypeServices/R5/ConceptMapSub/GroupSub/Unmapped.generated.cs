
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ConceptMapSub.GroupSub
{
    public class Unmapped : BackboneElement<Unmapped>
    {

        #region Property
        [Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("display", typeof(FhirString), true, false, false, false)]
public FhirString Display {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}
[Element("relationship", typeof(FhirCode), true, false, false, false)]
public FhirCode Relationship {get; set;}
[Element("otherMap", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical OtherMap {get; set;}

        #endregion
        #region Constructor
        public  Unmapped() { }
        public  Unmapped(string value) : base(value) { }
        public  Unmapped(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Unmapped";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
