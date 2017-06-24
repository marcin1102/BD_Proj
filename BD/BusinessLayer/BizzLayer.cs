using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class WorkerFacade
    {
        public static void AddWorker(Worker entity)
        {
            using (var context = new RepairContext())
            {
                context.Workers.Add(entity);
                context.SaveChanges();
            }
        }
        public static IEnumerable<Worker> GetWorkers(Worker searchCrit)
        {
            using (var context = new RepairContext())
            {
                return context.Workers.ToList();
            }
        }
    }
    public static class ClientFacade
    {        public static IEnumerable<Client> GetClients(Worker searchCrit)
        {
            using (var context = new RepairContext())
            {
                return context.Clients.ToList();
            }
        }
    }
}
