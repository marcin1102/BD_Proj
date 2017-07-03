using BusinessLayer.DTO;
using DataLayer;
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
	}
}
