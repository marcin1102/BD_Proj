using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValueObjects
{
    public class ObjectData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ClientId { get; set; }
        public string ObjectTypeCode { get; set; }
    }
}
