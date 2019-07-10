using Microsoft.AspNetCore.Builder;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Deloitte.Todo
{
    public static class UserInitialiser
    {
        public static IApplicationBuilder SeedUsers(this IApplicationBuilder app, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                var userRole = new IdentityRole()
                {
                    Name = "User",
                };
                var roleResult = roleManager.CreateAsync(userRole).Result;

            }

            if (userManager.FindByEmailAsync("test").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "test",
                    Email = "test"
                };

                IdentityResult result = userManager.CreateAsync(user, "pwd123").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }


            return app;
        }
    }
}
