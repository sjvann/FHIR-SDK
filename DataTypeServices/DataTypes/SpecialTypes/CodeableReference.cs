using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.TypeFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    public class CodeableReference:ComplexType<CodeableReference>
    {
        private CodeableConcept? _concept;
        private ReferenceType? _reference;
        public CodeableConcept? Concept
        {
            get { return _concept; }
            set
            {
                _concept = value;
                OnPropertyChanged("concept", value);
            }
        }
        public ReferenceType? Reference
        {
            get { return _reference; }
            set
            {
                _reference = value;
                OnPropertyChanged("reference", value);
            }
        }

        public CodeableReference() : base() { }
        public CodeableReference(JsonObject value) : base(value) { }
        public CodeableReference(string value) : base(value) { }
    }
}
