using Microsoft.EntityFrameworkCore;
using SalesOrderManager.Shared.Models;

namespace SalesOrderManager.Server.Repositories.Core
{
    public class SalesOrderContext : DbContext
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<SubElement> SubElements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
               .HasMany(x => x.Windows).WithOne(y => y.Order).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Window>()
              .HasMany(x => x.SubElements).WithOne(y => y.Window).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Order>().HasData
            (
                new Order { Id = 1, Name = "New York Building 1", State = "NY", },
                new Order { Id = 2, Name = "California Hotel AJK", State = "CA", }
            );
            modelBuilder.Entity<Window>().HasData
            (
                new Window { Id = 1, Name = "A51", QuantityOfWindows = 4, TotalSubElements = 3, OrderId = 1 },
                new Window { Id = 2, Name = "C Zone 5", QuantityOfWindows = 2, TotalSubElements = 1, OrderId = 1 },
                new Window { Id = 3, Name = "GLB", QuantityOfWindows = 3, TotalSubElements = 2, OrderId = 2 },
                new Window { Id = 4, Name = "OHF", QuantityOfWindows = 10, TotalSubElements = 2, OrderId = 2 }
            );
            modelBuilder.Entity<SubElement>().HasData
            (
                new SubElement { Id = 1, Element = 1, Type = "Doors", Width = 1250, Height = 1850, WindowId = 1 },
                new SubElement { Id = 2, Element = 2, Type = "Window", Width = 800, Height = 1850, WindowId = 1 },
                new SubElement { Id = 3, Element = 3, Type = "Window", Width = 700, Height = 1850, WindowId = 1 },
                new SubElement { Id = 4, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 2 },
                new SubElement { Id = 5, Element = 1, Type = "Doors", Width = 1400, Height = 2200, WindowId = 3 },
                new SubElement { Id = 6, Element = 2, Type = "Window", Width = 600, Height = 2200, WindowId = 3 },
                new SubElement { Id = 7, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 4 },
                new SubElement { Id = 8, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 4 }
            );
        }

    }
}
