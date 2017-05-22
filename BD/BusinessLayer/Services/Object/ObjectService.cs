using System.Linq;
using BusinessLayer.ValueObjects;

namespace BusinessLayer.Services.Object
{
    public class ObjectService
    {
        public void CreateObject(ObjectData objectData)
        {
            var db = new DataLayer.RepairContext();
            var objectType = db.ObjectTypes.Single(x => x.Code == objectData.ObjectTypeCode);
            var client = db.Clients.Single(x => x.Id == objectData.ClientId);
            var objectToCreate = new DataLayer.Object()
            {
                Name = objectData.Name,
                ClientId = objectData.ClientId,
                Type = objectType.Code,
                Client = client,
                ObjectType = objectType
            };
            db.Objects.Add(objectToCreate);
            db.SaveChanges();
            objectData.Id = objectToCreate.Id;
        }
    }
}
