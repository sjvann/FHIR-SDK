using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementIngredient
    {

        public GroupElementIngredient(Medication.IngredientComponent source, IFhirServer fs)
        {
            if (source != null && source.Item != null)
            {
                if(source.Item.TypeName == FHIRDefinedType.Reference.ToString())
                {
                    ResourceReference temp = source.Item as ResourceReference;
                    Item = new SubElement("itemReference", temp.Reference, fs);
                }
                else
                {
                    Item = new SubElement("item", source.Item.TypeName, source.Item);
                }
            }

        }

        public SubElement Item { get; private set; }
    }
}
