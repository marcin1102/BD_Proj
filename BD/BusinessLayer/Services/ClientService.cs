using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.ValueObjects;
using DataLayer;

namespace BusinessLayer.Services.Client
{
    public class ClientService
    {
        public async void Create(ClientData client)
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
            await context.SaveChangesAsync();
            client.Id = clientToCreate.Id;
        }

        public Task Delete(int ClientId)
        {
            var context = new RepairContext();
            var client = context.Clients.Single(x => x.Id == ClientId);
            context.Clients.Remove(client);
            return context.SaveChangesAsync();
        }

        public async Task UpdateDetails(ClientData client)
        {
            var context = new RepairContext();
            var clientEntity = await context.Clients.SingleAsync(x => x.Id == client.Id);
            clientEntity.FirstName = client.FirstName;
            clientEntity.LastName = client.LastName;
            clientEntity.Name = client.Name;
            clientEntity.PhoneNumber = client.PhoneNumber;
            await context.SaveChangesAsync();
        }

        [Obsolete("Update many objects of single client in the same time. Use update of single object instead.")]
        public Task UpdateObjects(int clientId, ICollection<ObjectData> objects)
        {
            var context = new RepairContext();
            var client = context.Clients.SingleOrDefault(x => x.Id == clientId);
            var clientObjects = client.Objects.ToList();
            var objectsToDelete = clientObjects.Where(x => !objects.Any(o => o.Id == x.Id)).ToList();
            var objectsToAdd = objects.Where(x => !clientObjects.Any(o => o.Id == x.Id)).Select(x => new DataLayer.Object
            {
                Name = x.Name,
                ClientId = x.ClientId,
                Type = x.Type,
                Client = client,
                ObjectType = context.ObjectTypes.Single(ot => ot.Code == x.ObjectTypeCode)
            }).ToList();
            var objectsToUpdate = clientObjects.Where(x => objects.Any(o => o.Id == x.Id)).ToList();

            clientObjects.RemoveAll(x => objectsToDelete.Any(o => x.Id == o.Id));
            clientObjects.AddRange(objectsToAdd);
            foreach (var objectToUpdate in objectsToUpdate)
            {
                var data = objects.Single(x => x.Id == objectToUpdate.Id);
                objectToUpdate.Name = data.Name;
                objectToUpdate.Type = data.Type;   
            }
            return context.SaveChangesAsync();
        }
    }
}
