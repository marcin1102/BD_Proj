using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Class1
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


        //public static IQueryable<Client> ShowClient()
        //{
        //    var clientSearcher = new ClientSearcher();
        //    return clientSearcher.GetClients(); 

        //}
    }
}