// Patch / operation nested parts — generator 未展開之 backbone 屬性補全。
#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.Resources.R5;

public partial class Parameters
{
    public partial class ParameterComponent
    {
        public partial class ParameterPartComponent
        {
            [JsonPropertyName("name")]
            public FhirString? Name { get; set; }

            [JsonPropertyName("valueString")]
            public FhirString? ValueString { get; set; }

            [JsonPropertyName("valueCode")]
            public FhirCode? ValueCode { get; set; }

            [JsonPropertyName("valueInteger")]
            public FhirInteger? ValueInteger { get; set; }

            [JsonPropertyName("valueBoolean")]
            public FhirBoolean? ValueBoolean { get; set; }

            [JsonPropertyName("valueDate")]
            public FhirDate? ValueDate { get; set; }

            [JsonPropertyName("valueDateTime")]
            public FhirDateTime? ValueDateTime { get; set; }

            [JsonPropertyName("valueUri")]
            public FhirUri? ValueUri { get; set; }

            [JsonPropertyName("valueCoding")]
            public Coding? ValueCoding { get; set; }

            [JsonPropertyName("valueReference")]
            public Reference? ValueReference { get; set; }

            [JsonPropertyName("valueHumanname")]
            public HumanName? ValueHumanname { get; set; }

            [JsonPropertyName("valueQuantity")]
            public Quantity? ValueQuantity { get; set; }

            [JsonPropertyName("part")]
            public List<ParameterPartComponent>? Part { get; set; }
        }
    }
}
