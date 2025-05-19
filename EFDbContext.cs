using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLBH.Models; //truy xuất đến các lớp: Customer,…
using System.Configuration;
namespace QLBH
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Progress> Progresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    }
}
