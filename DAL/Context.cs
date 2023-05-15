using Microsoft.EntityFrameworkCore;
using TravelDesk.BusinessObjects;

namespace TravelDesk.DAL
{
    public class TravelDbContext :DbContext
    {
        public TravelDbContext()
        {

        }
        public TravelDbContext(DbContextOptions<TravelDbContext> options) : base(options) { }

        public DbSet<User> Users  { get; set; }
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=ANAMIKA\\SQLSERVER;initial catalog=TravelDeskDb;integrated security=true;TrustServerCertificate=true");

        }

       
    }
}