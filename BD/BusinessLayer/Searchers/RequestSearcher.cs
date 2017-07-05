using BusinessLayer.DTO;
using DataLayer;
using DataLayer.Status;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Searchers
{
    public class RequestSearcher
    {
        private readonly RepairContext db;
        public RequestSearcher()
        {
            db = new RepairContext();
        }

        public async Task<RequestData> GetRequest(int requestId)
        {
            var request = await db.Requests.SingleAsync(x => x.Id == requestId);
            return new RequestData
            {
                Id = request.Id,
                Descr = request.Descr,
                Result = request.Result,
                Status = request.Status,
                ObjId = request.ObjId,
                Object = new ObjectData
                {
                    Id = request.Object.Id,
                    ClientId = request.Object.ClientId,
                    Name = request.Object.Name,
                    ObjectTypeCode = request.Object.Type
                },
                WorkerId = request.WorkerId,
                Worker = new WorkerData(request.Worker.Login.UName, request.Worker.FirstName, request.Worker.LastName, request.Worker.Role, request.Worker.Login.Expiration),
				Activities = request.Activities.Select(activity => new ActivityData()
				{
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					Request = activity.Request,
					WorkerId = activity.Worker.Id,
					Worker = activity.Worker
				}).ToList()
			};
        }

        public async Task<ICollection<RequestData>> GetRequests(int workerId)
        {
            var result = await db.Requests.Where(req => req.WorkerId == workerId).Select(req => new RequestData()
            {
                Id = req.Id,
                Descr = req.Descr,
                Result = req.Result,
                Status = req.Status,
                ObjId = req.ObjId,
                Object = new ObjectData
                {
                    Id = req.Object.Id,
                    ClientId = req.Object.ClientId,
                    Name = req.Object.Name,
                    ObjectTypeCode = req.Object.Type
                },
                WorkerId = req.WorkerId,
                Worker = new WorkerData
                {
                    UName = req.Worker.Login.UName,
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName,
                    Role = req.Worker.Role,
                    Expiration = req.Worker.Login.Expiration
                },
				Activities = req.Activities.Select(activity => new ActivityData()
				{
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					Request = activity.Request,
					WorkerId = activity.Worker.Id,
					Worker = activity.Worker
				}).ToList()
			}).ToListAsync();
            return result;
        }

        public async Task<ICollection<RequestData>> GetRequestsWithStatuses(ICollection<Statuses> statuses)
        {
            var result = await db.Requests.Where(req => statuses.Any(status => status.ToString() == req.Status)).Select(req => new RequestData()
            {
                Id = req.Id,
                Descr = req.Descr,
                Result = req.Result,
                Status = req.Status,
                ObjId = req.ObjId,
                Object = new ObjectData
                {
                    Id = req.Object.Id,
                    ClientId = req.Object.ClientId,
                    Name = req.Object.Name,
                    ObjectTypeCode = req.Object.Type
                },
                WorkerId = req.WorkerId,
                Worker = new WorkerData
                {
                    UName = req.Worker.Login.UName,
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName,
                    Role = req.Worker.Role,
                    Expiration = req.Worker.Login.Expiration
                },
				Activities = req.Activities.Select(activity => new ActivityData()
				{
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					Request = activity.Request,
					WorkerId = activity.Worker.Id,
					Worker = activity.Worker
				}).ToList()
			}).ToListAsync();
            return result;
        }

        public async Task<ICollection<RequestData>> GetClientRequests(int clientId)
        {
            var result = await db.Requests.Where(req => req.Object.ClientId == clientId).Select(req => new RequestData()
            {
                Id = req.Id,
                Descr = req.Descr,
                Result = req.Result,
                Status = req.Status,
                ObjId = req.ObjId,
                Object = new ObjectData
                {
                    Id = req.Object.Id,
                    ClientId = req.Object.ClientId,
                    Name = req.Object.Name,
                    ObjectTypeCode = req.Object.Type
                },
                WorkerId = req.WorkerId,
                Worker = new WorkerData
                {
                    UName = req.Worker.Login.UName,
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName,
                    Role = req.Worker.Role,
                    Expiration = req.Worker.Login.Expiration
                },
				Activities = req.Activities.Select(activity => new ActivityData()
				{
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					Request = activity.Request,
					WorkerId = activity.Worker.Id,
					Worker = activity.Worker
				}).ToList()
			}).ToListAsync();
            return result;
        }
    }
}
