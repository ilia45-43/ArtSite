using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Art.Pages.Models
{
    public class User
    {
        public Profile Profile { get; set; }

        public Guid id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}