using BusinessLayer.DTO;
using BusinessLayer.Exceptions;
using BusinessLayer.Helpers;
using DataLayer;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class LoginService
    {
        public Task Register(WorkerData workerToCreate)
        {
            var db = new RepairContext();
            if (workerToCreate == null)
                throw new EntityCreationFailure("User data cannot be null");

            var worker = new Worker()
            {
                FirstName = workerToCreate.FirstName,
                LastName = workerToCreate.LastName,
                Role = workerToCreate.Role
            };
            db.Workers.Add(worker);

            var pass = workerToCreate.Pass.GetPasswordHash();

            var login = new Login()
            {
                UName = workerToCreate.UName,
                Pass = pass,
                Worker = worker,
                WorkerId = worker.Id
            };
            db.Logins.Add(login);

            return db.SaveChangesAsync();
        }

        public async Task<bool> LoginAsync(string uName, string pass)
        {
            //Temporary solution for super user
            if (uName == "admin" && pass == "admin")
                return true;

            var db = new RepairContext();

            if (string.IsNullOrEmpty(uName))
                throw new ValueCannotBeNull("User name cannot be null or empty");

            if(string.IsNullOrEmpty(pass))
                throw new ValueCannotBeNull("Password cannot be null or empty");

            var user = await db.Logins.SingleAsync(x => x.UName == uName);

            if (user.Expiration != null && user.Expiration.Value.Date >= DateTime.Today)
                throw new WorkerAccountExpire($"Worker account with login {uName} expired.");

            return pass.ComparePasswordWithHash(user.Pass);
        }

        public async Task SetExpiration(string uName, DateTime expiration)
        {
            var db = new RepairContext();
            var login = db.Logins.SingleOrDefault(x => x.UName == uName);
            if (login == null)
                throw new EntityDoesNotExist($"Worker with login {uName} does not exist");

            if (login.Expiration != expiration)
            {
                login.Expiration = expiration;
                await db.SaveChangesAsync();
            }
        }
    }
}
