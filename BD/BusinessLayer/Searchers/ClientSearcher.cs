using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;
using System;
using System.Data.Entity;

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

        public async Task<ICollection<ClientData>> SearchClients(string firstName, string lastName, string phoneNumber)
        {
            var context = new RepairContext();
            var result = await context.Clients
                    .Where(x => (!string.IsNullOrEmpty(firstName) ? x.FirstName.ToLower() == firstName.ToLower() : true) &&
                                (!string.IsNullOrEmpty(lastName) ? x.LastName.ToLower().ToLower() == lastName.ToLower() : true) &&
                                (!string.IsNullOrEmpty(phoneNumber) ? x.PhoneNumber == phoneNumber.ToLower() : true))
                    .Select(o => new ClientData
                        {
                            Id = o.Id,
                            Name = o.Name,
                            FirstName = o.FirstName,
                            LastName = o.LastName,
                            PhoneNumber = o.PhoneNumber
                        })
                    .ToListAsync();
            return result;
        }
    }
}
