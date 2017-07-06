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
            return await db.Requests.Where(x => x.Id == requestId).Select(request => new RequestData
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
                Worker = new WorkerData()
                {
                    FirstName = request.Worker.FirstName,
                    LastName = request.Worker.LastName
                },
				Activities = request.Activities.Select(activity => new ActivityData()
				{
                    Id = activity.Id,
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = request.Id,
					WorkerId = activity.WorkerId
                }).ToList()
			}).SingleAsync();
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
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName,
                    Role = req.Worker.Role
                },
				Activities = req.Activities.Select(activity => new ActivityData()
				{
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					WorkerId = activity.Worker.Id,
                    Worker = activity.WorkerId != null ? new WorkerData
                    {
                        FirstName = activity.Worker.FirstName,
                        LastName = activity.Worker.LastName
                    } : null
                }).ToList()
			}).ToListAsync();
            return result;
        }

        public async Task<ICollection<RequestData>> GetRequestsWithStatuses(ICollection<string> statuses)
        {
            var result = await db.Requests.Where(req => statuses.Any(status => status == req.Status)).Select(req => new RequestData()
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
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName
                },
				Activities = req.Activities.Select(activity => new ActivityData()
				{
                    Id = activity.Id,
					Type = activity.Type,
					Descr = activity.Descr,
					Status = activity.Status,
					Result = activity.Result,
					ReqId = activity.Request.Id,
					WorkerId = activity.WorkerId
                }).ToList()
			}).ToListAsync();
            return result;
        }

        public async Task<ICollection<RequestData>> GetClientRequests(int clientId, ICollection<string> statuses)
        {
            var result = await db.Requests.Where(req => req.Object.ClientId == clientId && statuses.Any(x => x == req.Status)).Select(req => new RequestData()
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
                Worker = new WorkerData()
                {
                    Id = req.WorkerId.Value,
                    FirstName = req.Worker.FirstName,
                    LastName = req.Worker.LastName,
                    Role = req.Worker.Role,
                },
                Activities = req.Activities.Select(activity => new ActivityData()
                {
                    Id = activity.Id,
                    Type = activity.Type,
                    Descr = activity.Descr,
                    Status = activity.Status,
                    Result = activity.Result,
                    ReqId = activity.Request.Id,
                    WorkerId = activity.WorkerId,
                    Worker = activity.WorkerId != null ? new WorkerData
                    {
                        FirstName = activity.Worker.FirstName,
                        LastName = activity.Worker.LastName
                    } : null
                }).ToList()
            }).ToListAsync();
            return result;
        }
    }
}
