using System;
using System.Collections.Generic;
using System.Text;

namespace Code9.Cinema.Infrastructure
{
    public static class DataBase
    {
        public static List<Models.Cinema> GetCinemasTable()
        {
            return new List<Models.Cinema>()
            {
                new Models.Cinema()
                {
                Id = Guid.Parse("8e9f876a-5f76-46b9-8e36-54c3d17c6809"),
                City = "Novi Sad",
                Name = "Cinestar",
                NumberOfAuditoriums = 15,
                Street = "Bulevar Oslobodjenja 25"
                },
                new Models.Cinema()
                {
                Id = Guid.Parse("7cc38e8f-0782-43a1-aca9-eaeda2e80ada"),
                City = "Novi Sad",
                Name = "Cinemania",
                NumberOfAuditoriums = 5,
                Street = "Bulevar Evrope 8"
                },
                new Models.Cinema()
                {
                Id = Guid.Parse("c9944731-0937-4aec-990f-4c5fd59bebf4"),
                City = "Zrenjanin",
                Name = "Cinestar",
                NumberOfAuditoriums = 21,
                Street = "Igmanska 52a"
                },
                new Models.Cinema()
                {
                Id = Guid.Parse("6d37dc11-a9be-4575-91a7-7f7dc5dcb3aa"),
                City = "Beograd",
                Name = "Superstar",
                NumberOfAuditoriums = 36,
                Street = "Bulevar Oslobodjenja 1032"
                },
                new Models.Cinema()
                {
                Id = Guid.Parse("6d37dc11-a9be-4575-91a7-7f7dc5dcb3aa"),
                City = "Beograd",
                Name = "Arena",
                NumberOfAuditoriums = 2,
                Street = "Nikole Pasica 22"
                },
                new Models.Cinema()
                {
                Id = Guid.Parse("6d37dc11-a9be-4575-91a7-7f7dc5dcb3aa"),
                City = "Beograd",
                Name = "Trzni centar Galerija",
                NumberOfAuditoriums = 5,
                Street = "Novosadski put 90"
                }
            };
        }
    }
}
