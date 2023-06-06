using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRObservation : MRBased<Observation>
    {
        #region Constructor
        public MRObservation(List<Observation> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Observation";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Observation current = GetCurrentResource();
            if (current != null)
            {
               if(current.BasedOn != null && current.BasedOn.Count >0)
                {
                    foreach(var item in current.BasedOn.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        BasedOn.Add(new SubElement( "basedOn", _ref, _fs));
                    }    
                }
                if (current.PartOf != null && current.PartOf.Count > 0)
                {
                    foreach (var item in current.PartOf.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        PartOf.Add(new SubElement("partOf", _ref, _fs));
                    }
                }
                if (current.Focus != null && current.Focus.Count > 0)
                {
                    foreach (var item in current.Focus.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Focus.Add(new SubElement("focus", _ref, _fs));
                    }
                }
                if (current.Performer != null && current.Performer.Count > 0)
                {
                    foreach (var item in current.Performer.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Performer.Add(new SubElement("performer", _ref, _fs));
                    }
                }
                if (current.HasMember != null && current.HasMember.Count > 0)
                {
                    foreach (var item in current.HasMember.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        HasMember.Add(new SubElement("hasMember", _ref, _fs));
                    }
                }
                if (current.DerivedFrom != null && current.DerivedFrom.Count > 0)
                {
                    foreach (var item in current.DerivedFrom.Where(x => x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        DerivedFrom.Add(new SubElement("derivedFrom", _ref, _fs));
                    }
                }
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                        string _ref = current.Subject.Reference;
                       Subject = new SubElement("subject", _ref, _fs);
                }
                if (current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    string _ref = current.Encounter.Reference;
                    Encounter = new SubElement("encounter", _ref, _fs);
                }
                if (current.Specimen != null && current.Specimen.IsContainedReference)
                {
                    string _ref = current.Specimen.Reference;
                    Specimen = new SubElement("specimen", _ref, _fs);
                }
                if (current.Device != null && current.Device.IsContainedReference)
                {
                    string _ref = current.Device.Reference;
                    Device = new SubElement("device", _ref, _fs);
                }
                if(current.Effective != null)
                {
                    Effective = new SubElement("effective", current.Effective.TypeName, current.Effective);
                }
                if (current.Value != null)
                {
                    Value = new SubElement("value", current.Value.TypeName, current.Value);
                }
                if(current.Component != null && current.Component.Count> 0)
                {
                    foreach(var item in current.Component)
                    {
                        Component.Add(new GroupElementComponent(item, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> PartOf { get; private set; }
        public SubElement Subject { get; private set; }
        public List<SubElement> Focus { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Effective { get; private set; }
        public List<SubElement> Performer { get; private set; }
        public SubElement Value { get; private set; }
        public SubElement Specimen { get; private set; }
        public SubElement Device { get; private set; }
        public List<SubElement> HasMember { get; private set; }
        public List<SubElement> DerivedFrom { get; private set; }
        public List<GroupElementComponent> Component { get; private set; }

        #endregion
    }
}
