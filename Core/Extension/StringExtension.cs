using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Extension
{
    public static class StringExtension
    {
        #region general
        public static string? FirstCharToLowerCase(this string? str)
        {
            if (!string.IsNullOrEmpty(str) && char.IsUpper(str[0]))
                return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

            return str;
        }
        #endregion

        #region Based64
        public static string Based64Encode(this string source)
        {
            if (string.IsNullOrEmpty(source)) { return string.Empty; }
            var ptextbyte = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(ptextbyte);
        }
        public static string Based64Decode(this string source)
        {
            if (string.IsNullOrEmpty(source)) { return string.Empty; }
            var base64EncodedBytes = Convert.FromBase64String(source);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        #endregion
        #region Replace string 
        public static string ReplaceHtmlTag(this string source)
        {
            string pattern = "<.*?>";

            if (string.IsNullOrEmpty(source)) { return string.Empty; }
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.Replace(source, string.Empty);
        }
        #endregion

        #region Check ContentType
        public static bool CheckContentIsJson(this string value)
        {
            if (value.StartsWith('<') && value.EndsWith('>'))
            {
                return false;
            }
            else if (value.StartsWith('{') || value.StartsWith('['))
            {
                return true;
            }
            else
            {
                throw new FormatException("不是XML或JSON格式");
            }
        }
        public static bool CheckContentIsXML(this string value)
        {
            if (value.StartsWith('<') && value.EndsWith('>'))
            {
                return true;
            }
            else if (value.StartsWith('{') || value.StartsWith('['))
            {
                return false;
            }
            else
            {
                throw new FormatException("不是XML或JSON格式");
            }
        }

        #endregion
        #region JsonNode
        public static JsonNode? Parse(this string? value )
        {
            if (value == null || !value.Trim().CheckContentIsJson()) return null;
            Byte[] byteArray = Encoding.UTF8.GetBytes(value);
            MemoryStream stream = new(byteArray);
            return JsonNode.Parse(stream);
        }
        #endregion
    }
}