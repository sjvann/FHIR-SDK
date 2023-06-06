
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImagingStudySub.SeriesSub
{
    public class Instance : BackboneElement<Instance>
    {

        #region Property
        [Element("uid", typeof(FhirId), true, false, false, false)]
public FhirId Uid {get; set;}
[Element("sopClass", typeof(Coding), false, false, false, false)]
public Coding SopClass {get; set;}
[Element("number", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Number {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}

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
