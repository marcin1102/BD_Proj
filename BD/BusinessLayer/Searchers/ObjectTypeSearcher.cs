using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.DTO;

namespace BusinessLayer.Searchers
{
    public class ObjectTypeSearcher
    {
        public async Task<IReadOnlyCollection<ObjectTypeData>> GetObjectTypes()
        {
            var db = new DataLayer.RepairContext();
            return db.ObjectTypes.ToList().Select(ot => new ObjectTypeData
            {
                Code = ot.Code,
                Name = ot.Name,
                ObjectsIds = ot.Objects.Select(x => x.Id).ToList()
            }).ToList();
        }

        public async Task<ObjectTypeData> GetObjectTypeByCode(string code)
        {
            var db = new DataLayer.RepairContext();
            var objectType = await db.ObjectTypes.SingleAsync(ot => ot.Code == code);
            return new ObjectTypeData
            {
                Code = objectType.Code,
                Name = objectType.Name,
                ObjectsIds = objectType.Objects.Select(ot => ot.Id).ToList()
            };
        }
    }
}
