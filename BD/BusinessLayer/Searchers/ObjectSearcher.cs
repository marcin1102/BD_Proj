using System.Collections.Generic;
using System.Linq;
using BusinessLayer.ValueObjects;

namespace BusinessLayer.Searchers
{
    public class ObjectSearcher
    {
        public IReadOnlyCollection<ObjectData> GetObjects()
        {
            var db = new DataLayer.RepairContext();
            return db.Objects.ToList().Select(o => new ObjectData
            {
                Id = o.Id,
                Name = o.Name,
                Type = o.Type,
                ClientId = o.ClientId, 
                ObjectTypeCode = o.ObjectType.Code
            }).ToList();
        }

        public IReadOnlyCollection<ObjectData> GetObjectsByClientId(int clientId)
        {
            var db = new DataLayer.RepairContext();
            return db.Objects.Where(o => o.ClientId == clientId).ToList().Select(o => new ObjectData
            {
                Id = o.Id,
                Name = o.Name,
                Type = o.Type,
                ClientId = o.ClientId,
                ObjectTypeCode = o.ObjectType.Code
            }).ToList();
        }

        public ObjectData GetObject(int objectId)
        {
            var db = new DataLayer.RepairContext();
            var objectEntity = db.Objects.SingleOrDefault(x => x.Id == objectId);
            return new ObjectData
            {
                Id = objectEntity.Id,
                Name = objectEntity.Name,
                Type = objectEntity.Type,
                ClientId = objectEntity.ClientId,
                ObjectTypeCode = objectEntity.ObjectType.Code
            };
        }
    }
}
