using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Responses
{
    public class ClientResponse
    {
        public ClientResponse(string firstName, string lastName, string name, string phoneNumber, int id, ICollection<DataLayer.Object> objects)
        {
            FirstName = firstName;
            LastName = lastName;
            Name = name;
            PhoneNumber = phoneNumber;
            Id = id;
            Objects = objects;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public int Id { get; private set; }
        public ICollection<DataLayer.Object> Objects { get; private set; }
    }
}
