using DataTypeHelper.Choice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeHelper.Complex
{
    public class AnnotationHelper
    {
        public AuthorChoiceHelper? Author { get; init; }
        public DateTime? Time { get; init; }
        public string? Text { get; init; }
    }
}
