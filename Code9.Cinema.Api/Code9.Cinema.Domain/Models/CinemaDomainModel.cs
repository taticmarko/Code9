using System;

namespace Code9.Cinema.Domain.Models
{
    public class CinemaDomainModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberOfAuditoriums { get; set; }
    }
}