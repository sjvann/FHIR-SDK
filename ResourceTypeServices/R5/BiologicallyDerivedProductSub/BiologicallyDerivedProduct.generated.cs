

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.BiologicallyDerivedProductSub
{
    public class BiologicallyDerivedProduct : DomainResource<BiologicallyDerivedProduct>
    {
        #region Property
        [Element("productCategory", typeof(Coding), false, false, false, false)]
public Coding ProductCategory {get; set;}
[Element("productCode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ProductCode {get; set;}
[Element("parent", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Parent {get; set;}
[Element("request", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Request {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("biologicalSourceEvent", typeof(Identifier), false, false, false, false)]
public Identifier BiologicalSourceEvent {get; set;}
[Element("processingFacility", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ProcessingFacility {get; set;}
[Element("division", typeof(FhirString), true, false, false, false)]
public FhirString Division {get; set;}
[Element("productStatus", typeof(Coding), false, false, false, false)]
public Coding ProductStatus {get; set;}
[Element("expirationDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ExpirationDate {get; set;}
[Element("collection", typeof(Collection), false, false, false, true)]
public Collection Collection {get; set;}
[Element("storageTempRequirements", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range StorageTempRequirements {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}

        #endregion
        #region Constructor
        public  BiologicallyDerivedProduct() { }

        public  BiologicallyDerivedProduct(string value) : base(value) { }
        public  BiologicallyDerivedProduct(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "BiologicallyDerivedProduct";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
