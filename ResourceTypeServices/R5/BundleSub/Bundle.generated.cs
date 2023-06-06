

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BundleSub
{
    public class Bundle : DomainResource<Bundle>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("timestamp", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Timestamp {get; set;}
[Element("total", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Total {get; set;}
[Element("link", typeof(Link), false, true, false, true)]
public IEnumerable<Link> Link {get; set;}
[Element("entry", typeof(Entry), false, true, false, true)]
public IEnumerable<Entry> Entry {get; set;}
[Element("signature", typeof(Signature), false, false, false, false)]
public Signature Signature {get; set;}
[Element("issues", typeof(Resource), false, false, false, false)]
public Resource Issues {get; set;}

        #endregion
        #region Constructor
        public  Bundle() { }

        public  Bundle(string value) : base(value) { }
        public  Bundle(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Bundle";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
