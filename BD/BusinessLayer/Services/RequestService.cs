using BusinessLayer.DTO;
using BusinessLayer.Exceptions;
using DataLayer;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class RequestService
    {
        private readonly RepairContext db;
        public RequestService()
        {
            db = new RepairContext();
        }

        public Task CreateRequest(RequestData requestToAdd)
        {
            if (requestToAdd == null)
                throw new EntityCreationFailure("Request cannot be null");

            var @object = db.Objects.Single(x => x.Id == requestToAdd.ObjId);

            var request = new Request()
            {
                Descr = requestToAdd.Descr,
                Object = @object,
                Status = Statuses.OPN.ToString()
            };
            db.Requests.Add(request);
            return db.SaveChangesAsync(); 
        }

        public async Task UpdateDescription(int requestId, string descr)
        {
            var request = db.Requests.Single(x => x.Id == requestId);
            if(request.Descr != descr)
            {
                request.Descr = descr;
                await db.SaveChangesAsync();
            }
        }

        public Task SetRequestStatus(int requestId, Statuses newStatus)
        {
            var request = db.Requests.Single(x => x.Id == requestId);
            request.Status = newStatus.ToString();
            return db.SaveChangesAsync();
        }

        public async Task SetRequestResult(int requestId, string result)
        {
            var request = db.Requests.Single(x => x.Id == requestId);
            if(request.Result != result)
            {
                request.Result = result;
                await db.SaveChangesAsync();
            }
        }
    }
}
