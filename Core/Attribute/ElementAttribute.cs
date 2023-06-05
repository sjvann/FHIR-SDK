using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ElementAttribute : System.Attribute
    {

        public string? JsonName { get; set; }
        public Type? DataType { get; set; }
        public bool IsPrimitive { get; set; }
        public bool IsMulti { get; set; }
        public bool IsChoice { get; set; }
        public bool IsBackbone { get; set; }

        /// <summary>
        /// 元素屬性設定
        /// </summary>
        /// <param name="jsonName">JSON檔所使用之名稱</param>
        /// <param name="dataType">資料型態(此模型)</param>
        /// <param name="isPrimitive">是否為初始型態</param>
        /// <param name="isMulti">是否為多項</param>
        /// <param name="isChoice">是否為Choice型態</param>
        /// <param name="isBackbone">是否為Backbone型態</param>
        public ElementAttribute(string jsonName, Type dataType, bool isPrimitive,bool isMulti, bool isChoice, bool isBackbone)
        {
            JsonName = jsonName;
            DataType = dataType;
            IsPrimitive = isPrimitive;
            IsMulti = isMulti;
            IsChoice = isChoice;
            IsBackbone = isBackbone;
        }

    }
}
