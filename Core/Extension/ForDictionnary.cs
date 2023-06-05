using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extension
{
    public static class ForDictionary
    {
        public static Dictionary<string, object> Append(this Dictionary<string, object> target, Dictionary<string, object>? source)
        {
            if (source != null && source.Any())
            {
                foreach (var item in source)
                {
                    if (!target.ContainsKey(item.Key))
                    {
                        target.Add(item.Key, item.Value);
                    }
                }
            }
            return target;
        }
    }
}
