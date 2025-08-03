using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FhirCore.Interfaces;
using FhirCore.Versioning;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace FhirCore.Base
{
    /// <summary>
    /// FHIR 資源的基礎類別
    /// 
    /// <para>
    /// 提供所有 FHIR 資源的基本功能，包括：
    /// - 版本管理
    /// - 屬性變更通知
    /// - 基本驗證
    /// - 序列化支援
    /// </para>
    /// </summary>
    /// <typeparam name="TVersion">版本類型</typeparam>
    public abstract class ResourceBase<TVersion> : ResourceBase, IFhirResource<TVersion>
        where TVersion : IFhirVersion, new()
    {
        /// <summary>
        /// 取得此資源關聯的 FHIR 版本實例
        /// </summary>
        /// <value>FHIR 版本實例</value>
        /// <remarks>
        /// <para>
        /// 此屬性提供與資源關聯的特定 FHIR 版本實例，
        /// 用於版本特定的驗證和操作。
        /// </para>
        /// </remarks>
        public TVersion Version => new();

        /// <summary>
        /// 取得資源的 FHIR 版本字串
        /// </summary>
        /// <returns>FHIR 版本字串</returns>
        /// <remarks>
        /// <para>
        /// 此方法返回與此資源關聯的 FHIR 版本字串，
        /// 從版本實例中自動取得。
        /// </para>
        /// </remarks>
        public override string GetFhirVersion() => Version.Version;

        /// <summary>
        /// 建立版本特定資源的深層複製
        /// </summary>
        /// <returns>複製的資源</returns>
        /// <remarks>
        /// <para>
        /// 此方法建立當前資源的深層複製，保持版本類型資訊。
        /// </para>
        /// </remarks>
        public new virtual ResourceBase<TVersion> Clone()
        {
            var clone = (ResourceBase<TVersion>)MemberwiseClone();
            
            // 清空並重新填充集合
            clone.Extension.Clear();
            foreach (var extension in Extension)
            {
                clone.Extension.Add(new Extension
                {
                    Url = extension.Url,
                    Value = extension.Value
                });
            }

            clone.ModifierExtension.Clear();
            foreach (var extension in ModifierExtension)
            {
                clone.ModifierExtension.Add(new Extension
                {
                    Url = extension.Url,
                    Value = extension.Value
                });
            }

            return clone;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        /// <returns>字串表示</returns>
        /// <remarks>
        /// <para>
        /// 返回包含版本資訊的資源字串表示。
        /// </para>
        /// </remarks>
        public override string ToString()
        {
            return $"{ResourceType}(Id: {Id}, Version: {GetFhirVersion()})";
        }
    }

    /// <summary>
    /// FHIR 資源的非泛型基礎類別
    /// 
    /// <para>
    /// 提供所有 FHIR 資源的基本功能，不依賴特定版本類型。
    /// 這允許更簡單的繼承和使用。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 此類別實作 IResource 介面，提供核心的 FHIR 資源功能。
    /// 子類別可以選擇繼承此類別或泛型版本。
    /// </para>
    /// </remarks>
    public abstract class ResourceBase : IResource, INotifyPropertyChanged
    {
        private string? _id;
        private Meta? _meta;
        private string? _implicitRules;
        private string? _language;

        /// <summary>
        /// 屬性變更事件
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 資源的唯一識別碼
        /// </summary>
        public string? Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 資源類型（由子類別實作）
        /// </summary>
        public abstract string ResourceType { get; }

        /// <summary>
        /// 資源的元資料
        /// </summary>
        public Meta? Meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 資源的隱含規則
        /// </summary>
        public string? ImplicitRules
        {
            get => _implicitRules;
            set
            {
                _implicitRules = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 資源的語言
        /// </summary>
        public string? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// 資源的擴展
        /// </summary>
        public ObservableCollection<Extension> Extension { get; } = new();

        /// <summary>
        /// 資源的修飾符擴展
        /// </summary>
        public ObservableCollection<Extension> ModifierExtension { get; } = new();

        /// <summary>
        /// 取得資源的 FHIR 版本字串
        /// </summary>
        /// <returns>FHIR 版本字串</returns>
        /// <remarks>
        /// <para>
        /// 此方法返回資源的 FHIR 版本。預設實作返回 "5.0.0"，
        /// 子類別可以覆寫以返回適當的版本。
        /// </para>
        /// </remarks>
        public virtual string GetFhirVersion() => "5.0.0";

        /// <summary>
        /// 驗證資源是否符合 FHIR 標準
        /// </summary>
        /// <returns>驗證結果</returns>
        /// <remarks>
        /// <para>
        /// 此方法執行基本的資源驗證，並可以在子類別中擴展
        /// 以包含特定的驗證邏輯。
        /// </para>
        /// </remarks>
        public virtual ValidationResult Validate()
        {
            var context = new System.ComponentModel.DataAnnotations.ValidationContext(this);
            var results = new List<ValidationResult>();

            // 基本驗證
            if (string.IsNullOrEmpty(ResourceType))
            {
                results.Add(new ValidationResult("ResourceType 不能為空"));
            }

            // 驗證擴展
            foreach (var extension in Extension)
            {
                if (string.IsNullOrEmpty(extension.Url))
                {
                    results.Add(new ValidationResult("Extension URL 不能為空"));
                }
            }

            // 驗證修飾符擴展
            foreach (var extension in ModifierExtension)
            {
                if (string.IsNullOrEmpty(extension.Url))
                {
                    results.Add(new ValidationResult("ModifierExtension URL 不能為空"));
                }
            }

            // 版本特定驗證
            var versionValidation = ValidateVersionSpecific();
            if (versionValidation != null)
            {
                results.Add(versionValidation);
            }

            return results.Count == 0 ? ValidationResult.Success! : results[0];
        }

        /// <summary>
        /// 執行版本特定的驗證
        /// </summary>
        /// <returns>驗證結果</returns>
        /// <remarks>
        /// <para>
        /// 此虛擬方法可在子類別中覆寫，以實作特定版本的驗證邏輯。
        /// 預設實作返回 null（表示無錯誤）。
        /// </para>
        /// </remarks>
        protected virtual ValidationResult? ValidateVersionSpecific()
        {
            return null;
        }

        /// <summary>
        /// 建立資源的深層複製
        /// </summary>
        /// <returns>複製的資源</returns>
        /// <remarks>
        /// <para>
        /// 此方法建立當前資源的深層複製。
        /// </para>
        /// </remarks>
        public virtual ResourceBase Clone()
        {
            var clone = (ResourceBase)MemberwiseClone();
            
            // 清空並重新填充集合
            clone.Extension.Clear();
            foreach (var extension in Extension)
            {
                clone.Extension.Add(new Extension
                {
                    Url = extension.Url,
                    Value = extension.Value
                });
            }

            clone.ModifierExtension.Clear();
            foreach (var extension in ModifierExtension)
            {
                clone.ModifierExtension.Add(new Extension
                {
                    Url = extension.Url,
                    Value = extension.Value
                });
            }

            return clone;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        /// <returns>字串表示</returns>
        /// <remarks>
        /// <para>
        /// 返回包含版本資訊的資源字串表示。
        /// </para>
        /// </remarks>
        public override string ToString()
        {
            return $"{ResourceType}(Id: {Id}, Version: {GetFhirVersion()})";
        }

        /// <summary>
        /// 屬性變更通知
        /// </summary>
        /// <param name="propertyName">屬性名稱</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}