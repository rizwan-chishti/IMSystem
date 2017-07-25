namespace IMS.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class imsDbContext : DbContext
    {
        public imsDbContext()
            : base("name=imsDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Models)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.Cat_ID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.Cat_ID);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Model)
                .HasForeignKey(e => e.Mod_ID);
        }
    }
}
