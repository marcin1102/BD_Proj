using System;
using BusinessLayer.ValueObjects;
using DataLayer;

namespace BusinessLayer.Services.Client
{
    public class ClientService
    {

        public void Create(ClientData client)
        {

            var clientToCreate = new DataLayer.Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                Name = client.Name,
                PhoneNumber = client.PhoneNumber
            };
            var context = new RepairContext();
            context.Clients.Add(clientToCreate);
            context.SaveChanges();
            client.Id = clientToCreate.Id;
        }

        public void Delete(ClientData client)
        {
            throw new NotImplementedException();
        }

        public void Update(ClientData client)
        {
            throw new NotImplementedException();
        }
    }
}
