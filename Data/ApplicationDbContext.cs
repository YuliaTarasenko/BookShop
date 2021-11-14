using BookShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(entity =>
            {
                entity.ToTable("Books");
                entity.HasIndex(p => p.Name);
                entity.HasIndex(p => p.Pages);
                entity.HasIndex(p => p.PublishedYear);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(250);
            });

            builder.Entity<Autor>(entity =>
            {
                entity.ToTable("Autors");
                entity.HasIndex(p => p.Name);
                entity.HasIndex(p => p.BirthYear);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(250);
            });

            builder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genres");
                entity.HasIndex(p => p.Name);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(250);
            });

            builder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");
                entity.HasIndex(p => p.Name);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(250);
            });

            builder.Entity<PublishingCompany>(entity =>
            {
                entity.ToTable("PublishingCompanies");
                entity.HasIndex(p => p.Name);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(250);
            });

            builder.Entity<Storage>(entity =>
            {
                entity.ToTable("Storages");
                entity.HasIndex(p => p.CreateDate);
                entity.HasIndex(p => p.CostPrice);
                entity.HasIndex(p => p.Quantity);
                entity.Property(p => p.CostPrice).HasColumnType("money"); 
            });

            builder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discounts");
                entity.HasIndex(p => p.Start);
                entity.HasIndex(p => p.End);
                entity.HasIndex(p => p.Reduction);
                entity.HasIndex(p => p.IsPercent);
            });

            builder.Entity<Order>(entity =>
            {
                entity.ToTable("Orders");
                entity.HasIndex(p => p.Price);
                entity.HasIndex(p => p.Date);
                entity.Property(p => p.Price).HasColumnType("money");
            });

            base.OnModelCreating(builder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<PublishingCompany> PublishingCompanies { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
