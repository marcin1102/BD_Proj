using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class Class1
    {
        public static RepairContext context = new RepairContext();

        public static void AddClient()
        {
            context.Clients.Add(new Client()
            {
                FirstName = "Marcin",
                LastName = "Gurbiel",
                Name = "Marcin Gurbiel",
                PhoneNumber = "123213231",
            });
        }


        public static IQueryable<Client> ShowClient()
        {
            RepairContext ctx = new RepairContext();
            var q = from el in ctx.Clients
                    select el;

            return q; 

        }
    }
}