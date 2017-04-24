using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Responses.Object;

namespace BusinessLayer.Searchers
{
    public class ObjectSearcher
    {
        public IReadOnlyCollection<ObjectResponse> GetObjects()
        {
            var db = new DataLayer.RepairContext();
            return db.Objects.ToList().Select(o => new ObjectResponse(o.Id, o.Name, o.Type, o.ClientId, o.Type)).ToList();
        }

        public IReadOnlyCollection<ObjectResponse> GetObjectsByClientId(int clientId)
        {
            var db = new DataLayer.RepairContext();
            return db.Objects.Where(o => o.ClientId == clientId).ToList().Select(o => new ObjectResponse(o.Id, o.Name, o.Type, o.ClientId, o.Type)).ToList();
        }
    }
}
