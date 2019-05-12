using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace swhalley.Models
{
    public class Address
    {        
        public int ID { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Postal { get; set; }
        public virtual Person Person { get; set; }
    }   
} 