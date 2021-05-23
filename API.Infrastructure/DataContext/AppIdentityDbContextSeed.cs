using API.Core.DbModels.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.DataContext
{
    public class AppIdentityDbContextSeed
    {
        public static void SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Berkay",
                    Email = "beko_468@hotmail.com",
                    UserName = "beko_468@hotmail.com",
                    Address = new Address
                    {
                        FirstName = "Berkay",
                        LastName = "Kulak",
                        Street = "Fatih Cad",
                        City = "Burdur",
                        State = "TR",
                        ZipCode = "15300"
                    }
                };
                userManager.CreateAsync(user, "A123456");
            }
        }
    }
}