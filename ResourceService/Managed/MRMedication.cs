using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRMedication:MRBased<Medication>
    {
        #region Constructor
        public MRMedication(List<Medication> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Medication";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Medication current = GetCurrentResource();
            if (current != null)
            {
                if(current.Manufacturer != null && current.Manufacturer.IsContainedReference)
                {
                    Manufacturer = new SubElement("manufacturer", current.Manufacturer.Reference, _fs);
                }
                if(current.Ingredient != null && current.Ingredient.Any())
                {
                    List<GroupElementIngredient> temp = new();
                    foreach(var item in current.Ingredient)
                    {
                        temp.Add(new GroupElementIngredient(item, _fs));
                    }
                    Ingredient = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Manufacturer { get; private set; }
        public List<GroupElementIngredient> Ingredient { get; private set; }
        #endregion
    }
}
