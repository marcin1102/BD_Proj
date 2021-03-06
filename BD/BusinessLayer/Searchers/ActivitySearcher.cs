﻿using BusinessLayer.DTO;
using DataLayer;
using DataLayer.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BusinessLayer.Searchers
{
	public class ActivitySearcher
	{
		public async Task<IReadOnlyCollection<ActivityData>> GetActivities()
		{
			var context = new RepairContext();
			return context.Activities.Where(x => x.Worker.Login.UName == LoggedUser.Worker.UName).Select(activity => new ActivityData
			{
                Id = activity.Id,
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
                        }
                    },
				WorkerId = activity.WorkerId,
				Worker = activity.Worker != null ? new WorkerData
                    {
                        Id = activity.WorkerId.Value,
                        FirstName = activity.Worker.FirstName,
                        LastName = activity.Worker.LastName,
                        Role = activity.Worker.Role
                    } : null
            }).ToList();
		}

		public async Task<ICollection<ActivityData>> GetActivities(string status, int objectId)
		{
			var context = new RepairContext();
			return context.Activities
					.Where(activity => string.IsNullOrEmpty(status) ? true : activity.Status == status && activity.Request.ObjId == objectId)
					.Select(activity => new ActivityData()
					{
                        Id = activity.Id,
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
                                }
                            },
						WorkerId = activity.Worker.Id,
                        Worker = activity.Worker != null ? new WorkerData
                        {
                            Id = activity.WorkerId.Value,
                            FirstName = activity.Worker.FirstName,
                            LastName = activity.Worker.LastName,
                            Role = activity.Worker.Role
                        } : null
                    }).ToList();
		}

		public async Task<ICollection<ActivityData>> GetActivities(string status)
		{
			var context = new RepairContext();
			return context.Activities
					.Where(activity => string.IsNullOrEmpty(status) ? true : activity.Status == status)
					.Select(activity => new ActivityData()
					{
                        Id = activity.Id,
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
                                }
                            },
						WorkerId = activity.Worker.Id,
                        Worker = activity.Worker != null ? new WorkerData
                        {
                            Id = activity.WorkerId.Value,
                            FirstName = activity.Worker.FirstName,
                            LastName = activity.Worker.LastName,
                            Role = activity.Worker.Role
                        } : null
                    }).ToList();
		}

        public Task<ActivityData> GetActivity(int id)
        {
            var context = new RepairContext();
            return context.Activities
                    .Where(activity => activity.Id == id)
                    .Select(activity => new ActivityData()
                    {
                        Id = activity.Id,
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
                            }
                        },
                        WorkerId = activity.Worker.Id,
                        Worker = activity.Worker != null ? new WorkerData
                        {
                            Id = activity.WorkerId.Value,
                            FirstName = activity.Worker.FirstName,
                            LastName = activity.Worker.LastName,
                            Role = activity.Worker.Role
                        } : null
                    }).SingleAsync();
        }
    }
}
