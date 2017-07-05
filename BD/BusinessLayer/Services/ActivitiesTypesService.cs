using BusinessLayer.DTO;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
	public class ActivitiesTypesService
	{
		public ActivitiesTypesService()
		{

		}

		public void Create(ActivityTypeData data)
		{
			var db = new RepairContext();
			var entity = new ActivitiesTypesDictionary()
			{
				Name = data.Name,
				Type = data.Type
			};
			db.ActivitiesTypesDictionaries.Add(entity);
		}
	}
}
