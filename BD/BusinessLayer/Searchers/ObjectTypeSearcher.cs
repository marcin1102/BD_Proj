using System.Collections.Generic;
using System.Linq;
using BusinessLayer.ValueObjects;

namespace BusinessLayer.Searchers
{
    public class ObjectTypeSearcher
    {
        public IReadOnlyCollection<ObjectTypeData> GetObjectTypes()
        {
            var db = new DataLayer.RepairContext();
            return db.ObjectTypes.ToList().Select(ot => new ObjectTypeData
            {
                Code = ot.Code,
                Name = ot.Name,
                ObjectsIds = ot.Objects.Select(x => x.Id).ToList()
            }).ToList();
        }

        public ObjectTypeData GetObjectTypeByCode(string code)
        {
            var db = new DataLayer.RepairContext();
            var objectType = db.ObjectTypes.Single(ot => ot.Code == code);
            return new ObjectTypeData
            {
                Code = objectType.Code,
                Name = objectType.Name,
                ObjectsIds = objectType.Objects.Select(ot => ot.Id).ToList()
            };
        }
    }
}
