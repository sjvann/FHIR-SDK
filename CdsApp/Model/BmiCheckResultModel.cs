using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdsApp.Model
{
    public class BmiCheckResultModel
    {
        public DateTime? Effective { get; set; }
        public decimal? Value { get; set; }
        public string? Result { get; set; }
    }
}

