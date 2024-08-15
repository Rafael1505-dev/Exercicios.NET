using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET08
{
    internal class GuestEx8
    {
        public string Name { get; private set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public GuestEx8(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;

        }
    }
}
