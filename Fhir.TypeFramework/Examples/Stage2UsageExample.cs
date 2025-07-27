using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Base;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.ComplexTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Events;
using Fhir.TypeFramework.Extensions;
using Fhir.TypeFramework.Query;
using Fhir.TypeFramework.Serialization;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// 第二階段功能使用範例
/// 展示序列化增強、查詢篩選、事件系統等功能
/// </summary>
public class Stage2UsageExample
{
    /// <summary>
    /// 執行所有第二階段範例
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("🚀 Fhir.TypeFramework 第二階段功能範例");
        Console.WriteLine("=====================================");

        SerializationEnhancementExample();
        QueryAndFilterExample();
        EventSystemExample();
        IntegrationExample();

        Console.WriteLine("\n✅ 所有第二階段範例執行完成！");
    }

    /// <summary>
    /// 序列化增強範例
    /// </summary>
    public static void SerializationEnhancementExample()
    {
        Console.WriteLine("\n🔧 序列化增強範例");
        Console.WriteLine("----------------------");

        // 建立測試資料
        var patient = new Patient()
            .WithId("patient-001")
            .WithExtension("http://example.com/type", "outpatient");

        patient.Name = new HumanName()
            .WithValue("張", "三")
            .WithExtension("http://example.com/source", "official");

        patient.BirthDate = new FhirDate(DateTime.Now.AddYears(-30));
        patient.Gender = new FhirCode("male");

        // JSON 序列化
        var jsonSerializer = SerializerFactory.CreateSerializer(SerializationFormat.Json);
        var json = jsonSerializer.Serialize(patient);
        Console.WriteLine($"✅ JSON 序列化: {json.Substring(0, Math.Min(100, json.Length))}...");

        // XML 序列化
        var xmlSerializer = SerializerFactory.CreateSerializer(SerializationFormat.Xml);
        var xml = xmlSerializer.Serialize(patient);
        Console.WriteLine($"✅ XML 序列化: {xml.Substring(0, Math.Min(100, xml.Length))}...");

        // 使用擴展方法
        var json2 = patient.ToJson();
        var xml2 = patient.ToXml();
        Console.WriteLine($"✅ 擴展方法 JSON: {json2.Substring(0, Math.Min(100, json2.Length))}...");
        Console.WriteLine($"✅ 擴展方法 XML: {xml2.Substring(0, Math.Min(100, xml2.Length))}...");

        // 反序列化測試
        var deserializedPatient = jsonSerializer.Deserialize<Patient>(json);
        Console.WriteLine($"✅ 反序列化結果: {deserializedPatient?.Id}");

        // 檢查支援的格式
        var supportedFormats = SerializerFactory.GetSupportedFormats();
        Console.WriteLine($"✅ 支援的序列化格式: {string.Join(", ", supportedFormats)}");
    }

    /// <summary>
    /// 查詢和篩選範例
    /// </summary>
    public static void QueryAndFilterExample()
    {
        Console.WriteLine("\n🔧 查詢和篩選範例");
        Console.WriteLine("----------------------");

        // 建立測試資料
        var patients = new List<Patient>
        {
            new Patient()
                .WithId("patient-001")
                .WithExtension("http://example.com/type", "outpatient")
                .WithExtension("http://example.com/priority", 1),
            
            new Patient()
                .WithId("patient-002")
                .WithExtension("http://example.com/type", "inpatient")
                .WithExtension("http://example.com/priority", 2),
            
            new Patient()
                .WithId("patient-003")
                .WithExtension("http://example.com/type", "outpatient")
                .WithExtension("http://example.com/priority", 3)
        };

        // 設定患者資料
        patients[0].Name = new HumanName().WithValue("張", "三");
        patients[0].BirthDate = new FhirDate(DateTime.Now.AddYears(-25));
        patients[0].Gender = new FhirCode("male");

        patients[1].Name = new HumanName().WithValue("李", "四");
        patients[1].BirthDate = new FhirDate(DateTime.Now.AddYears(-35));
        patients[1].Gender = new FhirCode("female");

        patients[2].Name = new HumanName().WithValue("王", "五");
        patients[2].BirthDate = new FhirDate(DateTime.Now.AddYears(-45));
        patients[2].Gender = new FhirCode("male");

        // FHIR Path 查詢
        var outpatientPatients = FhirPathQuery.Query(patients, "Patient.extension[url='http://example.com/type' and value='outpatient']");
        Console.WriteLine($"✅ 門診患者數量: {outpatientPatients.Count()}");

        // LINQ 擴展查詢
        var highPriorityPatients = patients
            .WhereExtension("http://example.com/priority")
            .WhereExtensionValue("http://example.com/priority", 1)
            .ToList();
        Console.WriteLine($"✅ 高優先級患者數量: {highPriorityPatients.Count}");

        // 複雜查詢
        var maleOutpatients = patients
            .WhereExtension("http://example.com/type")
            .WhereExtensionValue("http://example.com/type", "outpatient")
            .WhereString(p => p.Gender, "male")
            .ToList();
        Console.WriteLine($"✅ 男性門診患者數量: {maleOutpatients.Count}");

        // 日期範圍查詢
        var youngPatients = patients
            .WhereDateRange(p => p.BirthDate, DateTime.Now.AddYears(-40), DateTime.Now.AddYears(-20))
            .ToList();
        Console.WriteLine($"✅ 年輕患者數量 (20-40歲): {youngPatients.Count}");

        // 多條件查詢
        var complexQuery = patients
            .WhereAll(
                p => p.HasExtension("http://example.com/type"),
                p => p.Gender?.Value == "male",
                p => p.BirthDate?.Value >= DateTime.Now.AddYears(-50)
            )
            .ToList();
        Console.WriteLine($"✅ 複雜查詢結果數量: {complexQuery.Count}");
    }

    /// <summary>
    /// 事件系統範例
    /// </summary>
    public static void EventSystemExample()
    {
        Console.WriteLine("\n🔧 事件系統範例");
        Console.WriteLine("----------------------");

        // 建立事件訂閱器
        var eventSubscriber = new FhirEventSubscriber();

        // 訂閱資源變更事件
        eventSubscriber.Subscribe("Resource.Created", (fhirEvent) =>
        {
            Console.WriteLine($"📝 資源建立事件: {fhirEvent.Timestamp:yyyy-MM-dd HH:mm:ss}");
        });

        eventSubscriber.Subscribe("Resource.Updated", (fhirEvent) =>
        {
            Console.WriteLine($"📝 資源更新事件: {fhirEvent.Timestamp:yyyy-MM-dd HH:mm:ss}");
        });

        // 訂閱驗證事件
        eventSubscriber.Subscribe("Validation", (fhirEvent) =>
        {
            if (fhirEvent is ValidationEvent validationEvent)
            {
                Console.WriteLine($"📝 驗證事件: 有效={validationEvent.IsValid}, 錯誤={validationEvent.ErrorCount}");
            }
        });

        // 訂閱序列化事件
        eventSubscriber.Subscribe("Serialization", (fhirEvent) =>
        {
            if (fhirEvent is SerializationEvent serializationEvent)
            {
                Console.WriteLine($"📝 序列化事件: 格式={serializationEvent.Format}, 大小={serializationEvent.Size} bytes, 耗時={serializationEvent.Duration}ms");
            }
        });

        // 訂閱高優先級事件
        eventSubscriber.Subscribe("Validation", EventPriority.High, (fhirEvent) =>
        {
            Console.WriteLine($"🚨 高優先級驗證事件: {fhirEvent.Timestamp:yyyy-MM-dd HH:mm:ss}");
        });

        // 設定錯誤處理
        eventSubscriber.OnError += (fhirEvent, ex) =>
        {
            Console.WriteLine($"❌ 事件處理錯誤: {ex.Message}");
        };

        // 發布事件
        eventSubscriber.PublishResourceChanged(ChangeType.Created, "patient-001", "Patient");
        eventSubscriber.PublishResourceChanged(ChangeType.Updated, "patient-001", "Patient");
        eventSubscriber.PublishValidation(true, 0, 1);
        eventSubscriber.PublishValidation(false, 2, 0);
        eventSubscriber.PublishSerialization("JSON", 1024, 50);

        // 顯示統計資訊
        var statistics = eventSubscriber.Statistics.GetStatistics();
        Console.WriteLine($"✅ 事件統計: {statistics.Count} 種事件型別");

        var subscriptionStats = eventSubscriber.GetSubscriptionStatistics();
        Console.WriteLine($"✅ 訂閱統計: {subscriptionStats.TotalEventTypes} 種事件型別, {subscriptionStats.TotalSubscribers} 個訂閱者");
    }

    /// <summary>
    /// 整合功能範例
    /// </summary>
    public static void IntegrationExample()
    {
        Console.WriteLine("\n🔧 整合功能範例");
        Console.WriteLine("----------------------");

        // 建立事件訂閱器
        var eventSubscriber = new FhirEventSubscriber();

        // 訂閱驗證事件
        eventSubscriber.Subscribe("Validation", (fhirEvent) =>
        {
            if (fhirEvent is ValidationEvent validationEvent)
            {
                Console.WriteLine($"📝 驗證結果: 有效={validationEvent.IsValid}, 錯誤={validationEvent.ErrorCount}");
            }
        });

        // 建立患者資料
        var patient = new Patient()
            .WithId("patient-001")
            .WithExtension("http://example.com/type", "outpatient")
            .WithExtension("http://example.com/priority", 1);

        patient.Name = new HumanName()
            .WithValue("張", "三")
            .WithExtension("http://example.com/source", "official");

        patient.BirthDate = new FhirDate(DateTime.Now.AddYears(-30));
        patient.Gender = new FhirCode("male");

        // 驗證患者資料
        var validationContext = new ValidationContext(patient);
        var validationResults = patient.Validate(validationContext);
        
        // 發布驗證事件
        eventSubscriber.PublishValidation(
            !validationResults.Any(),
            validationResults.Count(r => r.ErrorMessage?.Contains("Error") == true),
            validationResults.Count(r => r.ErrorMessage?.Contains("Warning") == true)
        );

        // 序列化患者資料
        var startTime = DateTime.Now;
        var json = patient.ToJson();
        var endTime = DateTime.Now;
        var duration = (long)(endTime - startTime).TotalMilliseconds;
        var size = System.Text.Encoding.UTF8.GetByteCount(json);

        // 發布序列化事件
        eventSubscriber.PublishSerialization("JSON", size, duration);

        // 建立患者集合並進行查詢
        var patients = new List<Patient> { patient };
        
        // 複製患者並修改
        var patient2 = patient.DeepCopy() as Patient;
        patient2!.Id = "patient-002";
        patient2.Name = new HumanName().WithValue("李", "四");
        patients.Add(patient2);

        // 查詢門診患者
        var outpatientPatients = patients
            .WhereExtension("http://example.com/type")
            .WhereExtensionValue("http://example.com/type", "outpatient")
            .ToList();

        Console.WriteLine($"✅ 門診患者數量: {outpatientPatients.Count}");

        // 序列化查詢結果
        var queryResultsJson = outpatientPatients.Select(p => p.ToJson()).ToList();
        Console.WriteLine($"✅ 查詢結果序列化完成: {queryResultsJson.Count} 個結果");

        // 顯示最終統計
        var finalStats = eventSubscriber.Statistics.GetStatistics();
        Console.WriteLine($"✅ 最終事件統計: {finalStats.Count} 種事件型別");
        
        foreach (var stat in finalStats)
        {
            Console.WriteLine($"   - {stat.Key}: {stat.Value.EventCount} 事件, {stat.Value.SuccessRate:P1} 成功率");
        }
    }

    /// <summary>
    /// 效能測試範例
    /// </summary>
    public static void PerformanceTestExample()
    {
        Console.WriteLine("\n🔧 效能測試範例");
        Console.WriteLine("----------------------");

        // 測試序列化效能
        var patient = new Patient()
            .WithId("patient-001")
            .WithExtension("http://example.com/type", "outpatient");

        patient.Name = new HumanName().WithValue("張", "三");
        patient.BirthDate = new FhirDate(DateTime.Now.AddYears(-30));
        patient.Gender = new FhirCode("male");

        var eventSubscriber = new FhirEventSubscriber();

        // JSON 序列化效能測試
        var jsonStartTime = DateTime.Now;
        for (int i = 0; i < 1000; i++)
        {
            var json = patient.ToJson();
        }
        var jsonEndTime = DateTime.Now;
        var jsonDuration = (jsonEndTime - jsonStartTime).TotalMilliseconds;
        Console.WriteLine($"✅ JSON 序列化 1000 次耗時: {jsonDuration}ms");

        // XML 序列化效能測試
        var xmlStartTime = DateTime.Now;
        for (int i = 0; i < 1000; i++)
        {
            var xml = patient.ToXml();
        }
        var xmlEndTime = DateTime.Now;
        var xmlDuration = (xmlEndTime - xmlStartTime).TotalMilliseconds;
        Console.WriteLine($"✅ XML 序列化 1000 次耗時: {xmlDuration}ms");

        // 查詢效能測試
        var patients = new List<Patient>();
        for (int i = 0; i < 1000; i++)
        {
            var p = new Patient()
                .WithId($"patient-{i:D3}")
                .WithExtension("http://example.com/type", i % 2 == 0 ? "outpatient" : "inpatient")
                .WithExtension("http://example.com/priority", i % 3 + 1);
            
            p.Name = new HumanName().WithValue($"姓{i}", $"名{i}");
            p.BirthDate = new FhirDate(DateTime.Now.AddYears(-20 - i % 50));
            p.Gender = new FhirCode(i % 2 == 0 ? "male" : "female");
            
            patients.Add(p);
        }

        var queryStartTime = DateTime.Now;
        var outpatientCount = patients
            .WhereExtension("http://example.com/type")
            .WhereExtensionValue("http://example.com/type", "outpatient")
            .Count();
        var queryEndTime = DateTime.Now;
        var queryDuration = (queryEndTime - queryStartTime).TotalMilliseconds;
        Console.WriteLine($"✅ 查詢 1000 個患者中的門診患者耗時: {queryDuration}ms, 結果: {outpatientCount}");

        // 事件發布效能測試
        var eventStartTime = DateTime.Now;
        for (int i = 0; i < 1000; i++)
        {
            eventSubscriber.PublishValidation(true, 0, 0);
        }
        var eventEndTime = DateTime.Now;
        var eventDuration = (eventEndTime - eventStartTime).TotalMilliseconds;
        Console.WriteLine($"✅ 發布 1000 個驗證事件耗時: {eventDuration}ms");
    }
} 