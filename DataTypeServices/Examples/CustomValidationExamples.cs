using DataTypeServices.Attributes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.Examples
{
    /// <summary>
    /// 示例 Patient 類型，展示自定義驗證屬性的使用
    /// </summary>
    public class ValidatedPatient : ComplexType<ValidatedPatient>
    {
        private FhirId? _id;
        private List<ContactPoint>? _telecom;
        private FhirDate? _birthDate;
        private FhirDecimal? _height;
        private FhirString? _socialSecurityNumber;
        private FhirString? _website;

        /// <summary>
        /// 患者 ID - 必須符合特定格式
        /// </summary>
        [RegexValidation(@"^PAT-\d{6}$", ErrorMessage = "Patient ID must be in format PAT-XXXXXX")]
        public new FhirId? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("id", value);
            }
        }

        /// <summary>
        /// 聯絡方式 - 電子郵件需要驗證格式
        /// </summary>
        [FhirValidation("ValidateContactPoints")]
        public List<ContactPoint>? Telecom
        {
            get { return _telecom; }
            set
            {
                _telecom = value;
                OnPropertyChanged("telecom", value);
            }
        }

        /// <summary>
        /// 出生日期 - 必須在合理範圍內
        /// </summary>
        [DateRangeValidation(ErrorMessage = "Birth date must be between 1900 and today")]
        public FhirDate? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnPropertyChanged("birthDate", value);
            }
        }

        /// <summary>
        /// 身高 - 必須在合理範圍內
        /// </summary>
        [NumericRangeValidation(30, 300, ErrorMessage = "Height must be between 30 and 300 cm")]
        public FhirDecimal? Height
        {
            get { return _height; }
            set
            {
                _height = value;
                OnPropertyChanged("height", value);
            }
        }

        /// <summary>
        /// 社會安全號碼 - 自定義驗證
        /// </summary>
        [FhirValidation("ValidateSSN", Priority = 1, StopOnFirstFailure = true)]
        public FhirString? SocialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set
            {
                _socialSecurityNumber = value;
                OnPropertyChanged("socialSecurityNumber", value);
            }
        }

        /// <summary>
        /// 網站 - URL 格式驗證
        /// </summary>
        [UrlValidation]
        public FhirString? Website
        {
            get { return _website; }
            set
            {
                _website = value;
                OnPropertyChanged("website", value);
            }
        }

        public ValidatedPatient() : base() 
        {
            // 設定日期範圍驗證的具體值
            var birthDateProperty = typeof(ValidatedPatient).GetProperty(nameof(BirthDate));
            var dateRangeAttr = birthDateProperty?.GetCustomAttributes(typeof(DateRangeValidationAttribute), false)[0] as DateRangeValidationAttribute;
            if (dateRangeAttr != null)
            {
                dateRangeAttr.MinDate = new DateTime(1900, 1, 1);
                dateRangeAttr.MaxDate = DateTime.Today;
            }
        }
        
        public ValidatedPatient(JsonObject value) : base(value) { }
        public ValidatedPatient(string value) : base(value) { }

        #region 自定義驗證方法

        /// <summary>
        /// 驗證聯絡方式
        /// </summary>
        /// <param name="telecom">聯絡方式列表</param>
        /// <returns>驗證結果</returns>
        private ValidationResult ValidateContactPoints(List<ContactPoint>? telecom)
        {
            if (telecom == null || telecom.Count == 0)
                return ValidationResult.Success();

            var errors = new List<string>();

            foreach (var contact in telecom)
            {
                if (contact.System?.Value == "email")
                {
                    var email = contact.Value?.Value;
                    if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
                    {
                        errors.Add($"Invalid email format: {email}");
                    }
                }
                else if (contact.System?.Value == "phone")
                {
                    var phone = contact.Value?.Value;
                    if (!string.IsNullOrEmpty(phone) && !IsValidPhone(phone))
                    {
                        errors.Add($"Invalid phone format: {phone}");
                    }
                }
            }

            if (errors.Count > 0)
            {
                return ValidationResult.Error(string.Join("; ", errors), "Telecom");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證社會安全號碼
        /// </summary>
        /// <param name="ssn">社會安全號碼</param>
        /// <returns>驗證結果</returns>
        private ValidationResult ValidateSSN(FhirString? ssn)
        {
            if (ssn?.Value == null)
                return ValidationResult.Success();

            var ssnValue = ssn.Value;
            
            // 移除分隔符
            var cleanSSN = Regex.Replace(ssnValue, @"[\s\-]", "");
            
            // 檢查格式：9位數字
            if (!Regex.IsMatch(cleanSSN, @"^\d{9}$"))
            {
                return ValidationResult.Error("SSN must be 9 digits", "SocialSecurityNumber");
            }

            // 檢查是否為無效的 SSN（例如：000000000, 123456789）
            if (cleanSSN == "000000000" || cleanSSN == "123456789")
            {
                return ValidationResult.Error("Invalid SSN pattern", "SocialSecurityNumber");
            }

            // 檢查前三位不能為 000, 666, 或 900-999
            var firstThree = cleanSSN.Substring(0, 3);
            if (firstThree == "000" || firstThree == "666" || 
                (int.Parse(firstThree) >= 900 && int.Parse(firstThree) <= 999))
            {
                return ValidationResult.Error("Invalid SSN area number", "SocialSecurityNumber");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證電子郵件格式
        /// </summary>
        private static bool IsValidEmail(string email)
        {
            var emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        /// <summary>
        /// 驗證電話號碼格式
        /// </summary>
        private static bool IsValidPhone(string phone)
        {
            var phonePattern = @"^[\+]?[1-9][\d]{0,15}$";
            var cleanPhone = Regex.Replace(phone, @"[\s\-\(\)]", "");
            return Regex.IsMatch(cleanPhone, phonePattern);
        }

        #endregion
    }

    /// <summary>
    /// 示例 Medication 類型，展示多重驗證屬性
    /// </summary>
    public class ValidatedMedication : ComplexType<ValidatedMedication>
    {
        private FhirString? _code;
        private FhirString? _name;
        private FhirDecimal? _strength;
        private FhirDate? _expiryDate;

        /// <summary>
        /// 藥物代碼 - 多重驗證
        /// </summary>
        [RegexValidation(@"^MED-\d{4}$", Priority = 1, ErrorMessage = "Medication code must be in format MED-XXXX")]
        [FhirValidation("ValidateMedicationCode", Priority = 2)]
        public FhirString? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// 藥物名稱 - 長度驗證
        /// </summary>
        [FhirValidation("ValidateMedicationName")]
        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        /// <summary>
        /// 藥物強度 - 數值範圍驗證
        /// </summary>
        [NumericRangeValidation(0.1, 1000, ErrorMessage = "Strength must be between 0.1 and 1000 mg")]
        public FhirDecimal? Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                OnPropertyChanged("strength", value);
            }
        }

        /// <summary>
        /// 到期日期 - 必須是未來日期
        /// </summary>
        [FhirValidation("ValidateExpiryDate")]
        public FhirDate? ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                _expiryDate = value;
                OnPropertyChanged("expiryDate", value);
            }
        }

        public ValidatedMedication() : base() { }
        public ValidatedMedication(JsonObject value) : base(value) { }
        public ValidatedMedication(string value) : base(value) { }

        #region 自定義驗證方法

        /// <summary>
        /// 驗證藥物代碼
        /// </summary>
        private ValidationResult ValidateMedicationCode(FhirString? code)
        {
            if (code?.Value == null)
                return ValidationResult.Success();

            // 檢查代碼是否在有效列表中（模擬）
            var validCodes = new[] { "MED-0001", "MED-0002", "MED-0003", "MED-1001", "MED-2001" };
            
            if (!validCodes.Contains(code.Value))
            {
                return ValidationResult.Error($"Medication code '{code.Value}' is not in the approved list", "Code");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證藥物名稱
        /// </summary>
        private ValidationResult ValidateMedicationName(FhirString? name)
        {
            if (name?.Value == null)
                return ValidationResult.Success();

            var nameValue = name.Value;

            if (nameValue.Length < 2)
            {
                return ValidationResult.Error("Medication name must be at least 2 characters long", "Name");
            }

            if (nameValue.Length > 100)
            {
                return ValidationResult.Error("Medication name cannot exceed 100 characters", "Name");
            }

            // 檢查是否包含特殊字符
            if (Regex.IsMatch(nameValue, @"[<>""'&]"))
            {
                return ValidationResult.Error("Medication name contains invalid characters", "Name");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證到期日期
        /// </summary>
        private ValidationResult ValidateExpiryDate(FhirDate? expiryDate)
        {
            if (expiryDate?.Value == null)
                return ValidationResult.Success();

            if (expiryDate.Value <= DateTime.Today)
            {
                return ValidationResult.Error("Expiry date must be in the future", "ExpiryDate");
            }

            // 檢查是否過於遙遠（超過10年）
            if (expiryDate.Value > DateTime.Today.AddYears(10))
            {
                return ValidationResult.Error("Expiry date cannot be more than 10 years in the future", "ExpiryDate");
            }

            return ValidationResult.Success();
        }

        #endregion
    }
}
