using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Responses.ObjectType
{
    public class ObjectTypeResponse
    {
        public ObjectTypeResponse(string code, string name, IReadOnlyCollection<int> objectsIds)
        {
            Code = code;
            Name = name;
            ObjectsIds = objectsIds;
        }

        public string Code { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyCollection<int> ObjectsIds { get; private set; }
    }
}
