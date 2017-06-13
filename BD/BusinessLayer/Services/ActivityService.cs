namespace BusinessLayer.Services.Activity
{
    public class ActivityService
    {
        public async void Create(ActivityData activity)
        {

            var request = await db.Requests.SingleAsync(x => x.Id == activity.ReqId);
            var worker = await db.Workers.SingleAsync(x => x.Id == activity.WorkerId);
            var activityToCreate = new DataLayer.Activity()
            {
                Descr = activity.Descr,
				Status = activity.Status,
				Result = activity.Result,
				ReqId = activity.ReqId,
				Request = request,
				Type = activity.Type,
				WorkerId = activity.WorkerId,
				Worker = worker,

				//ActivitiesTypesDictionary = activity.ActivitiesTypesDictionary,

            };
            var context = new RepairContext();
            context.Activities.Add(activityToCreate);
            await context.SaveChangesAsync();
            client.Id = clientToCreate.Id;
        }

        public Task Delete(int ActivityId)
        {
            var context = new RepairContext();
            var activity = context.Activities.Single(x => x.Id == ActivityId);
            context.Activities.Remove(activity);
            return context.SaveChangesAsync();
        }

        public async Task UpdateDetails(ActivityData activity)
        {
            var context = new RepairContext();
			var request = await db.Requests.SingleAsync(x => x.Id == activity.ReqId);
            var worker = await db.Workers.SingleAsync(x => x.Id == activity.WorkerId);
            var activityEntity = await context.Activities.SingleAsync(x => x.Id == activity.Id);
			activityEntity.Descr = activity.Descr,
			activityEntity.Status = activity.Status,
			activityEntity.Result = activity.Result,
			activityEntity.ReqId = activity.ReqId,
			activityEntity.Request = request,
			activityEntity.Type = activity.Type,
			activityEntity.WorkerId = activity.WorkerId,
			activityEntity.Worker = worker,
            await context.SaveChangesAsync();
        }

        [Obsolete("Update many objects of single client in the same time. Use update of single object instead.")]
        public async Task UpdateObjects(int clientId, ICollection<ObjectData> objects)
        {
            var db = new RepairContext();
            var client = db.Clients.SingleOrDefault(x => x.Id == clientId);
            var clientObjects = client.Objects.ToList();
            var objectsToDelete = clientObjects.Where(x => !objects.Any(o => o.Id == x.Id)).ToList();
            var objectsToAdd = objects.Where(x => !clientObjects.Any(o => o.Id == x.Id)).Select(x => new DataLayer.Object
            {
                Name = x.Name,
                ClientId = x.ClientId,
                Type = x.ObjectTypeCode,
                Client = client,
                ObjectType = db.ObjectTypes.Single(ot => ot.Code == x.ObjectTypeCode)
            }).ToList();
            var objectsToUpdate = clientObjects.Where(x => objects.Any(o => o.Id == x.Id)).ToList();

            db.Objects.RemoveRange(objectsToDelete);

            foreach (var objectToAdd in objectsToAdd)
            {
                client.Objects.Add(objectToAdd);
            }

            foreach (var objectToUpdate in objectsToUpdate)
            {
                var data = objects.Single(x => x.Id == objectToUpdate.Id);
                objectToUpdate.Name = data.Name;
                if(objectToUpdate.Type != data.ObjectTypeCode)
                {
                    var newObjectType = await db.ObjectTypes.SingleAsync(x => x.Code == data.ObjectTypeCode);
                    objectToUpdate.ObjectType = newObjectType;
                }
            }
            await db.SaveChangesAsync();
        }
    }
}
