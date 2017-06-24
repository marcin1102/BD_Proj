using System;

namespace BusinessLayer.DTO
{
    public class WorkerData
    {
        public WorkerData(string uName, string pass, string firstName, string lastName, string role, DateTime? expiration)
        {
            UName = uName;
            Pass = pass;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Expiration = expiration;
        }

        public WorkerData(string uName, string firstName, string lastName)
        {
            UName = uName;
            FirstName = firstName;
            LastName = lastName;
        }
        public string UName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Role { get; private set; }
        public DateTime? Expiration { get; private set; }
        public int Id { get; set; }
        public string Pass { get; private set; }
    }
}
