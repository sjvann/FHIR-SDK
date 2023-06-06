
using Hl7.Fhir.Model;
using System;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class SubElement : ISubElement
    {
        private readonly string _elementName;
        private readonly FHIRDefinedType _elementType;
        private readonly IFhirServer _fs;
        private readonly bool _isResource = false;
        private readonly DataType _dataSource;
        private readonly string _refFullUrl;
        public SubElement(string elementName, string refUrl, IFhirServer fhirServer, bool isFullUrl = false, string elementType = null)
        {
            _elementName = elementName;
            _elementType =Enum.Parse<FHIRDefinedType>(isFullUrl?elementType: refUrl.Split('/').First());
            _refFullUrl = isFullUrl? _refFullUrl: $"{fhirServer.GetBasedUrl()}/{refUrl}";
            _fs = fhirServer;
            _isResource = true;
        }
        public SubElement(string elementName, string elementType, DataType source)
        {
            _elementName = elementName + elementType;
            _elementType = Enum.Parse<FHIRDefinedType>(elementType);
            _dataSource = source;
            _fs = null;

        }
        public SubElement(string elementName, string elementType, string fullUrl)
        {
            _elementName = elementName;
            _elementType = Enum.Parse<FHIRDefinedType>(elementType);
            _refFullUrl = fullUrl;
            _isResource = true;

        }

        public string ElementName => _elementName;

        public bool CheckElement(FHIRDefinedType checker)
        {

            return CheckResource(checker, _elementType);
        }



        public T GetDataType<T>() where T : DataType
        {
            if (CheckResource(typeof(T).Name, _elementType) && _dataSource != null)
            {
                return (T)_dataSource;
            }
            else
            {
                return null;
            }
        }
        public T GetResourc<T>() where T : Resource
        {
            if (CheckResource(typeof(T).Name, _elementType) && _isResource && _fs != null)
            {
                var rm = new ResourceManager(_fs);
                return rm.ReferenceService<T>(_refFullUrl, true);
            }
            else
            {
                return null;
            }
        }

        #region Private Method
        private static bool CheckResource(FHIRDefinedType checker, FHIRDefinedType elementType)
        {
            return checker == elementType;
        }
        private static bool CheckResource(string checker, FHIRDefinedType elementType)
        {
            return checker == elementType.ToString();
        }
        #endregion
    }
}
