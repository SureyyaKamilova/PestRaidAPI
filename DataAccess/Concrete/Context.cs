using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PestRaid;Integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<About> Abouts {  get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<Comment> Comments {  get; set; }
        public DbSet<Contact> Contacts {  get; set; }
        public DbSet<Message> Messages {  get; set; }
        public DbSet<News> News {  get; set; }
        public DbSet<Package> Packages {  get; set; }
        public DbSet<PackagePricing> PackagePricings {  get; set; }
        public DbSet<Pricing> Pricings {  get; set; }
        public DbSet<Product> Products {  get; set; }
        public DbSet<ProductCategory> ProductCategories {  get; set; }
        public DbSet<Project> Projects {  get; set; }
        public DbSet<Service> Services {  get; set; }
        public DbSet<Team> Teams {  get; set; }
        public DbSet<Testimonial> Testimonials {  get; set; }
        
    }
}
