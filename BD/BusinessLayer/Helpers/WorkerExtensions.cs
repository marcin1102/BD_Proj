using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Helpers
{
    public static class WorkerExtensions
    {
        public static bool FieldsContains(this Worker worker, string word)
        {
            return worker.FirstName.Contains(word) ||
                worker.LastName.Contains(word) ||
                worker.Login.UName.Contains(word);
        }
    }
}
