

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BiologicallyDerivedProductDispenseSub
{
    public class BiologicallyDerivedProductDispense : DomainResource<BiologicallyDerivedProductDispense>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("originRelationshipType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept OriginRelationshipType {get; set;}
[Element("product", typeof(Reference), false, false, false, false)]
public Reference Product {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("matchStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept MatchStatus {get; set;}
[Element("performer", typeof(Performer), false, true, false, true)]
public IEnumerable<Performer> Performer {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("preparedDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime PreparedDate {get; set;}
[Element("whenHandedOver", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime WhenHandedOver {get; set;}
[Element("destination", typeof(Reference), false, false, false, false)]
public Reference Destination {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("usageInstruction", typeof(FhirString), true, false, false, false)]
public FhirString UsageInstruction {get; set;}

        #endregion
        #region Constructor
        public  BiologicallyDerivedProductDispense() { }

        public  BiologicallyDerivedProductDispense(string value) : base(value) { }
        public  BiologicallyDerivedProductDispense(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "BiologicallyDerivedProductDispense";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
