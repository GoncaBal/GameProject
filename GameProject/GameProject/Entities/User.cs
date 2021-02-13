using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using System.Text;

namespace GameProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public long NationalityId { get; set; }

    }
}
