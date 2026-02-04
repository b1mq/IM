using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace IM.Infrastructure
{
    public class ApplicationDesingTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer("Server=DESKTOP-AN5OC4E\\SQLEXPRESS; Database=Company;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;")
                .Options;

            return new ApplicationDbContext(options);
        }
    }
}
