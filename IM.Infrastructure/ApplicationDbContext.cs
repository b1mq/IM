using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IM.Domain;
namespace IM.Infrastructure

{
    public class ApplicationDbContext : DbContext
    {
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<HRDepartment> HRDepartments { get; set; }
        //public DbSet<FinanceDepartment> FinanceDepartments { get; set; }
        //public DbSet<SalaryRecord> SalaryRecords { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<PromoCode> Promocodes { get; set; }
        public DbSet<User> Users {  get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}

