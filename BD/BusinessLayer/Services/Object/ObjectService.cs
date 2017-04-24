using System.Linq;
using BusinessLayer.Commands.Object;

namespace BusinessLayer.Services.Object
{
    public class ObjectService
    {
        public int CreateObject(CreateObject command)
        {
            var db = new DataLayer.RepairContext();
            var objectType = db.ObjectTypes.Single(x => x.Code == command.ObjectTypeCode);
            var client = db.Clients.Single(x => x.Id == command.ClientId);
            var objectToCreate = new DataLayer.Object()
            {
                Name = command.Name,
                ClientId = command.ClientId,
                Type = objectType.Code,
                Client = client,
                ObjectType = objectType
            };
            db.Objects.Add(objectToCreate);
            db.SaveChanges();
            return objectToCreate.Id;
        }
    }
}
