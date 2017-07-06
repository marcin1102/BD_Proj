using BusinessLayer.DTO;
using DataLayer;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Status;

namespace BusinessLayer.Services.Activity
{
    public class ActivityService
	{
		private readonly RepairContext db;

		public ActivityService()
		{
			db = new RepairContext();
		}

		public async Task Create(ActivityData activity)
        {
            var request = await db.Requests.SingleAsync(entity => entity.Id == activity.ReqId);
			var worker = activity.WorkerId != null ? db.Workers.Single(entity => entity.Id == activity.WorkerId) : null;

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
			var request = db.Requests.Single(entity => entity.Id == activity.ReqId);
			var worker = activity.WorkerId != null ? db.Workers.Single(entity => entity.Id == activity.WorkerId) : null;

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

        public async Task FinishOrCancel(int activityId, string result, bool isFinished)
        {
            var activityEntity = await db.Activities.SingleAsync(entity => entity.Id == activityId);
            activityEntity.Result = result;
            activityEntity.Status = isFinished ? Statuses.DON.ToString() : Statuses.CNL.ToString();
            await db.SaveChangesAsync();
        }
    }
}
