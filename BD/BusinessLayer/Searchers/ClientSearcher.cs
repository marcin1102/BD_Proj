using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Responses;
using DataLayer;

namespace BusinessLayer.Searchers
{
    public class ClientSearcher
    {
        public IReadOnlyCollection<ClientResponse> GetClients()
        {
            var context = new RepairContext();
            //var clients = context.Clients.ToList();
            return context.Clients.ToList().Select(c => new ClientResponse(c.FirstName, c.LastName, c.Name, c.PhoneNumber, c.Id, c.Objects)).ToList();
        }
    }
}
