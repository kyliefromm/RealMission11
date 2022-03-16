using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class AppidentityDBContex : IdentityDbContext<IdentityUser>
    {
        public AppidentityDBContex(DbContextOptions options) : base(options)
        {

        }
    }
}
