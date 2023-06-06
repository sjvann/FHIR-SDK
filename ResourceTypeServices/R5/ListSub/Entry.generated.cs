
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ListSub
{
    public class Entry : BackboneElement<Entry>
    {

        #region Property
        [Element("flag", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Flag {get; set;}
[Element("deleted", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Deleted {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("item", typeof(Reference), false, false, false, false)]
public Reference Item {get; set;}

        #endregion
        #region Constructor
        public  Entry() { }
        public  Entry(string value) : base(value) { }
        public  Entry(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Entry";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
