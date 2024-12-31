using Microsoft.EntityFrameworkCore;
using ZeyadInHome.Models;

namespace ZeyadInHome.Data
{
    public class ProjectDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LEVASCH-STD050;Database = rev;Integrated Security=True;Encrypt=False;TrustServerCertificate= true");
        }
       public DbSet<Product> products {  get; set; }
       public DbSet<Order> orders { get; set; }   

        public   DbSet<OrderItem> ordersItem { get; set; }

     public   DbSet<Customer> customers { get; set; }
    }

}
