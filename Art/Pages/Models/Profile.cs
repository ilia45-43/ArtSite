using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Art.Pages.Models
{
    public class Profile
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }
}