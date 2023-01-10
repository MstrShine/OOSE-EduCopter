﻿namespace EduCopter.Domain.Geography
{
    public class Province : Entity
    {
        public string Name { get; set; }

        public Guid CountryId { get; set; }

        public List<City> Cities { get; set; } = new();

        public Province() { }
    }
}