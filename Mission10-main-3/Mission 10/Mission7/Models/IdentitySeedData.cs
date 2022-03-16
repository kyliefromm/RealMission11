﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mission7.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Password123456!";

        //public static int num = 0;

        public static async void EnsurePopulated (IApplicationBuilder app)
        {
            AppidentityDBContex context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppidentityDBContex>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByIdAsync(adminUser);

            if(user == null)
            {
                user = new IdentityUser(adminUser);

                user.Email = "413ExtraYeetPeriod(t)!";
                user.PhoneNumber = "555-1234";

                await userManager.CreateAsync(user, adminPassword);
            }

        }
    }
}
