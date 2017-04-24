using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Commands;
using DataLayer;

namespace BusinessLayer.Services
{
    public class ClientService
    {
        public int CreateClient(CreateClient command)
        {
            var clientToCreate = new Client()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Name = command.Name,
                PhoneNumber = command.PhoneNumber
            };
            var context = new RepairContext();
            context.Clients.Add(clientToCreate);
            context.SaveChanges();
            return clientToCreate.Id;
        }
    }
}
