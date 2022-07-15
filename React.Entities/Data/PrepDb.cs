using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using React.Entities.Models;

namespace React.Entities.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Owners.Any())
            {
                Console.WriteLine("--> Seeding data");

                context.Owners.AddRange(
                        new Owner() { Id = 1, Name = "Roshan", Address = "Makulwewa", PostNumber = 60000, City = "Kurunegala", DateCreated = DateTime.Now, CreatedBy = "System" },
                        new Owner() { Id = 1, Name = "Manoj", Address = "Malinawatta", PostNumber = 81000, City = "Matara", DateCreated = DateTime.Now, CreatedBy = "System" }
                    );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
