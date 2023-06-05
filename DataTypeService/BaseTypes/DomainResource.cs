using DataTypeService.Special;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeService.BaseTypes
{
    public abstract class DomainResource: Resource
    {
        public Narrative? Text { get; set; }
        public IEnumerable<Resource>? Contained { get; set; }
        public IEnumerable<Extension>? Extension { get; set; }
        public IEnumerable<Extension>? ModifierExtension { get; set; }

    }
}
