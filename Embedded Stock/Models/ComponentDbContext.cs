using Microsoft.EntityFrameworkCore;

namespace Embedded_Stock.Models
{
    public class ComponentDbContext : DbContext
    {
        public ComponentDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryComponentType>().HasKey(cct => new
            {
                cct.CategoryId,
                cct.ComponentTypeId
            });

            modelBuilder.Entity<CategoryComponentType>()
                .HasOne(cct => cct.Category)
                .WithMany(c => c.ComponentTypes)
                .HasForeignKey(cct => cct.CategoryId);

            modelBuilder.Entity<CategoryComponentType>()
                .HasOne(cct => cct.ComponentType)
                .WithMany(ct => ct.Categories)
                .HasForeignKey(cct => cct.ComponentTypeId);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ComponentType> ComponentTypes { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ESImage> EsImages { get; set; }
        public DbSet<CategoryComponentType> CategoryComponentTypes { get; set; }
    }
}