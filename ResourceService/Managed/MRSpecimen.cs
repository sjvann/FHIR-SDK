using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRSpecimen : MRBased<Specimen>
    {
        #region Constructor
        public MRSpecimen(List<Specimen> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Specimen";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Specimen current = GetCurrentResource();
            if (current != null)
            {
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
                if (current.Parent != null && current.Parent.Count > 0)
                {
                    foreach (var item in current.Parent.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Parent.Add(new SubElement("parent", _ref, _fs));

                    }
                }
                if (current.Request != null && current.Request.Count > 0)
                {
                    foreach (var item in current.Request.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Request.Add(new SubElement("request", _ref, _fs));

                    }
                }
                if(current.Collection != null)
                {
                    Collection = new GroupElementCollection(current.Collection, _fs);
                }
                if(current.Processing != null && current.Processing.Count > 0)
                {
                    foreach(var item in current.Processing)
                    {
                        Processing.Add(new GroupElementProcessing(item, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public List<SubElement> Parent { get; private set; }
        public List<SubElement> Request { get; private set; }
        public GroupElementCollection Collection { get; private set; }
        public List<GroupElementProcessing> Processing { get; private set; }
        public List<GroupElementContainer> Container { get; private set; }

        #endregion
    }
}
