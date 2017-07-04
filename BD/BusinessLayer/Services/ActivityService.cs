using BusinessLayer.DTO;
using DataLayer;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Activity
{
    public class ActivityService
	{
		private readonly RepairContext db;

		ActivityService()
		{
			db = new RepairContext();
		}

		public async void Create(ActivityData activity)
        {
            var request = await db.Requests.SingleAsync(entity => entity.Id == activity.ReqId);
            var worker = await db.Workers.SingleAsync(entity => entity.Id == activity.WorkerId);

            var activityToCreate = new DataLayer.Activity()
            {
				Type = activity.Type,
				Descr = activity.Descr,
				Status = activity.Status,
				Result = activity.Result,
				ReqId = activity.ReqId,
				Request = request,
				WorkerId = activity.WorkerId,
				Worker = worker
            };

			db.Activities.Add(activityToCreate);
            await db.SaveChangesAsync();
        }

        public async Task UpdateDetails(ActivityData activity)
        {
			var request = await db.Requests.SingleAsync(entity => entity.Id == activity.ReqId);
            var worker = await db.Workers.SingleAsync(entity => entity.Id == activity.WorkerId);

            var activityEntity = await db.Activities.SingleAsync(entity => entity.Id == activity.Id);

			activityEntity.Type = activity.Type;
			activityEntity.Descr = activity.Descr;
			activityEntity.Status = activity.Status;
			activityEntity.Result = activity.Result;
			activityEntity.ReqId = activity.ReqId;
			activityEntity.Request = request;
			activityEntity.WorkerId = activity.WorkerId;
			activityEntity.Worker = worker;

            await db.SaveChangesAsync();
        }
		public Task Delete(int activityId)
		{
			var activity = db.Activities.Single(entity => entity.Id == activityId);
			db.Activities.Remove(activity);
			return db.SaveChangesAsync();
		}
	}
}