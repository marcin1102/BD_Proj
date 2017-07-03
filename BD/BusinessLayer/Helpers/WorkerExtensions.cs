using DataLayer;

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
