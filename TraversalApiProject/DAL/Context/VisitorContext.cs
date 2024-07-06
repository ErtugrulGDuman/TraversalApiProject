using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EGD\\SQLEXPRESS;initial catalog=TraversalApiDb;integrated security=true");
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
