using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Entities;

namespace WebApplication1.DAL.Context
{
    public class HurdaciContext: DbContext
    {
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SUNA\\SQLEXPRESS;Initial Catalog=HurdaciDb;Integrated Security=true;TrustServerCertificate=true");
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SERVER NAME;database=DATABASE NAME;user=DATABASE USERNAME; password=DATABASE PASSWORD;TrustServerCertificate=TRUE/FALSE(DO YOUR CHOOSE)");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts {  get; set; }
        public DbSet<Feature> Features{  get; set; }
        public DbSet<Scrap>Scraps  {  get; set; }
        public DbSet<ScrapImg> ScrapImgs { get; set; }
        public DbSet<Admin> Admins { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scrap>()
                .HasMany(s => s.ScrapImgs)
                .WithOne(si => si.Scrap)
                .HasForeignKey(si => si.ScrapId);

            base.OnModelCreating(modelBuilder);
        }
     
    }
}
