
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.PermissionSub.RuleSub.DataSub;

namespace ResourceTypeServices.R5.PermissionSub.RuleSub
{
    public class Data : BackboneElement<Data>
    {

        #region Property
        [Element("resource", typeof(Resource), false, true, false, true)]
public IEnumerable<Resource> Resource {get; set;}
[Element("security", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Security {get; set;}
[Element("period", typeof(Period), false, true, false, false)]
public IEnumerable<Period> Period {get; set;}
[Element("expression", typeof(Expression), false, false, false, false)]
public Expression Expression {get; set;}

        #endregion
        #region Constructor
        public  Data() { }
        public  Data(string value) : base(value) { }
        public  Data(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Data";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
