using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace swhalley.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public virtual Address Address { get; set; }
    }   
} 

