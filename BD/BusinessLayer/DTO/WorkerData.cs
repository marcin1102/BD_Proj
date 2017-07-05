using System;

namespace BusinessLayer.DTO
{
    public class WorkerData
    {
        public WorkerData()
        {

        }
        public WorkerData(string uName, string firstName, string lastName, string role, DateTime? expiration)
        {
            UName = uName;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Expiration = expiration;
        }

        public WorkerData(string uName, string pass, string firstName, string lastName, string role, DateTime? expiration)
        {
            UName = uName;
            Pass = pass;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Expiration = expiration;
        }
        public string UName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DateTime? Expiration { get; set; }
        public int Id { get; set; }
        public string Pass { get; set; }

		public string FullName()
		{
			return FirstName + " " + LastName;
		}
	}
}
