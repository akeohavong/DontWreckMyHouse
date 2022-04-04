using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontWreckMyHouse.Core.DTO
{
    public class Host
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location {get; set; }
        public string Email { get; set; } 

        public decimal StandardRate { get; set; }
        public decimal WeekendRate { get; set; }

        public Host() { }

        public Host(int id, string email, string location, string name, decimal standardRate, decimal weekendRate)
        {
            Id = id;
            Email = email;
            Location = location;
            Name = name;
            StandardRate = standardRate;
            WeekendRate = weekendRate;
        }
    }
}
