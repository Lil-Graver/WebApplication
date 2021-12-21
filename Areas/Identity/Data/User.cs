using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        public string Favourite { get; set; }

        public string Liked { get; set; }
    }
}
