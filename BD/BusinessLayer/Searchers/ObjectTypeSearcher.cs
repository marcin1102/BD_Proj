using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Responses.ObjectType;

namespace BusinessLayer.Searchers
{
    public class ObjectTypeSearcher
    {
        public IReadOnlyCollection<ObjectTypeResponse> GetObjectTypes()
        {
            var db = new DataLayer.RepairContext();
            return db.ObjectTypes.ToList().Select(ot => new ObjectTypeResponse(ot.Code, ot.Name, ot.Objects.Select(x => x.Id).ToList())).ToList();
        }

        public ObjectTypeResponse GetObjectTypeByCode(string code)
        {
            var db = new DataLayer.RepairContext();
            var objectType = db.ObjectTypes.Single(ot => ot.Code == code);
            var objectsIds = objectType.Objects.Select(ot => ot.Id).ToList();
            return new ObjectTypeResponse(objectType.Code, objectType.Name, objectsIds);
        }
    }
}
