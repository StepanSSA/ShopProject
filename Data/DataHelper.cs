using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Data
{
    public class DataHelper
    {
        private static IApplicationBuilder app;
        // для начального заполнения бд
        public async static void Seed(IApplicationBuilder _app)
        {
            app = _app;
            //  1) добавим базовые роли в систему
            var services = app.ApplicationServices;
            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            string password = "!Qwerty1";
            string[] rolesNames = { "boss" };
            string[] usersNames = { "Boss@mail.ru" };

            for (int i = 0; i < rolesNames.Length; i++)
            {
                string roleName = rolesNames[i];
                var role = await roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    role = new IdentityRole()
                    {
                        Name = roleName
                    };
                    IdentityResult result = await roleManager.CreateAsync(role);
                    if (result.Succeeded)
                    {
                        var user = new AppUser()
                        {
                            UserName = usersNames[i]
                        };
                        result = await userManager.CreateAsync(user, password);
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, roleName);
                        }

                    }
                }
            }

            // 2) добавляем в базу
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            if (!context.Products.Any())
                context.Products.AddRange(new SimpleRepository().Products);

            if (!context.Categories.Any())
                context.Categories.AddRange(new SimpleRepository().Categories);

            if (!context.Subcategories.Any())
                context.Subcategories.AddRange(new SimpleRepository().Subcategories);

            if (!context.Characteristics.Any())
                context.Characteristics.AddRange(new SimpleRepository().Characteristics);

            context.SaveChanges();
        }
    }
}
