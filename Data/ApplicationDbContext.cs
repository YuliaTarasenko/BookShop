using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BookShop.Models;

namespace BookShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookShop.Models.Book> Book { get; set; }
        public DbSet<BookShop.Models.Autor> Autor { get; set; }
        public DbSet<BookShop.Models.Genre> Genre { get; set; }
        public DbSet<BookShop.Models.Subject> Subject { get; set; }
        public DbSet<BookShop.Models.PublishingCompany> PublishingCompany { get; set; }
        public DbSet<BookShop.Models.Storage> Storage { get; set; }
    }
}
