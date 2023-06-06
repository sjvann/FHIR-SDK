using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRTemplate:MRBased<Template>
    {
        #region Constructor
        public MRTemplate(List<Template> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Template";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Template current = GetCurrentResource();
            if (current != null)
            {
                //TODO: Write check subelement
            }
        }
        #endregion
        #region SubElement
        /*
         *  public SubElement [FieldName] { get; } 
         *  public List<SubElement> [FieldName] { get; } 
         *  public GroupElementXXXX [FieldName] {get;}
         *  public List<GroupElementXXXX> [FieldName] {get;}
         */
        #endregion
    }
}
