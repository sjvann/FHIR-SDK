using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Attribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class BindAttribute : System.Attribute
    {

        public string? ComputableName { get; set; }


        /// <summary>
        /// 元素屬性設定
        /// </summary>
        /// <param name="jsonName">JSON檔所使用之名稱</param>

        public BindAttribute(string computableName)
        {
            ComputableName = computableName;
        }

    }
}
