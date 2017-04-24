using System.Collections.Generic;
using BusinessLayer.Responses.Object;

namespace BusinessLayer.Responses.Client
{
    public class ClientResponse
    {
        public ClientResponse(string firstName, string lastName, string name, string phoneNumber, int id, ICollection<ObjectResponse> objects)
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
        public ICollection<ObjectResponse> Objects { get; private set; }
    }
}
