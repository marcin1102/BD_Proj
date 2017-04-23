using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Class1
    {
        public RepairContext context = new RepairContext();

        public void AddClient()
        {
            context.Clients.Add(new Client()
            {
                Id = 1,
                FirstName = "Marcin",
                LastName = "Gurbiel",
                Name = "Marcin Gurbiel",
                PhoneNumber = "123213231",
                Objects = new System.Collections.ObjectModel.ObservableCollection<Object>()
            });
            context.SaveChanges();
        }

    }
}
