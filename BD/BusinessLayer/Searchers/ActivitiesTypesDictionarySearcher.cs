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
	}
}
