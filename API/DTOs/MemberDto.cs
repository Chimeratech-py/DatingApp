using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        
        //URL of profile picture
        public string PhotoUrl { get; set; }
        /**age property, automatically calculated via getage method inside AppUser entity,
        Automapper also automatically detects any method with "get" keyword and matches it to second 
        part of get
        */
        public int Age { get; set;}
        public string KnownAs { get; set;}

        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; } 
    }
}