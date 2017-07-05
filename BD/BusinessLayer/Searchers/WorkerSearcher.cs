using BusinessLayer.DTO;
using BusinessLayer.Helpers;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Searchers
{
    public class WorkerSearcher
    {
        public async Task<IReadOnlyCollection<WorkerData>> FullTextSearch(string text)
        {
            var words = text?.Split(' ');

            var db = new RepairContext();
            var workers = new List<Worker>();

            if(words != null)
            {
                foreach (var word in words)
                {
                    if (workers.Count == 0)
                        workers = await db.Workers.Where(worker => !string.IsNullOrEmpty(word) ? worker.FirstName.Contains(word) : true ||
                                                            !string.IsNullOrEmpty(word) ? worker.LastName.Contains(word) : true ||
                                                            !string.IsNullOrEmpty(word) ? worker.Login.UName.Contains(word) : true).ToListAsync();
                    else
                        workers = workers.Where(worker => !string.IsNullOrEmpty(word) ? worker.FirstName.Contains(word) : true ||
                                                            !string.IsNullOrEmpty(word) ? worker.LastName.Contains(word) : true ||
                                                            !string.IsNullOrEmpty(word) ? worker.Login.UName.Contains(word) : true).ToList();
                }
            }

            return workers.Select(x => new WorkerData(x.Login.UName, x.FirstName, x.LastName, x.Role, x.Login.Expiration)
            {
                Id = x.Id
            }).ToList();
        }

        public async Task<WorkerData> GetByLogin(string uName)
        {
            var db = new RepairContext();
            var login = await db.Logins.SingleAsync(x => x.UName == uName);
            var worker = login.Worker;
            return new WorkerData(login.UName, login.Pass, worker.FirstName, worker.LastName, worker.Role, login.Expiration)
            {
                Id = worker.Id
            };
        }
    }
}
