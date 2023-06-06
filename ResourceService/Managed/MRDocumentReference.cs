using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRDocumentReference : MRBased<DocumentReference>
    {
        #region Constructor
        public MRDocumentReference(List<DocumentReference> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "DocumentReference";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            DocumentReference current = GetCurrentResource();
            if (current != null)
            {
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if (current.Author != null && current.Author.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Author.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("author", item.Reference, _fs));
                    }
                    Author = temp;
                }
                if(current.Authenticator != null && current.Authenticator.IsContainedReference)
                {
                    Authenticator = new SubElement("authenticator", current.Authenticator.Reference, _fs);
                }
                if (current.Custodian != null && current.Custodian.IsContainedReference)
                {
                    Custodian = new SubElement("custodian", current.Custodian.Reference, _fs);
                }
                if(current.RelatesTo != null && current.RelatesTo.Any())
                {
                    List<GroupElementRelatesTo> temp = new();
                    foreach(var item in current.RelatesTo)
                    {
                        temp.Add(new GroupElementRelatesTo(item, _fs));
                    }
                    RelatesTo = temp;
                }
                if(current.Context != null)
                {
                    Context = new GroupElementContext(current.Context, _fs);
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public List<SubElement> Author { get; private set; }
        public SubElement Authenticator { get; private set; }
        public SubElement Custodian { get; private set; }
        public List<GroupElementRelatesTo> RelatesTo { get; private set; }
        public GroupElementContext Context { get; private set; }

        #endregion
    }
}
