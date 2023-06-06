

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PermissionSub
{
    public class Permission : DomainResource<Permission>
    {
        #region Property
        [Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("asserter", typeof(Reference), false, false, false, false)]
public Reference Asserter {get; set;}
[Element("date", typeof(FhirDateTime), true, true, false, false)]
public IEnumerable<FhirDateTime> Date {get; set;}
[Element("validity", typeof(Period), false, false, false, false)]
public Period Validity {get; set;}
[Element("justification", typeof(Justification), false, false, false, true)]
public Justification Justification {get; set;}
[Element("combining", typeof(FhirCode), true, false, false, false)]
public FhirCode Combining {get; set;}
[Element("rule", typeof(Rule), false, true, false, true)]
public IEnumerable<Rule> Rule {get; set;}

        #endregion
        #region Constructor
        public  Permission() { }

        public  Permission(string value) : base(value) { }
        public  Permission(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Permission";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
