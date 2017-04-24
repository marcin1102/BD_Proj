using BusinessLayer.Commands.Client;
using DataLayer;

namespace BusinessLayer.Services.Client
{
    public class ClientService
    {
        public int CreateClient(CreateClient command)
        {
            var clientToCreate = new DataLayer.Client()
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
