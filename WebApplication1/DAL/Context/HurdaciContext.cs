using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL.Entities;

namespace WebApplication1.DAL.Context
{
    public class HurdaciContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;initial Catalog=HurdaciDb; integrated Security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts {  get; set; }
        public DbSet<Feature> Features{  get; set; }
        public DbSet<Scrap>Scraps  {  get; set; }
        public DbSet<Servicess> Servicesses {  get; set; }
    }
}
