using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Responses.Object
{
    public class ObjectResponse
    {
        public ObjectResponse(int id, string name, string type, int clientId, string objectTypeCode)
        {
            Id = id;
            Name = name;
            Type = type;
            ClientId = clientId;
            ObjectTypeCode = objectTypeCode;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int ClientId { get; private set; }           
        public string ObjectTypeCode { get; private set; }
    }
}
