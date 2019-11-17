using System;

namespace App.API.dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string Country { get; set; }

        public string PhotoUrl { get; set; }
    }
}