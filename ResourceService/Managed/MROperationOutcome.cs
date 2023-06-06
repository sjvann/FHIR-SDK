using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MROperationOutcome:MRBased<OperationOutcome>
    {
        #region Constructor
        public MROperationOutcome(List<OperationOutcome> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "OperationOutcome";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
         
        }
        #endregion
        #region SubElement

        #endregion
    }
}
