using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRAccount :MRBased<Account >
    {
        #region Constructor
        public MRAccount(List<Account > resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Account ";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Account  current = GetCurrentResource();
            if (current != null)
            {
                if(current.Subject != null && current.Subject.Any())
                {
                    List<SubElement> tmp = new();
                    foreach(var item in current.Subject.Where(x=>x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("subject", item.Reference, _fs));
                    }
                    Subject = tmp;
                }
                if(current.Owner != null && current.Owner.IsContainedReference)
                {
                    Owner = new SubElement("owner", current.Owner.Reference, _fs);
                }
                if (current.PartOf != null && current.PartOf.IsContainedReference)
                {
                    PartOf = new SubElement("owner", current.PartOf.Reference, _fs);
                }
                if(current.Coverage != null && current.Coverage.Any())
                {
                    List<GroupElementCoverage> tmp = new();
                    foreach(var item in current.Coverage)
                    {
                        tmp.Add(new GroupElementCoverage(item, _fs));
                    }
                    Coverage = tmp;
                }
                if (current.Guarantor != null && current.Guarantor.Any())
                {
                    List<GroupElementGuarantor> tmp = new();
                    foreach (var item in current.Guarantor)
                    {
                        tmp.Add(new GroupElementGuarantor(item, _fs));
                    }
                    Guarantor = tmp;
                }
            }
        }
        #endregion
        #region SubElement
        public List<SubElement> Subject { get; private set; } 
        public SubElement Owner { get; private set;} 
        public SubElement PartOf { get; private set;} 
        public List<GroupElementCoverage> Coverage { get; private set;}
        public List<GroupElementGuarantor> Guarantor { get;private set; }
        #endregion
    }
}
