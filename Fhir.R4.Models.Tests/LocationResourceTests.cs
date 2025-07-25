using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;
using Fhir.R4.Models.Resources;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using Xunit;

namespace Fhir.R4.Models.Tests;

/// <summary>
/// Location Resource 測試
/// 驗證 Location Resource 的正確實作
/// </summary>
public class LocationResourceTests
{
    [Fact]
    public void Location_Should_Inherit_From_DomainResource()
    {
        var location = new Location();
        
        // Location 應該繼承自 DomainResource
        Assert.IsAssignableFrom<DomainResource>(location);
        Assert.IsAssignableFrom<Resource>(location);
        Assert.IsAssignableFrom<Fhir.R4.Models.Base.Base>(location);
    }
    
    [Fact]
    public void Location_Basic_Properties_Should_Work()
    {
        var location = new Location
        {
            Id = "location-001",
            Status = "active",
            Name = "Main Hospital Building",
            Description = "The main building of the hospital complex",
            Mode = "instance"
        };
        
        Assert.Equal("location-001", location.Id);
        Assert.Equal("active", location.Status);
        Assert.Equal("Main Hospital Building", location.Name);
        Assert.Equal("The main building of the hospital complex", location.Description);
        Assert.Equal("instance", location.Mode);
        Assert.Equal("Location", location.ResourceType);
    }
    
    [Fact]
    public void Location_Should_Support_Complex_DataTypes()
    {
        var location = new Location
        {
            Type = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Text = "Hospital"
                },
                new CodeableConcept
                {
                    Text = "Emergency Department"
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint
                {
                    System = "phone",
                    Value = "+1-555-123-4567",
                    Use = "work"
                }
            },
            Address = new Address
            {
                Use = "work",
                Line = new List<FhirString> { new("123 Healthcare Blvd") },
                City = "Medical City",
                State = "CA",
                PostalCode = "90210",
                Country = "US"
            },
            PhysicalType = new CodeableConcept
            {
                Text = "Building"
            }
        };
        
        Assert.Equal(2, location.Type?.Count);
        Assert.Equal("Hospital", location.Type?[0].Text);
        Assert.Equal("Emergency Department", location.Type?[1].Text);
        
        Assert.Single(location.Telecom);
        Assert.Equal("phone", location.Telecom?[0].System);
        Assert.Equal("+1-555-123-4567", location.Telecom?[0].Value);
        
