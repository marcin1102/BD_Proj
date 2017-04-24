using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Responses.Client;
using BusinessLayer.Responses.Object;
using DataLayer;

namespace BusinessLayer.Searchers
{
    public class ClientSearcher
    {
        public IReadOnlyCollection<ClientResponse> GetClients()
        {
            var context = new RepairContext();
            return context.Clients.ToList().Select(c => new ClientResponse(c.FirstName, c.LastName, c.Name, c.PhoneNumber, c.Id, c.Objects.Select(o => new ObjectResponse(o.Id, o.Name, o.Type, o.ClientId, o.Type)).ToList())).ToList();
        }
    }
}
