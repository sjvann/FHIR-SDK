
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CitationSub.CitedArtifactSub.PublicationFormSub;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class PublicationForm : BackboneElement<PublicationForm>
    {

        #region Property
        [Element("publishedIn", typeof(PublishedIn), false, false, false, true)]
public PublishedIn PublishedIn {get; set;}
[Element("citedMedium", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CitedMedium {get; set;}
[Element("volume", typeof(FhirString), true, false, false, false)]
public FhirString Volume {get; set;}
[Element("issue", typeof(FhirString), true, false, false, false)]
public FhirString Issue {get; set;}
[Element("articleDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime ArticleDate {get; set;}
[Element("publicationDateText", typeof(FhirString), true, false, false, false)]
public FhirString PublicationDateText {get; set;}
[Element("publicationDateSeason", typeof(FhirString), true, false, false, false)]
public FhirString PublicationDateSeason {get; set;}
[Element("lastRevisionDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime LastRevisionDate {get; set;}
[Element("language", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Language {get; set;}
[Element("accessionNumber", typeof(FhirString), true, false, false, false)]
public FhirString AccessionNumber {get; set;}
[Element("pageString", typeof(FhirString), true, false, false, false)]
public FhirString PageString {get; set;}
[Element("firstPage", typeof(FhirString), true, false, false, false)]
public FhirString FirstPage {get; set;}
[Element("lastPage", typeof(FhirString), true, false, false, false)]
public FhirString LastPage {get; set;}
[Element("pageCount", typeof(FhirString), true, false, false, false)]
public FhirString PageCount {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}

        #endregion
        #region Constructor
        public  PublicationForm() { }
        public  PublicationForm(string value) : base(value) { }
        public  PublicationForm(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PublicationForm";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
