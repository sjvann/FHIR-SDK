using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Distance - A length - a value with a unit that is a physical distance.
    /// This is a specialization of Quantity that represents a distance.
    /// </summary>
    public class Distance : Quantity
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Distance() : base() { }

        /// <summary>
        /// Constructor from JSON object
        /// </summary>
        /// <param name="value">JSON object representing the Distance</param>
        public Distance(JsonObject value) : base(value) { }

        /// <summary>
        /// Constructor from JSON string
        /// </summary>
        /// <param name="value">JSON string representing the Distance</param>
        public Distance(string value) : base(value) { }

        /// <summary>
        /// Constructor with value and unit
        /// </summary>
        /// <param name="value">The distance value</param>
        /// <param name="unit">The unit of distance (e.g., "m", "km", "ft", "mi")</param>
        public Distance(decimal value, string unit) : base()
        {
            Value = new FhirDecimal(value);
            Unit = new FhirString(unit);
            System = new FhirUri("http://unitsofmeasure.org");
            
            // Set appropriate UCUM code based on unit
            Code = new FhirCode(GetUcumCodeForUnit(unit));
        }

        /// <summary>
        /// Constructor with value, unit, and system
        /// </summary>
        /// <param name="value">The distance value</param>
        /// <param name="unit">The unit of distance</param>
        /// <param name="system">The system URI</param>
        /// <param name="code">The code for the unit</param>
        public Distance(decimal value, string unit, string system, string code) : base()
        {
            Value = new FhirDecimal(value);
            Unit = new FhirString(unit);
            System = new FhirUri(system);
            Code = new FhirCode(code);
        }

        /// <summary>
        /// Get FHIR type name
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter</param>
        /// <returns>The FHIR type name</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Distance" : "distance";

        /// <summary>
        /// Get the appropriate UCUM code for common distance units
        /// </summary>
        /// <param name="unit">The unit string</param>
        /// <returns>The UCUM code</returns>
        private static string GetUcumCodeForUnit(string unit)
        {
            return unit.ToLowerInvariant() switch
            {
                // Metric units
                "meters" or "meter" or "metres" or "metre" or "m" => "m",
                "kilometers" or "kilometer" or "kilometres" or "kilometre" or "km" => "km",
                "centimeters" or "centimeter" or "centimetres" or "centimetre" or "cm" => "cm",
                "millimeters" or "millimeter" or "millimetres" or "millimetre" or "mm" => "mm",
                "micrometers" or "micrometer" or "micrometres" or "micrometre" or "μm" or "um" => "um",
                "nanometers" or "nanometer" or "nanometres" or "nanometre" or "nm" => "nm",
                
                // Imperial units
                "feet" or "foot" or "ft" => "[ft_i]",
                "inches" or "inch" or "in" => "[in_i]",
                "yards" or "yard" or "yd" => "[yd_i]",
                "miles" or "mile" or "mi" => "[mi_i]",
                
                // Nautical
                "nautical miles" or "nautical mile" or "nmi" => "[nmi_i]",
                
                // Other
                "angstroms" or "angstrom" or "Å" => "Ao",
                "light years" or "light year" or "ly" => "[ly]",
                "parsecs" or "parsec" or "pc" => "[pc]",
                "astronomical units" or "astronomical unit" or "au" => "[AU]",
                
                _ => unit
            };
        }

        /// <summary>
        /// Create a Distance representing meters
        /// </summary>
        /// <param name="meters">Number of meters</param>
        /// <returns>Distance instance</returns>
        public static Distance Meters(decimal meters)
        {
            return new Distance(meters, "meters");
        }

        /// <summary>
        /// Create a Distance representing kilometers
        /// </summary>
        /// <param name="kilometers">Number of kilometers</param>
        /// <returns>Distance instance</returns>
        public static Distance Kilometers(decimal kilometers)
        {
            return new Distance(kilometers, "kilometers");
        }

        /// <summary>
        /// Create a Distance representing centimeters
        /// </summary>
        /// <param name="centimeters">Number of centimeters</param>
        /// <returns>Distance instance</returns>
        public static Distance Centimeters(decimal centimeters)
        {
            return new Distance(centimeters, "centimeters");
        }

        /// <summary>
        /// Create a Distance representing millimeters
        /// </summary>
        /// <param name="millimeters">Number of millimeters</param>
        /// <returns>Distance instance</returns>
        public static Distance Millimeters(decimal millimeters)
        {
            return new Distance(millimeters, "millimeters");
        }

        /// <summary>
        /// Create a Distance representing feet
        /// </summary>
        /// <param name="feet">Number of feet</param>
        /// <returns>Distance instance</returns>
        public static Distance Feet(decimal feet)
        {
            return new Distance(feet, "feet");
        }

        /// <summary>
        /// Create a Distance representing inches
        /// </summary>
        /// <param name="inches">Number of inches</param>
        /// <returns>Distance instance</returns>
        public static Distance Inches(decimal inches)
        {
            return new Distance(inches, "inches");
        }

        /// <summary>
        /// Create a Distance representing miles
        /// </summary>
        /// <param name="miles">Number of miles</param>
        /// <returns>Distance instance</returns>
        public static Distance Miles(decimal miles)
        {
            return new Distance(miles, "miles");
        }

        /// <summary>
        /// Validate that this Distance has appropriate constraints
        /// </summary>
        /// <returns>True if valid, false otherwise</returns>
        public bool IsValidDistance()
        {
            // Distance should typically have a non-negative value
            if (Value?.Value < 0)
                return false;

            // Distance should use length-based units
            var code = Code?.Value?.ToLowerInvariant();
            var validDistanceCodes = new[]
            {
                "m", "km", "cm", "mm", "um", "nm", // Metric
                "[ft_i]", "[in_i]", "[yd_i]", "[mi_i]", // Imperial
                "[nmi_i]", // Nautical
                "ao", "[ly]", "[pc]", "[au]" // Astronomical
            };

            if (!string.IsNullOrEmpty(code) && !validDistanceCodes.Contains(code))
                return false;

            return true;
        }

        /// <summary>
        /// Convert this distance to meters (approximate conversion)
        /// </summary>
        /// <returns>Distance in meters, or null if conversion is not possible</returns>
        public Distance? ToMeters()
        {
            if (Value?.Value == null || Code?.Value == null)
                return null;

            var valueInMeters = Code.Value.ToLowerInvariant() switch
            {
                "m" => Value.Value,
                "km" => Value.Value * 1000m,
                "cm" => Value.Value / 100m,
                "mm" => Value.Value / 1000m,
                "um" => Value.Value / 1000000m,
                "nm" => Value.Value / 1000000000m,
                "[ft_i]" => Value.Value * 0.3048m,
                "[in_i]" => Value.Value * 0.0254m,
                "[yd_i]" => Value.Value * 0.9144m,
                "[mi_i]" => Value.Value * 1609.344m,
                "[nmi_i]" => Value.Value * 1852m,
                _ => null
            };

            return valueInMeters.HasValue ? new Distance(valueInMeters.Value, "meters") : null;
        }
    }
}
