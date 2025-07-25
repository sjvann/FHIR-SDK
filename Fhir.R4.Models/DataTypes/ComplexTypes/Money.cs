using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// An amount of economic utility in some recognized currency.
/// </summary>
/// <remarks>
/// FHIR R4 Money DataType
/// An amount of economic utility in some recognized currency.
/// </remarks>
public class Money : DataType
{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// FHIR Path: Money.value
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
    
    /// <summary>
    /// ISO 4217 Currency Code.
    /// FHIR Path: Money.currency
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the Money class.
    /// </summary>
    public Money() { }

    /// <summary>
    /// Initializes a new instance of the Money class with a value and optional currency.
    /// </summary>
    /// <param name="value">The monetary value.</param>
    /// <param name="currency">The ISO 4217 currency code (optional).</param>
    public Money(decimal? value, string? currency = null)
    {
        Value = value;
        Currency = currency;
    }
    
    /// <summary>
    /// Implicitly converts a decimal value to a Money instance.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A Money instance with the specified value, or null if the value is null.</returns>
    public static implicit operator Money?(decimal? value)
    {
        return value == null ? null : new Money(value);
    }

    /// <summary>
    /// Implicitly converts a Money instance to its decimal value.
    /// </summary>
    /// <param name="money">The Money instance to convert.</param>
    /// <returns>The decimal value of the Money, or null if the Money is null.</returns>
    public static implicit operator decimal?(Money? money)
    {
        return money?.Value;
    }
    
    /// <summary>
    /// Validates the Money according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證 currency 格式（ISO 4217）
        if (!string.IsNullOrEmpty(Currency))
        {
            if (Currency.Length != 3 || !Currency.All(char.IsLetter))
            {
                yield return new ValidationResult($"Money.currency '{Currency}' is not valid. Must be a 3-letter ISO 4217 currency code");
            }
            else if (!IsValidCurrencyCode(Currency))
            {
                yield return new ValidationResult($"Money.currency '{Currency}' is not a recognized ISO 4217 currency code");
            }
        }
        
