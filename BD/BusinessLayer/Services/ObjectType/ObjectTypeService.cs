using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Commands.ObjectType;

namespace BusinessLayer.Services.ObjectType
{
    public class ObjectTypeService
    {
        public void CreateObjectType(CreateObjectType command)
        {
            var objectType = new DataLayer.ObjectType()
            {
                Name = command.Name,
                Code = command.Code
            };
            var db = new DataLayer.RepairContext();
            db.ObjectTypes.Add(objectType);
            db.SaveChanges();
        }
    }
}
