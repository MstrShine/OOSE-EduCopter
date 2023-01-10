﻿namespace EduCopter.Persistency.DataBase.Domain.Users
{
    public class EFStudent : EFEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid SchoolId { get; set; }

        public Guid ClassId { get; set; }
    }
}
