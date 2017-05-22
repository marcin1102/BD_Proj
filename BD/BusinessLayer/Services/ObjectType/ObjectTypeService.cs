using BusinessLayer.ValueObjects;

namespace BusinessLayer.Services.ObjectType
{
    public class ObjectTypeService
    {
        public void CreateObjectType(ObjectTypeData objectTypeData)
        {
            var objectType = new DataLayer.ObjectType()
            {
                Name = objectTypeData.Name,
                Code = objectTypeData.Code
            };
            var db = new DataLayer.RepairContext();
            db.ObjectTypes.Add(objectType);
            db.SaveChanges();
        }
    }
}
