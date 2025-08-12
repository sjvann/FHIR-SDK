namespace FhirCore.Interfaces
{
    public interface IValueSet<out T> where T : Enum
    {
        T GetValue(string value);
        public T GetEnum(Func<T, string> func);

    }
}
