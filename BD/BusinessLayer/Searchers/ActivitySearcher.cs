using BusinessLayer.DTO;
using DataLayer;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Searchers
{
	public class ActivitySearcher
	{
		public async Task<IReadOnlyCollection<ActivityData>> GetActivities()
		{
			var context = new RepairContext();
			return context.Activities.Select(activity => new ActivityData
			{
				Type = activity.Type,
				Descr = activity.Descr,
				Status = activity.Status,
				Result = activity.Result,
				ReqId = activity.Request.Id,
				Request = new RequestData
                    {
                        Id = activity.Request.Id,
                        Descr = activity.Request.Descr,
                        Result = activity.Request.Result,
                        Status = activity.Request.Status,
                        ObjId = activity.Request.ObjId,
                        WorkerId = activity.Request.WorkerId,
                        Object = new ObjectData
                        {
                            Id = activity.Request.ObjId,
                            ClientId = activity.Request.Object.ClientId,
                            Name = activity.Request.Object.Name,
                            ObjectTypeCode = activity.Request.Object.Type
                        },
                        Worker = new WorkerData
                        {
                            Id = activity.Request.WorkerId.Value,
                            FirstName = activity.Request.Worker.FirstName,
                            LastName = activity.Request.Worker.LastName,
                            Role = activity.Request.Worker.Role
                        }
                    },
				WorkerId = activity.Worker.Id,
				Worker = new WorkerData
                    {
                        Id = activity.WorkerId.Value,
                        FirstName = activity.Worker.FirstName,
                        LastName = activity.Worker.LastName,
                        Role = activity.Worker.Role
                    }
            }).ToList();
		}

		public async Task<ICollection<ActivityData>> GetActivities(string status, int objectId)
		{
			var context = new RepairContext();
			return context.Activities
					.Where(activity => activity.Status == status && activity.Request.ObjId == objectId)
					.Select(activity => new ActivityData()
					{
						Type = activity.Type,
						Descr = activity.Descr,
						Status = activity.Status,
						Result = activity.Result,
						ReqId = activity.Request.Id,
						Request = new RequestData
                            {
                                Id = activity.Request.Id,
                                Descr = activity.Request.Descr,
                                Result = activity.Request.Result,
                                Status = activity.Request.Status,
                                ObjId = activity.Request.ObjId,
                                WorkerId = activity.Request.WorkerId,
                                Object = new ObjectData
                                {
                                    Id = activity.Request.ObjId,
                                    ClientId = activity.Request.Object.ClientId,
                                    Name = activity.Request.Object.Name,
                                    ObjectTypeCode = activity.Request.Object.Type
                                },
                                Worker = new WorkerData
                                {
                                    Id = activity.Request.WorkerId.Value,
                                    FirstName = activity.Request.Worker.FirstName,
                                    LastName = activity.Request.Worker.LastName,
                                    Role = activity.Request.Worker.Role
                                }
                            },
						WorkerId = activity.Worker.Id,
						Worker = new WorkerData
                        {
                            Id = activity.WorkerId.Value,
                            FirstName = activity.Worker.FirstName,
                            LastName = activity.Worker.LastName,
                            Role = activity.Worker.Role
                        }
                    }).ToList();
		}

		public async Task<ICollection<ActivityData>> GetActivities(string status)
		{
			var context = new RepairContext();
			return context.Activities
					.Where(activity => activity.Status == status)
					.Select(activity => new ActivityData()
					{
						Type = activity.Type,
						Descr = activity.Descr,
						Status = activity.Status,
						Result = activity.Result,
						ReqId = activity.Request.Id,
						Request = new RequestData
                            {
                                Id = activity.Request.Id,
                                Descr = activity.Request.Descr,
                                Result = activity.Request.Result,
                                Status = activity.Request.Status,
                                ObjId = activity.Request.ObjId,
                                WorkerId = activity.Request.WorkerId,
                                Object = new ObjectData
                                {
                                    Id = activity.Request.ObjId,
                                    ClientId = activity.Request.Object.ClientId,
                                    Name = activity.Request.Object.Name,
                                    ObjectTypeCode = activity.Request.Object.Type
                                },
                                Worker = new WorkerData
                                {
                                    Id = activity.Request.WorkerId.Value,
                                    FirstName = activity.Request.Worker.FirstName,
                                    LastName = activity.Request.Worker.LastName,
                                    Role = activity.Request.Worker.Role
                                }
                            },
						WorkerId = activity.Worker.Id,
						Worker = new WorkerData
                        {
                            Id = activity.WorkerId.Value,
                            FirstName = activity.Worker.FirstName,
                            LastName = activity.Worker.LastName,
                            Role = activity.Worker.Role
                        }
                    }).ToList();
		}
    }
}
