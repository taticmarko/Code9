using System;

namespace Code9.Cinema.Api.Models
{
    public class CreateCinemaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberOfAuditoriums { get; set; }
    }
}