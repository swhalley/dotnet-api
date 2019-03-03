using System;

namespace swhalley.Models
{
    public class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public Address Address { get; set; }
    }   
} 

