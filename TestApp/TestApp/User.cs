using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    internal class User
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal DateTime Birthdate { get; set; }
        internal string Address { get; set; }
        internal User(int id, string name, DateTime birthdate, string address)
        {
            Id = id;
            Name = name;
            Birthdate = birthdate;
            Address = address;
        }
    }
}
