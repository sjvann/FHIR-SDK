
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.ConsentSub.ProvisionSub;

namespace ResourceTypeServices.R5.ConsentSub
{
    public class Provision : BackboneElement<Provision>
    {

        #region Property
        [Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("actor", typeof(Actor), false, true, false, true)]
public IEnumerable<Actor> Actor {get; set;}
[Element("action", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Action {get; set;}
[Element("securityLabel", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> SecurityLabel {get; set;}
[Element("purpose", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> Purpose {get; set;}
[Element("documentType", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> DocumentType {get; set;}
[Element("resourceType", typeof(Coding), false, true, false, false)]
public IEnumerable<Coding> ResourceType {get; set;}
[Element("code", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Code {get; set;}
[Element("dataPeriod", typeof(Period), false, false, false, false)]
public Period DataPeriod {get; set;}
[Element("data", typeof(Data), false, true, false, true)]
public IEnumerable<Data> Data {get; set;}
[Element("expression", typeof(Expression), false, false, false, false)]
public Expression Expression {get; set;}

        #endregion
        #region Constructor
        public  Provision() { }
        public  Provision(string value) : base(value) { }
        public  Provision(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Provision";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
