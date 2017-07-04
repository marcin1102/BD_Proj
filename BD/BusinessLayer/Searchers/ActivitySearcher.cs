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
	class ActivitySearcher
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
				Request = activity.Request,
				WorkerId = activity.Worker.Id,
				Worker = activity.Worker
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
						Request = activity.Request,
						WorkerId = activity.Worker.Id,
						Worker = activity.Worker
					}).ToList();
		}
	}
}
