using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public Client GetDataClient()
        {
            return new Faker<Client>("pt_BR").StrictMode(true)
                .RuleFor(c => c.Name, f => f.Person.FirstName)
                .RuleFor(c => c.Email, f => f.Internet.Email())
                .RuleFor(c => c.BirthDate, f => f.Date.Past());
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Email
                + ", "
                + BirthDate;
        }
    }
}
