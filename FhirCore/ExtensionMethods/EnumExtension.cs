using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FhirCore.ExtensionMethods
{
    public static class EnumExtension
    {
        public static string? GetEnumMemberValue<T>(this T value) where T : Enum
        {
            return typeof(T).GetTypeInfo().DeclaredMembers.SingleOrDefault(x => x.Name == value.ToString())?.GetCustomAttribute<EnumMemberAttribute>(false)?.Value;
        }

    }
}
