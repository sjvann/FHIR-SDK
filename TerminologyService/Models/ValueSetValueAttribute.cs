

namespace TerminologyService.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ValueSetValueAttribute : Attribute
    {
        private readonly string? _code;
        private readonly string? _system;
        private readonly string? _display;

        public ValueSetValueAttribute(string code, string system, string display)
        {
            _code = code;
            _system = system;
            _display = display;
        }

        public string? Code => _code;
        public string? System => _system;
        public string? Display => _display;

    }
}
