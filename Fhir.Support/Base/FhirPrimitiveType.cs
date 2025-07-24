namespace Fhir.Support.Base
{
    /// <summary>
    /// An abstract base class for all FHIR primitive types (e.g., FhirString, FhirBoolean).
    /// It provides a common structure holding the value of the primitive.
    /// </summary>
    /// <typeparam name="T">The underlying .NET type of the primitive value.</typeparam>
    public abstract class FhirPrimitiveType<T>
    {
        /// <summary>
        /// Gets or sets the value of the primitive type.
        /// </summary>
        public T? Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPrimitiveType{T}"/> class.
        /// </summary>
        protected FhirPrimitiveType() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPrimitiveType{T}"/> class with a specified value.
        /// </summary>
        /// <param name="value">The initial value.</param>
        protected FhirPrimitiveType(T? value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns a string that represents the current object's value.
        /// </summary>
        public override string? ToString() => Value?.ToString();
    }
} 