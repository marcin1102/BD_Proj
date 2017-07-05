using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
	public class ActivitiesTypesDictionarySearcher
	{
		public ActivitiesTypesDictionarySearcher()
		{

		}

		public async Task<IReadOnlyCollection<ActivityTypeData>> GetTypes()
		{
			var db = new RepairContext();
			return db.ActivitiesTypesDictionaries.Select(entity => new ActivityTypeData
			{
				Name = entity.Name,
				Type = entity.Type
			}).ToList();
		}

		public async Task<IReadOnlyCollection<ActivityTypeData>> GetTypes(string name)
		{
			var db = new RepairContext();
			return db.ActivitiesTypesDictionaries
				.Where(entity => (!string.IsNullOrEmpty(name) ? entity.Name.ToLower().Contains(name.ToLower()) : true))
				.Select(entity => new ActivityTypeData
				{
					Name = entity.Name,
					Type = entity.Type
				}).ToList();
		}

		public async Task<ActivityTypeData> GetByCode(string code)
		{
			var db = new RepairContext();
			var activityTypeEntity = db.ActivitiesTypesDictionaries.Single(entity => entity.Type == code);

			return new ActivityTypeData()
			{
				Name = activityTypeEntity.Name,
				Type = activityTypeEntity.Type
			};
		}
	}
}
