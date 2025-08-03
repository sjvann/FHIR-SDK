using DataTypeServices.TypeFramework;
using DataTypeServices.Validation;
using FhirCore.Interfaces;
using System;

namespace DataTypeServices.Builders
{
    /// <summary>
    /// Fluent Builder 的基礎類別
    /// </summary>
    /// <typeparam name="TBuilder">Builder 類型</typeparam>
    /// <typeparam name="TTarget">目標類型</typeparam>
    public abstract class FluentBuilderBase<TBuilder, TTarget> 
        where TBuilder : FluentBuilderBase<TBuilder, TTarget>
        where TTarget : IDataType, new()
    {
        protected readonly TTarget _instance;

        protected FluentBuilderBase()
        {
            _instance = new TTarget();
        }

        protected FluentBuilderBase(TTarget instance)
        {
            _instance = instance ?? throw new ArgumentNullException(nameof(instance));
        }

        /// <summary>
        /// 返回當前 Builder 實例（用於鏈式調用）
        /// </summary>
        protected TBuilder Self => (TBuilder)this;

        /// <summary>
        /// 建構最終的對象
        /// </summary>
        /// <returns>建構完成的對象</returns>
        public virtual TTarget Build()
        {
            return _instance;
        }

        /// <summary>
        /// 執行自定義配置
        /// </summary>
        /// <param name="configure">配置動作</param>
        /// <returns>Builder 實例</returns>
        public TBuilder Configure(Action<TTarget> configure)
        {
            configure?.Invoke(_instance);
            return Self;
        }

        /// <summary>
        /// 條件性配置
        /// </summary>
        /// <param name="condition">條件</param>
        /// <param name="configure">配置動作</param>
        /// <returns>Builder 實例</returns>
        public TBuilder When(bool condition, Action<TBuilder> configure)
        {
            if (condition)
            {
                configure?.Invoke(Self);
            }
            return Self;
        }

        /// <summary>
        /// 條件性配置（帶值）
        /// </summary>
        /// <typeparam name="T">值類型</typeparam>
        /// <param name="value">值</param>
        /// <param name="configure">配置動作</param>
        /// <returns>Builder 實例</returns>
        public TBuilder When<T>(T? value, Action<TBuilder, T> configure) where T : class
        {
            if (value != null)
            {
                configure?.Invoke(Self, value);
            }
            return Self;
        }

        /// <summary>
        /// 條件性配置（可空值類型）
        /// </summary>
        /// <typeparam name="T">值類型</typeparam>
        /// <param name="value">值</param>
        /// <param name="configure">配置動作</param>
        /// <returns>Builder 實例</returns>
        public TBuilder When<T>(T? value, Action<TBuilder, T> configure) where T : struct
        {
            if (value.HasValue)
            {
                configure?.Invoke(Self, value.Value);
            }
            return Self;
        }

        /// <summary>
        /// 重置 Builder（清空所有設定）
        /// </summary>
        /// <returns>Builder 實例</returns>
        public virtual TBuilder Reset()
        {
            // 創建新的實例來重置
            var newInstance = new TTarget();
            
            // 使用反射複製新實例的屬性到當前實例
            var properties = typeof(TTarget).GetProperties();
            foreach (var property in properties)
            {
                if (property.CanWrite)
                {
                    var defaultValue = property.GetValue(newInstance);
                    property.SetValue(_instance, defaultValue);
                }
            }
            
            return Self;
        }

        /// <summary>
        /// 複製當前 Builder 的狀態
        /// </summary>
        /// <returns>新的 Builder 實例</returns>
        public abstract TBuilder Clone();

        /// <summary>
        /// 驗證當前建構的對象
        /// </summary>
        /// <returns>驗證結果</returns>
        public virtual ValidationResults Validate()
        {
            // 使用反射來調用 ValidateCardinality 方法（如果存在）
            var validateMethod = typeof(TTarget).GetMethod("ValidateCardinality");
            if (validateMethod != null)
            {
                var result = validateMethod.Invoke(_instance, null);
                if (result is ValidationResults validationResults)
                {
                    return validationResults;
                }
            }

            return new ValidationResults();
        }

        /// <summary>
        /// 建構並驗證對象
        /// </summary>
        /// <returns>建構完成且驗證通過的對象</returns>
        /// <exception cref="InvalidOperationException">驗證失敗時拋出</exception>
        public virtual TTarget BuildAndValidate()
        {
            var validationResults = Validate();
            if (!validationResults.IsValid)
            {
                var errors = string.Join("; ", validationResults.GetErrorMessages());
                throw new InvalidOperationException($"Validation failed: {errors}");
            }
            
            return Build();
        }

        /// <summary>
        /// 嘗試建構對象，如果驗證失敗則返回 null
        /// </summary>
        /// <returns>建構完成的對象，或 null（如果驗證失敗）</returns>
        public virtual TTarget? TryBuild()
        {
            var validationResults = Validate();
            return validationResults.IsValid ? Build() : default;
        }

        /// <summary>
        /// 隱式轉換為目標類型
        /// </summary>
        /// <param name="builder">Builder 實例</param>
        public static implicit operator TTarget(FluentBuilderBase<TBuilder, TTarget> builder)
        {
            return builder.Build();
        }
    }

    /// <summary>
    /// 複雜類型的 Fluent Builder 基礎類別
    /// </summary>
    /// <typeparam name="TBuilder">Builder 類型</typeparam>
    /// <typeparam name="TTarget">目標複雜類型</typeparam>
    public abstract class ComplexTypeBuilder<TBuilder, TTarget> : FluentBuilderBase<TBuilder, TTarget>
        where TBuilder : ComplexTypeBuilder<TBuilder, TTarget>
        where TTarget : ComplexType<TTarget>, new()
    {
        protected ComplexTypeBuilder() : base() { }
        protected ComplexTypeBuilder(TTarget instance) : base(instance) { }

        /// <summary>
        /// 添加擴展元素
        /// </summary>
        /// <param name="url">擴展 URL</param>
        /// <param name="value">擴展值</param>
        /// <returns>Builder 實例</returns>
        public TBuilder WithExtension(string url, object value)
        {
            // 這裡需要根據實際的擴展實現來添加
            // 目前先預留接口
            return Self;
        }

        /// <summary>
        /// 設定 ID（如果支援）
        /// </summary>
        /// <param name="id">ID 值</param>
        /// <returns>Builder 實例</returns>
        public TBuilder WithId(string id)
        {
            // 使用反射來設定 Id 屬性（如果存在）
            var idProperty = typeof(TTarget).GetProperty("Id");
            if (idProperty != null && idProperty.CanWrite)
            {
                idProperty.SetValue(_instance, id);
            }
            return Self;
        }
    }
}
