

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class SubstanceDefinition : DomainResource<SubstanceDefinition>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("classification", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classification {get; set;}
[Element("domain", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Domain {get; set;}
[Element("grade", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Grade {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("informationSource", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> InformationSource {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("manufacturer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Manufacturer {get; set;}
[Element("supplier", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Supplier {get; set;}
[Element("moiety", typeof(Moiety), false, true, false, true)]
public IEnumerable<Moiety> Moiety {get; set;}
[Element("characterization", typeof(Characterization), false, true, false, true)]
public IEnumerable<Characterization> Characterization {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("referenceInformation", typeof(Reference), false, false, false, false)]
public Reference ReferenceInformation {get; set;}
[Element("molecularWeight", typeof(MolecularWeight), false, true, false, true)]
public IEnumerable<MolecularWeight> MolecularWeight {get; set;}
[Element("structure", typeof(Structure), false, false, false, true)]
public Structure Structure {get; set;}
[Element("code", typeof(Code), false, true, false, true)]
public IEnumerable<Code> Code {get; set;}
[Element("name", typeof(Name), false, true, false, true)]
public IEnumerable<Name> Name {get; set;}
[Element("relationship", typeof(Relationship), false, true, false, true)]
public IEnumerable<Relationship> Relationship {get; set;}
[Element("nucleicAcid", typeof(Reference), false, false, false, false)]
public Reference NucleicAcid {get; set;}
[Element("polymer", typeof(Reference), false, false, false, false)]
public Reference Polymer {get; set;}
[Element("protein", typeof(Reference), false, false, false, false)]
public Reference Protein {get; set;}
[Element("sourceMaterial", typeof(SourceMaterial), false, false, false, true)]
public SourceMaterial SourceMaterial {get; set;}

        #endregion
        #region Constructor
        public  SubstanceDefinition() { }

        public  SubstanceDefinition(string value) : base(value) { }
        public  SubstanceDefinition(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubstanceDefinition";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
