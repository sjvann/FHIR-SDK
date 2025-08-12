using FhirCore.Interfaces;


namespace DataTypeServices.TypeFramework
{
    public class ValueSetBase<T> :IValueSet<T> where T :Enum
    {
        public ValueSetBase() { }


        public ValueSetBase(T? value)
        {
            Value = value;
        }

        public T? Value { get; init; }



 

        public string? ComputableName { get; set; }  
        public string? Version { get; set; } 
        public string? OfficialUrl { get; set; }

        public string[] GetEnum()
        {
            return (string[])typeof(T).GetEnumValues();
        }

        public T GetEnum(Func<T, string> func)
        {
            return GetValue(func.ToString() ?? string.Empty);
        }


        public T GetValue(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

    }
}