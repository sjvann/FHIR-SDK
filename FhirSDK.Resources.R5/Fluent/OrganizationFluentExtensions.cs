using System.Collections.Generic;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirSDK.Resources.R5
{
    public static class OrganizationFluentExtensions
    {
        public static Organization WithActive(this Organization org, bool value)
        {
            org.Active = new FhirBoolean(value);
            return org;
        }

        public static Organization WithName(this Organization org, string name)
        {
            org.Name = new FhirString(name);
            return org;
        }

        public static Organization AddIdentifier(this Organization org, string system, string value)
        {
            var list = org.Identifier ?? new List<Identifier>();
            list.Add(new Identifier { System = new FhirUri(system), Value = new FhirString(value) });
            org.Identifier = list;
            return org;
        }

        public static Organization AddAlias(this Organization org, string alias)
        {
            var list = org.Alias ?? new List<FhirString>();
            list.Add(new FhirString(alias));
            org.Alias = list;
            return org;
        }
    }
}

