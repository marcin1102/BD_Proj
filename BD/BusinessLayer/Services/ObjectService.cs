using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.ValueObjects;

namespace BusinessLayer.Services.Object
{
    public class ObjectService
    {
        public async Task CreateObject(ObjectData objectData)
        {
            var db = new DataLayer.RepairContext();
            var objectType = await db.ObjectTypes.SingleAsync(x => x.Code == objectData.ObjectTypeCode);
            var client = await db.Clients.SingleAsync(x => x.Id == objectData.ClientId);
            var objectToCreate = new DataLayer.Object()
            {
                Name = objectData.Name,
                ClientId = objectData.ClientId,
                Client = client,
                ObjectType = objectType
            };
            db.Objects.Add(objectToCreate);
            await db.SaveChangesAsync();
            objectData.Id = objectToCreate.Id;
        }

        public async Task UpdateObjectDetails(ObjectData objectData)
        {
            var db = new DataLayer.RepairContext();
            var objectToUpdate = await db.Objects.SingleAsync(x => x.Id == objectData.Id);
            if(!string.IsNullOrEmpty(objectData.ObjectTypeCode) && objectData.ObjectTypeCode != objectToUpdate.Type)
            {
                var newObjectType = await db.ObjectTypes.SingleAsync(x => x.Code == objectData.ObjectTypeCode);
                objectToUpdate.ObjectType = newObjectType;
            }
            objectToUpdate.Name = objectData.Name;
            await db.SaveChangesAsync();
        }

        public async Task UpdateObjectType(ObjectData objectData)
        {
            var db = new DataLayer.RepairContext();
            var objectToUpdate = await db.Objects.SingleAsync(x => x.Id == objectData.Id);
            objectToUpdate.ObjectType = await db.ObjectTypes.SingleAsync(x => x.Code == objectData.ObjectTypeCode);
            await db.SaveChangesAsync();
        }
    }
}
