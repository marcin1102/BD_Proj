using BusinessLayer.DTO;
using BusinessLayer.Exceptions;
using BusinessLayer.Helpers;
using DataLayer;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class WorkerService
    {
        public async Task UpdateWorker(WorkerData update)
        {
            var db = new RepairContext();
            var worker = db.Workers.SingleOrDefault(x => x.Id == update.Id);
            if (worker == null)
                throw new EntityDoesNotExist($"Worker with id {update.Id} does not exist");

            worker.UpdateData(update.FirstName, update.LastName, update.Role);
            await db.SaveChangesAsync();
        }

        public async Task UpdateWorkerData(WorkerData update)
        {
            var db = new RepairContext();
            var worker = db.Workers.SingleOrDefault(x => x.Login.UName == update.UName);
            if (worker == null)
                throw new EntityDoesNotExist($"Worker with login {update.UName} does not exist");

            worker.UpdateData(update.FirstName, update.LastName, update.Role);

            if(worker.Login.Pass != update.Pass)
            {
                var newPass = update.Pass.GetPasswordHash();
            }

            await db.SaveChangesAsync();
        }
    }
}
