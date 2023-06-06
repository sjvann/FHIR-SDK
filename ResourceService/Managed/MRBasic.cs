using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;

namespace ResourceMgr.Managed
{
    public class MRBasic : MRBased<Basic>
    {
         #region Constructure
        public MRBasic(List<Basic> resources, IFhirServer fs) : base(resources,fs)
        {
            _resourceName = "Basic";
        }

        #endregion


        public override void SetupSubElement()
        {
            Basic current = GetCurrentResource();
            if(current != null)
            {
               if(current.Author != null && current.Author.IsContainedReference)
                {
                    string _ref = current.Author.Reference;
                    Author = new SubElement("author", _ref, _fs);
                }
               if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subjet = new SubElement("subject", _ref, _fs);
                }
            }
           
        }
        public SubElement Subjet { get; private set; }
        public SubElement Author { get; private set; }
    }


   
}
