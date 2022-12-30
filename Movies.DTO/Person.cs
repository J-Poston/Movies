using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DTO
{
    public class Person
    {
        [ReadOnly(true)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        public Person()
        {

        }
        public Person(string name, DateTime? DateOfBirth)
        {
            Name = name;
            DOB = DateOfBirth;
        }
    }
}
