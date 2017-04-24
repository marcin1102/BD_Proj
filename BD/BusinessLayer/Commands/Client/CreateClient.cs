using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Commands.Client
{
    public class CreateClient
    {
        public CreateClient(string firstName, string lastName, string name, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
