using System;
using System.Collections.Generic;
using FhirCore.Base;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.ComplexTypes;

namespace ResourceTypeServices.R5
{
    /// <summary>
    /// FHIR R5 List 資源
    /// 
    /// <para>
    /// List 資源用於管理一組相關項目的集合。它可以表示各種類型的列表，
    /// 如藥物清單、問題清單、過敏清單等。R5 版本提供了增強的功能和更好的互操作性。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var list = new List("list-001")
    /// {
    ///     Status = new FhirCode("current"),
    ///     Mode = new FhirCode("working"),
    ///     Title = new FhirString("Patient Medications"),
    ///     Date = new FhirDateTime(DateTime.Now)
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 List 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// - 支援更複雜的列表管理
    /// </para>
    /// 
    /// <para>
    /// 使用場景：
    /// - 藥物清單管理
    /// - 問題清單追蹤
    /// - 過敏史記錄
    /// - 治療計劃項目
    /// </para>
    /// </remarks>
    public class List : ResourceBase
    {
        private FhirCode? _status;
        private FhirCode? _mode;
        private FhirString? _title;
        private FhirDateTime? _date;
        private FhirBoolean? _deleted;

        /// <summary>
        /// 資源類型
        /// </summary>
        /// <value>固定值 "List"</value>
        public override string ResourceType => "List";

        /// <summary>
        /// 取得 FHIR 版本
        /// </summary>
        /// <returns>R5 版本號 "5.0.0"</returns>
        public override string GetFhirVersion() => "5.0.0";

        /// <summary>
        /// 清單狀態
        /// 
        /// <para>
        /// 指示清單的目前狀態。這對於確定清單是否為最新且可用非常重要。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Status = new FhirCode("current");  // 目前有效
        /// list.Status = new FhirCode("retired");  // 已停用
        /// list.Status = new FhirCode("entered-in-error");  // 錯誤輸入
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 可能的值包括：
        /// - current: 清單目前有效且最新
        /// - retired: 清單已不再使用
        /// - entered-in-error: 清單是錯誤建立的
        /// </para>
        /// 
        /// <para>
        /// 狀態變更應該謹慎處理，並且要有適當的審核記錄。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        /// <summary>
        /// 清單模式
        /// 
        /// <para>
        /// 指示清單的類型和用途。這決定了清單如何被解釋和使用。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Mode = new FhirCode("working");    // 工作清單
        /// list.Mode = new FhirCode("snapshot");   // 快照清單
        /// list.Mode = new FhirCode("changes");    // 變更清單
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 主要模式包括：
        /// - working: 工作清單，可能會變更
        /// - snapshot: 特定時間點的快照
        /// - changes: 記錄變更的清單
        /// </para>
        /// 
        /// <para>
        /// 模式選擇影響清單的解釋和處理方式。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }

        /// <summary>
        /// 清單標題
        /// 
        /// <para>
        /// 清單的描述性標題，用於識別和描述清單的目的。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Title = new FhirString("Patient Active Medications");
        /// list.Title = new FhirString("Known Allergies");
        /// list.Title = new FhirString("Current Problems");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 標題應該：
        /// - 清楚描述清單的內容
        /// - 便於使用者理解
        /// - 適合在使用者介面中顯示
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        /// <summary>
        /// 清單建立或最後更新日期
        /// 
        /// <para>
        /// 記錄清單建立或最後一次修改的日期和時間。
        /// 這對於追蹤清單的時效性很重要。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Date = new FhirDateTime(DateTime.Now);
        /// list.Date = new FhirDateTime("2024-01-15T10:30:00Z");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 日期用於：
        /// - 追蹤清單的時效性
        /// - 版本控制和審核
        /// - 確定清單的相關性
        /// </para>
        /// 
        /// <para>
        /// 建議使用 ISO 8601 格式的日期時間。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        /// <summary>
        /// 是否已刪除標記
        /// 
        /// <para>
        /// 指示清單是否已被標記為刪除。這是一種軟刪除機制，
        /// 允許保留歷史記錄的同時標記清單為不可用。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// list.Deleted = new FhirBoolean(false);  // 未刪除
        /// list.Deleted = new FhirBoolean(true);   // 已刪除
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 刪除標記的用途：
        /// - 軟刪除機制
        /// - 保留審核軌跡
        /// - 避免硬刪除帶來的資料遺失
        /// </para>
        /// 
        /// <para>
        /// 已刪除的清單通常不應該在正常查詢中返回。
        /// </para>
        /// </remarks>
        public FhirBoolean? Deleted
        {
            get => _deleted;
            set
            {
                _deleted = value;
                OnPropertyChanged(nameof(Deleted));
            }
        }

        /// <summary>
        /// 初始化 List 類別的新執行個體
        /// </summary>
        public List() : base()
        {
        }

        /// <summary>
        /// 使用指定的 ID 初始化 List 類別的新執行個體
        /// </summary>
        /// <param name="id">清單的唯一識別碼</param>
        /// <exception cref="ArgumentException">當 ID 為空或 null 時擲出</exception>
        public List(string id) : this()
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID 不能為空", nameof(id));
            
            Id = id;
        }

        /// <summary>
        /// 執行 R5 特定的驗證
        /// </summary>
        /// <returns>驗證結果，如果驗證失敗則包含錯誤訊息</returns>
        /// <remarks>
        /// <para>
        /// R5 版本的驗證規則：
        /// - Status 必須是有效值
        /// - Mode 必須是有效值
        /// - Date 不能是未來日期（如果是 snapshot 模式）
        /// - Title 在某些模式下是必需的
        /// </para>
        /// </remarks>
        protected override System.ComponentModel.DataAnnotations.ValidationResult? ValidateVersionSpecific()
        {
            // 驗證 Status
            if (Status == null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "List.Status 是必需的");
            }

            // 驗證 Mode
            if (Mode == null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "List.Mode 是必需的");
            }

            // 驗證日期邏輯
            if (Date?.Value != null && Mode?.Value == "snapshot")
            {
                if (Date.Value > DateTime.Now)
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        "Snapshot 模式的清單日期不能是未來時間");
                }
            }

            return null;
        }

        /// <summary>
        /// 建立清單的字串表示
        /// </summary>
        /// <returns>包含清單主要資訊的字串</returns>
        public override string ToString()
        {
            var title = Title?.Value ?? "Untitled List";
            var status = Status?.Value ?? "Unknown";
            var mode = Mode?.Value ?? "Unknown";
            
            return $"List(Id: {Id}, Title: {title}, Status: {status}, Mode: {mode})";
        }
    }
}
