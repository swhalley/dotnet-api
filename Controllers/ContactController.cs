﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using swhalley.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace swhalley.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly PersonContext _context;

        public ContactController( PersonContext context ){
            _context = context;
        }

        /**
        * Endpoint : api/contact/
        * Retrieves a list of all people     
        */
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
        {
            return await _context.People.ToListAsync();
        }

        /**
        * Endpoint : api/contact/{id}
        * Retrieves a specific person. Will also contain their address    
        */
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson( int id ){
            return await _context.People
                    .Where(p => p.ID == id )
                    .Include(p => p.Address)
                    .FirstOrDefaultAsync();
        }

        /**
         * Endpoint : api/contact/birthdate/{YYYY-MM-DD}
         * Provides the ability to find all people with the same birthdate
         */
        [HttpGet("birthdate/{birthdate}")]
        public async Task<ActionResult<IEnumerable<Person>>> GetByBirthdate(DateTime birthdate)
        {
            return await _context.People
                    .Where( Person => Person.Birthdate == birthdate )
                    .ToListAsync();
        }

        /**
         * Endpoint : api/contact/
         * Verb : POST
         * Ability to Add a new Person. 
          */
        [HttpPost]
        public async Task<ActionResult<Person>> AddPerson([FromBody] Person person)
        {
            _context.People.Add( person );
            await _context.SaveChangesAsync();

            return person;
        }
    }
}