        // 驗證 value 精度（通常貨幣不超過 4 位小數）
        if (Value.HasValue)
        {
            var decimalPlaces = GetDecimalPlaces(Value.Value);
            if (decimalPlaces > 4)
            {
                yield return new ValidationResult("Money.value should not have more than 4 decimal places");
            }
        }
    }
    
    /// <summary>
    /// Validates whether the specified currency code is a valid ISO 4217 currency code (simplified version).
    /// </summary>
    /// <param name="currency">The currency code to validate.</param>
    /// <returns>True if the currency code is valid; otherwise, false.</returns>
    private bool IsValidCurrencyCode(string currency)
    {
        // 常見的 ISO 4217 貨幣代碼
        var validCurrencies = new HashSet<string>
        {
            "USD", "EUR", "GBP", "JPY", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD",
            "MXN", "SGD", "HKD", "NOK", "TRY", "ZAR", "BRL", "INR", "KRW", "PLN",
            "TWD", "THB", "MYR", "PHP", "IDR", "VND", "CZK", "HUF", "ILS", "CLP",
            "PEN", "COP", "ARS", "UYU", "BOB", "PYG", "VEF", "GYD", "SRD", "TTD",
            "JMD", "BBD", "BZD", "GTQ", "HNL", "NIO", "CRC", "PAB", "DOP", "HTG",
            "CUP", "XCD", "AWG", "ANG", "SVC", "BSD", "KYD", "BMD"
        };
        
        return validCurrencies.Contains(currency.ToUpperInvariant());
    }
    
    /// <summary>
    /// Calculates the number of decimal places in a decimal value.
    /// </summary>
    /// <param name="value">The decimal value to analyze.</param>
    /// <returns>The number of decimal places.</returns>
    private int GetDecimalPlaces(decimal value)
    {
        var text = value.ToString();
        var decimalIndex = text.IndexOf('.');
        return decimalIndex == -1 ? 0 : text.Length - decimalIndex - 1;
    }
    
    /// <summary>
    /// Returns a string representation of the Money value.
    /// </summary>
    /// <returns>A formatted string representation of the monetary value and currency.</returns>
    public override string ToString()
    {
        if (!Value.HasValue)
            return string.Empty;
            
        if (string.IsNullOrEmpty(Currency))
            return Value.Value.ToString("F2");
            
        return $"{Value.Value:F2} {Currency}";
    }
    
    /// <summary>
    /// Determines whether the specified object is equal to the current Money instance.
    /// </summary>
    /// <param name="obj">The object to compare with the current instance.</param>
    /// <returns>True if the specified object is equal to the current instance; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is not Money other)
            return false;
            
        return Value == other.Value && 
               string.Equals(Currency, other.Currency, StringComparison.OrdinalIgnoreCase);
    }
    
    /// <summary>
    /// Returns the hash code for this Money instance.
    /// </summary>
    /// <returns>A hash code for the current instance.</returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Currency?.ToUpperInvariant());
    }
    
    /// <summary>
    /// Adds two Money instances together.
    /// </summary>
    /// <param name="left">The first Money instance.</param>
    /// <param name="right">The second Money instance.</param>
    /// <returns>A new Money instance representing the sum, or null if either operand is null.</returns>
    /// <exception cref="InvalidOperationException">Thrown when attempting to add money with different currencies.</exception>
    public static Money? operator +(Money? left, Money? right)
    {
        if (left == null || right == null)
            return null;
            
        if (!string.Equals(left.Currency, right.Currency, StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Cannot add money with different currencies");
            
        return new Money(
            (left.Value ?? 0) + (right.Value ?? 0),
            left.Currency ?? right.Currency
        );
    }
    
    /// <summary>
    /// Subtracts one Money instance from another.
    /// </summary>
    /// <param name="left">The Money instance to subtract from.</param>
    /// <param name="right">The Money instance to subtract.</param>
    /// <returns>A new Money instance representing the difference, or null if either operand is null.</returns>
    /// <exception cref="InvalidOperationException">Thrown when attempting to subtract money with different currencies.</exception>
    public static Money? operator -(Money? left, Money? right)
    {
        if (left == null || right == null)
            return null;
            
        if (!string.Equals(left.Currency, right.Currency, StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("Cannot subtract money with different currencies");
            
        return new Money(
            (left.Value ?? 0) - (right.Value ?? 0),
            left.Currency ?? right.Currency
        );
    }
    
    /// <summary>
    /// Multiplies a Money instance by a decimal multiplier.
    /// </summary>
    /// <param name="money">The Money instance to multiply.</param>
    /// <param name="multiplier">The decimal multiplier.</param>
    /// <returns>A new Money instance representing the product, or null if the money is null.</returns>
    public static Money? operator *(Money? money, decimal multiplier)
    {
        if (money == null)
            return null;
            
        return new Money(
            (money.Value ?? 0) * multiplier,
            money.Currency
        );
    }
    
    /// <summary>
    /// Divides a Money instance by a decimal divisor.
    /// </summary>
    /// <param name="money">The Money instance to divide.</param>
    /// <param name="divisor">The decimal divisor.</param>
    /// <returns>A new Money instance representing the quotient, or null if the money is null or divisor is zero.</returns>
    public static Money? operator /(Money? money, decimal divisor)
    {
        if (money == null || divisor == 0)
            return null;
            
        return new Money(
            (money.Value ?? 0) / divisor,
            money.Currency
        );
    }
    
    /// <summary>
    /// Determines whether two Money instances are equal.
    /// </summary>
    /// <param name="left">The first Money instance to compare.</param>
    /// <param name="right">The second Money instance to compare.</param>
    /// <returns>True if the instances are equal; otherwise, false.</returns>
    public static bool operator ==(Money? left, Money? right)
    {
        if (ReferenceEquals(left, right))
            return true;
            
        if (left is null || right is null)
            return false;
            
        return left.Equals(right);
    }
    
    /// <summary>
    /// Determines whether two Money instances are not equal.
    /// </summary>
    /// <param name="left">The first Money instance to compare.</param>
    /// <param name="right">The second Money instance to compare.</param>
    /// <returns>True if the instances are not equal; otherwise, false.</returns>
    public static bool operator !=(Money? left, Money? right)
    {
        return !(left == right);
    }
}
