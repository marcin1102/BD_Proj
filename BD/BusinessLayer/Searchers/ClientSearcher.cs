using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer.Searchers
{
    public class ClientSearcher
    {
        public async Task<IReadOnlyCollection<ClientData>> GetClients()
        {
            var context = new RepairContext();
            return context.Clients.ToList().Select(o => new ClientData
            {
                Id = o.Id,
                Name = o.Name,
                FirstName = o.FirstName,
                LastName = o.LastName,
                PhoneNumber = o.PhoneNumber,
                Objects = o.Objects.Select(x => new ObjectData
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ObjectTypeCode = x.ObjectType.Code,
                        ClientId = o.Id
                    }).ToList()
            }).ToList();
        }
    }
}
