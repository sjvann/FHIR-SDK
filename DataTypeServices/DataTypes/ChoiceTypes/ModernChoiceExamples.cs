using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ChoiceTypes
{
    /// <summary>
    /// 現代化的 AsNeeded ChoiceType，支援 boolean 或 CodeableConcept
    /// 這是 ActivityDefinition 和 PlanDefinition 中常用的選擇類型
    /// </summary>
    public class AsNeededChoice : ModernChoiceType<FhirBoolean, CodeableConcept>
    {
        public AsNeededChoice(FhirBoolean value) : base("asNeeded", value) { }
        public AsNeededChoice(CodeableConcept value) : base("asNeeded", value) { }
        public AsNeededChoice(JsonObject jsonValue) : base("asNeeded", jsonValue) { }

        /// <summary>
        /// 便利方法：從 bool 值創建
        /// </summary>
        public static AsNeededChoice FromBoolean(bool value)
        {
            return new AsNeededChoice(new FhirBoolean(value));
        }

        /// <summary>
        /// 便利方法：從 CodeableConcept 創建
        /// </summary>
        public static AsNeededChoice FromCodeableConcept(CodeableConcept concept)
        {
            return new AsNeededChoice(concept);
        }

        /// <summary>
        /// 便利方法：檢查是否為簡單的 boolean 值
        /// </summary>
        public bool? AsBooleanValue => AsT1?.Value;

        /// <summary>
        /// 便利方法：取得 CodeableConcept
        /// </summary>
        public CodeableConcept? AsCodeableConcept => AsT2;
    }

    /// <summary>
    /// 現代化的 Deceased ChoiceType，支援 boolean 或 dateTime
    /// 這是 Person 和 Patient 中常用的選擇類型
    /// </summary>
    public class DeceasedChoice : ModernChoiceType<FhirBoolean, FhirDateTime>
    {
        public DeceasedChoice(FhirBoolean value) : base("deceased", value) { }
        public DeceasedChoice(FhirDateTime value) : base("deceased", value) { }
        public DeceasedChoice(JsonObject jsonValue) : base("deceased", jsonValue) { }

        /// <summary>
        /// 便利方法：從 bool 值創建
        /// </summary>
        public static DeceasedChoice FromBoolean(bool value)
        {
            return new DeceasedChoice(new FhirBoolean(value));
        }

        /// <summary>
        /// 便利方法：從 DateTime 創建
        /// </summary>
        public static DeceasedChoice FromDateTime(DateTime dateTime)
        {
            return new DeceasedChoice(new FhirDateTime(dateTime));
        }

        /// <summary>
        /// 便利方法：從 string 創建 DateTime
        /// </summary>
        public static DeceasedChoice FromDateTimeString(string dateTimeString)
        {
            return new DeceasedChoice(new FhirDateTime(dateTimeString));
        }

        /// <summary>
        /// 便利方法：檢查是否已死亡（boolean 值）
        /// </summary>
        public bool? IsDeceased => AsT1?.Value;

        /// <summary>
        /// 便利方法：取得死亡日期
        /// </summary>
        public DateTime? DeceasedDateTime => AsT2?.Value;
    }

    /// <summary>
    /// 現代化的 Serviced ChoiceType，支援 date 或 Period
    /// 這是 Claim 和其他資源中常用的選擇類型
    /// </summary>
    public class ServicedChoice : ModernChoiceType<FhirDate, Period>
    {
        public ServicedChoice(FhirDate value) : base("serviced", value) { }
        public ServicedChoice(Period value) : base("serviced", value) { }
        public ServicedChoice(JsonObject jsonValue) : base("serviced", jsonValue) { }

        /// <summary>
        /// 便利方法：從 DateTime 創建單一日期
        /// </summary>
        public static ServicedChoice FromDate(DateTime date)
        {
            return new ServicedChoice(new FhirDate(date));
        }

        /// <summary>
        /// 便利方法：從日期字符串創建
        /// </summary>
        public static ServicedChoice FromDateString(string dateString)
        {
            return new ServicedChoice(new FhirDate(dateString));
        }

        /// <summary>
        /// 便利方法：從日期範圍創建
        /// </summary>
        public static ServicedChoice FromPeriod(DateTime start, DateTime? end = null)
        {
            var period = new Period
            {
                Start = new FhirDateTime(start)
            };
            if (end.HasValue)
            {
                period.End = new FhirDateTime(end.Value);
            }
            return new ServicedChoice(period);
        }

        /// <summary>
        /// 便利方法：取得服務日期
        /// </summary>
        public DateTime? ServiceDate => AsT1?.Value;

        /// <summary>
        /// 便利方法：取得服務期間
        /// </summary>
        public Period? ServicePeriod => AsT2;
    }

    /// <summary>
    /// 示範如何使用現代化的 ChoiceType
    /// </summary>
    public static class ModernChoiceTypeExamples
    {
        public static void DemonstrateUsage()
        {
            // AsNeeded 示例
            var asNeededBoolean = AsNeededChoice.FromBoolean(true);
            var asNeededConcept = AsNeededChoice.FromCodeableConcept(new CodeableConcept());

            // 使用模式匹配
            var description = asNeededBoolean.Match(
                boolean => $"As needed: {boolean.Value}",
                concept => $"As needed when: {(concept.Text?.Value ?? "specified condition")}"
            );

            // 類型安全的檢查
            if (asNeededBoolean.IsT1)
            {
                var boolValue = asNeededBoolean.AsBooleanValue;
                Console.WriteLine($"Boolean value: {boolValue}");
            }

            // Deceased 示例
            var deceasedTrue = DeceasedChoice.FromBoolean(true);
            var deceasedDate = DeceasedChoice.FromDateTime(DateTime.Now);

            // 使用 Switch 進行動作
            deceasedDate.Switch(
                boolean => Console.WriteLine($"Deceased status: {boolean.Value}"),
                dateTime => Console.WriteLine($"Deceased on: {dateTime.Value}")
            );

            // Serviced 示例
            var servicedDate = ServicedChoice.FromDate(DateTime.Today);
            var servicedPeriod = ServicedChoice.FromPeriod(DateTime.Today, DateTime.Today.AddDays(7));

            // 安全的值提取
            if (servicedDate.TryGetValue<FhirDate>(out var date))
            {
                Console.WriteLine($"Service date: {date?.Value}");
            }
        }

        /// <summary>
        /// 示範如何從 JSON 創建 ChoiceType
        /// </summary>
        public static void DemonstrateJsonParsing()
        {
            // 從 JSON 創建 AsNeeded
            var jsonBoolean = JsonObject.Parse("""{"asNeededBoolean": true}""") as JsonObject;
            if (jsonBoolean != null)
            {
                var asNeeded = new AsNeededChoice(jsonBoolean);
                Console.WriteLine($"Parsed as needed: {asNeeded.AsBooleanValue}");
            }

            // 從 JSON 創建 Deceased
            var jsonDateTime = JsonObject.Parse("""{"deceasedDateTime": "2023-12-25"}""") as JsonObject;
            if (jsonDateTime != null)
            {
                try
                {
                    var deceased = new DeceasedChoice(jsonDateTime);
                    Console.WriteLine($"Parsed deceased date: {deceased.DeceasedDateTime}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to parse deceased choice: {ex.Message}");
                }
            }
        }
    }
}
