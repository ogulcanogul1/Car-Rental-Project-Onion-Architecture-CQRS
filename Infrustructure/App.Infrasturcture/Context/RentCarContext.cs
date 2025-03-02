using App.Domain.Entities;
using App.Domain.Entities.Cars;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Context
{
    public class RentCarContext : DbContext
    {
        public RentCarContext(DbContextOptions<RentCarContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<RentType> RentTypes { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RentACar;User Id=sa;Password=123;Integrated Security=true;Trusted_Connection=Yes;TrustServerCertificate=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}

    }
}
