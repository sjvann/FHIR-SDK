using System.Collections.Generic;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
using System.Linq;
using System;

namespace ResourceMgr.Managed
{
    public class MRPatient : MRBased<Patient>
    {
        #region Constructor
        public MRPatient(List<Patient> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Template";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Patient current = GetCurrentResource();
            if (current != null)
            {
                if (current.Deceased != null)
                {
                    Deceased = new SubElement("deceased" , current.Deceased.TypeName, current.Deceased);
                }
                if (current.MultipleBirth != null)
                {
                    MultipleBirth = new SubElement("multipleBirth" , current.MultipleBirth.TypeName, current.MultipleBirth);
                }
                if (current.GeneralPractitioner != null && current.GeneralPractitioner.Any())
                {
                    foreach (var item in current.GeneralPractitioner)
                    {
                        if (item.IsContainedReference)
                        {
                            string _ref = item.Reference;
                            GeneralPractitioner.Add(new SubElement("generalPractitioner", _ref, _fs));
                        }
                    }
                }
                if (current.ManagingOrganization != null && current.ManagingOrganization.IsContainedReference)
                {

                    string _ref = current.ManagingOrganization.Reference;
                    ManagingOrganizaiton = new SubElement("managingOrganization", _ref, _fs);
                }
                if(current.Contact != null && current.Contact.Any())
                {
                    foreach(Patient.ContactComponent item in current.Contact)
                    {
                        
                        Contact.Add(new GroupElementContact(item, _fs));
                    }
                }
                if(current.Link != null && current.Link.Any())
                {
                    foreach(Patient.LinkComponent item in current.Link)
                    {
                        Link.Add(new GroupElementLink(item, _fs));
                    }
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Deceased { get; private set; }
        public SubElement MultipleBirth { get; private set; }
        public List<SubElement> GeneralPractitioner { get; private set; }
        public SubElement ManagingOrganizaiton { get; private set; }

        public List<GroupElementContact> Contact { get; private set; }
        public List<GroupElementLink> Link { get; private set; }
        #endregion
    }
}
