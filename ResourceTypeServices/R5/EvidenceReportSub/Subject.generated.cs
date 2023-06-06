
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.EvidenceReportSub.SubjectSub;

namespace ResourceTypeServices.R5.EvidenceReportSub
{
    public class Subject : BackboneElement<Subject>
    {

        #region Property
        [Element("characteristic", typeof(Characteristic), false, true, false, true)]
public IEnumerable<Characteristic> Characteristic {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}

        #endregion
        #region Constructor
        public  Subject() { }
        public  Subject(string value) : base(value) { }
        public  Subject(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Subject";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