        Assert.NotNull(location.Address);
        Assert.Equal("Medical City", location.Address.City);
        Assert.Equal("Building", location.PhysicalType?.Text);
    }
    
    [Fact]
    public void Location_Should_Support_Position()
    {
        var location = new Location
        {
            Name = "Hospital Main Entrance",
            Position = new LocationPosition
            {
                Longitude = -118.2437m,
                Latitude = 34.0522m,
                Altitude = 100.5m
            }
        };
        
        Assert.NotNull(location.Position);
        Assert.Equal(-118.2437m, location.Position.Longitude);
        Assert.Equal(34.0522m, location.Position.Latitude);
        Assert.Equal(100.5m, location.Position.Altitude);
    }
    
    [Fact]
    public void Location_Should_Support_HoursOfOperation()
    {
        var location = new Location
        {
            Name = "Outpatient Clinic",
            HoursOfOperation = new List<LocationHoursOfOperation>
            {
                new LocationHoursOfOperation
                {
                    DaysOfWeek = new List<FhirCode> { new("mon"), new("tue"), new("wed"), new("thu"), new("fri") },
                    OpeningTime = "08:00:00",
                    ClosingTime = "17:00:00"
                },
                new LocationHoursOfOperation
                {
                    DaysOfWeek = new List<FhirCode> { new("sat") },
                    OpeningTime = "09:00:00",
                    ClosingTime = "12:00:00"
                },
                new LocationHoursOfOperation
                {
                    DaysOfWeek = new List<FhirCode> { new("sun") },
                    AllDay = false
                }
            }
        };
        
        Assert.Equal(3, location.HoursOfOperation?.Count);
        
        var weekdayHours = location.HoursOfOperation?[0];
        Assert.Equal(5, weekdayHours?.DaysOfWeek?.Count);
        Assert.Contains(weekdayHours?.DaysOfWeek ?? [], day => day.Value == "mon");
        Assert.Contains(weekdayHours?.DaysOfWeek ?? [], day => day.Value == "fri");
        Assert.Equal("08:00:00", weekdayHours?.OpeningTime?.Value);
        Assert.Equal("17:00:00", weekdayHours?.ClosingTime?.Value);
        
        var saturdayHours = location.HoursOfOperation?[1];
        Assert.Single(saturdayHours?.DaysOfWeek);
        Assert.Contains(saturdayHours?.DaysOfWeek ?? [], day => day.Value == "sat");
        Assert.Equal("09:00:00", saturdayHours?.OpeningTime?.Value);
        Assert.Equal("12:00:00", saturdayHours?.ClosingTime?.Value);
        
        var sundayHours = location.HoursOfOperation?[2];
        Assert.Single(sundayHours?.DaysOfWeek);
        Assert.Contains(sundayHours?.DaysOfWeek ?? [], day => day.Value == "sun");
        Assert.False(sundayHours?.AllDay);
    }
    
    [Fact]
    public void Location_Should_Support_References()
    {
        var location = new Location
        {
            ManagingOrganization = new Reference<Organization>
            {
                ReferenceValue = "Organization/org-001",
                Display = "Main Hospital System"
            },
            PartOf = new Reference<Location>
            {
                ReferenceValue = "Location/hospital-campus",
                Display = "Hospital Campus"
            }
        };
        
        Assert.NotNull(location.ManagingOrganization);
        Assert.Equal("Organization/org-001", location.ManagingOrganization.ReferenceValue);
        Assert.Equal("Main Hospital System", location.ManagingOrganization.Display);
        
        Assert.NotNull(location.PartOf);
        Assert.Equal("Location/hospital-campus", location.PartOf.ReferenceValue);
        Assert.Equal("Hospital Campus", location.PartOf.Display);
    }
    
    [Fact]
    public void Location_Should_Validate_Status_Values()
    {
        var location = new Location
        {
            Status = "invalid-status"
        };
        
        var validationContext = new ValidationContext(location);
        var validationResults = location.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("status") == true);
        
        // 測試有效的 status
        location.Status = "active";
        validationResults = location.Validate(validationContext).ToList();
        
        // 應該沒有 status 相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("status") == true);
    }
    
    [Fact]
    public void Location_Should_Validate_Mode_Values()
    {
        var location = new Location
        {
            Mode = "invalid-mode"
        };
        
        var validationContext = new ValidationContext(location);
        var validationResults = location.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("mode") == true);
        
        // 測試有效的 mode
        location.Mode = "instance";
        validationResults = location.Validate(validationContext).ToList();
        
        // 應該沒有 mode 相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("mode") == true);
    }
    
    [Fact]
    public void LocationPosition_Should_Validate_Coordinates()
    {
        var position = new LocationPosition
        {
            Longitude = 200m, // 無效：超出範圍
            Latitude = 100m   // 無效：超出範圍
        };
        
        var validationContext = new ValidationContext(position);
        var validationResults = position.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("longitude") == true);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("latitude") == true);
        
        // 測試有效的座標
        position.Longitude = -118.2437m;
        position.Latitude = 34.0522m;
        validationResults = position.Validate(validationContext).ToList();
        
        // 應該沒有座標相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("longitude") == true);
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("latitude") == true);
    }
    
    [Fact]
    public void LocationHoursOfOperation_Should_Validate_DaysOfWeek()
    {
        var hours = new LocationHoursOfOperation
        {
            DaysOfWeek = new List<FhirCode> { new("monday"), new("invalid-day") } // 無效的日期格式
        };
        
        var validationContext = new ValidationContext(hours);
        var validationResults = hours.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("daysOfWeek") == true);
        
        // 測試有效的日期
        hours.DaysOfWeek = new List<FhirCode> { new("mon"), new("tue"), new("wed") };
        validationResults = hours.Validate(validationContext).ToList();
        
        // 應該沒有 daysOfWeek 相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("daysOfWeek") == true);
    }
    
    [Fact]
    public void LocationHoursOfOperation_Should_Validate_Time_Order()
    {
        var hours = new LocationHoursOfOperation
        {
            OpeningTime = "17:00:00",
            ClosingTime = "08:00:00" // 結束時間早於開始時間
        };
        
        var validationContext = new ValidationContext(hours);
        var validationResults = hours.Validate(validationContext).ToList();
        
        Assert.NotEmpty(validationResults);
        Assert.Contains(validationResults, r => r.ErrorMessage?.Contains("closingTime must be after openingTime") == true);
        
        // 測試正確的時間順序
        hours.OpeningTime = "08:00:00";
        hours.ClosingTime = "17:00:00";
        validationResults = hours.Validate(validationContext).ToList();
        
        // 應該沒有時間順序相關的錯誤
        Assert.DoesNotContain(validationResults, r => r.ErrorMessage?.Contains("closingTime must be after openingTime") == true);
    }
    
    [Fact]
    public void Location_JSON_Serialization_Should_Work()
    {
        var location = new Location
        {
            Id = "location-001",
            Status = "active",
            Name = "Main Hospital",
            Mode = "instance",
            Position = new LocationPosition
            {
                Longitude = -118.2437m,
                Latitude = 34.0522m
            }
        };
        
        // 序列化
        var json = JsonSerializer.Serialize(location, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        
        Assert.Contains("\"id\"", json);
        Assert.Contains("\"status\"", json);
        Assert.Contains("\"name\"", json);
        Assert.Contains("\"mode\"", json);
        Assert.Contains("\"position\"", json);
        Assert.Contains("\"longitude\"", json);
        Assert.Contains("\"latitude\"", json);
        
        // 反序列化
        var deserializedLocation = JsonSerializer.Deserialize<Location>(json);
        
        Assert.NotNull(deserializedLocation);
        Assert.Equal("location-001", deserializedLocation.Id);
        Assert.Equal("active", deserializedLocation.Status);
        Assert.Equal("Main Hospital", deserializedLocation.Name);
        Assert.Equal("instance", deserializedLocation.Mode);
        Assert.NotNull(deserializedLocation.Position);
        Assert.Equal(-118.2437m, deserializedLocation.Position.Longitude);
        Assert.Equal(34.0522m, deserializedLocation.Position.Latitude);
    }
}
