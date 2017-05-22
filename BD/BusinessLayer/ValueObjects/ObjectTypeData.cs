using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValueObjects
{
    public class ObjectTypeData
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<int> ObjectsIds { get; set; }
    }
}
