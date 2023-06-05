using Core.Extension;
using DataTypeService.Based;
using DataTypeService.BaseTypes;
using DataTypeService.Choice;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class ParameterDefinition : ComplexType
    {

        #region Property
        public FhirCode? Name { get; set; }
        public FhirCode? Use { get; set; }
        public FhirInteger? Min { get; set; }
        public FhirString? Max { get; set; }
        public FhirString? Documentation { get; set; }
        public FhirCode? Type { get; set; }
        public FhirCanonical? Profile { get; set; }

        #endregion
        #region Constructor
        public ParameterDefinition() { }
        public ParameterDefinition(string? value) : this(value.Parse()) { }
        public ParameterDefinition(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "name": Name = new(cv); break;
                        case "use": Use = new(cv); break;
                        case "min": Min = new(cv); break;
                        case "max": Max = new(cv); break;
                        case "documentation": Documentation = new(cv); break;
                        case "type": Type = new(cv); break;
                        case "profile": Profile = new(cv); break;
                        case "_name":
                            if (Name is FhirCode _name) SetupExtension(cv, ref _name);
                            break;
                        case "_use":
                            if (Use is FhirCode _use) SetupExtension(cv, ref _use);
                            break;
                        case "_min":
                            if (Min is FhirInteger _min) SetupExtension(cv, ref _min);
                            break;
                        case "_max":
                            if (Max is FhirString _max) SetupExtension(cv, ref _max);
                            break;
                        case "_documentation":
                            if (Documentation is FhirString _documentation) SetupExtension(cv, ref _documentation);
                            break;
                        case "_type":
                            if (Type is FhirCode _type) SetupExtension(cv, ref _type);
                            break;
                        case "_profile":
                            if (Profile is FhirCanonical _profile) SetupExtension(cv, ref _profile);
                            break;
                    }
                }

            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ParameterDefinition ";
        #endregion

        #region Public Method


        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
