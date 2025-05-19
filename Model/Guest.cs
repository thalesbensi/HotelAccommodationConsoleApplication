using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HotelAccommodation.Model
{
    public class Guest
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Guest(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}