using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontWreckMyHouse.Core.DTO
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Guest() { }

        public Guest(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
