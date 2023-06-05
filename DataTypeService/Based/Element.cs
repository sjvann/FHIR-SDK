

using DataTypeService.Complex;

namespace DataTypeService.Based
{
    public abstract class Element : Base, IElement
    {
        private string? _Id;
        private List<Extension>? _Extensions;
        protected override string _TypeName => "Element";


        public string? Id
        {
            get { return _Id; }
            set { _Id = value; OnPropertyChanged("Id"); }
        }
        public List<Extension>? Extension
        {
            get { return _Extensions; }
            set { _Extensions = value; OnPropertyChanged("Extension"); }
        }
    }
}
