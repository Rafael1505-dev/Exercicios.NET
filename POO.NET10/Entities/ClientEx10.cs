
namespace POO.NET10.Entities
{
    class ClientEx10
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public ClientEx10(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() 
        { 
            return Name
                + " ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;   
        }

    }
}
