using Microsoft.EntityFrameworkCore;
using restapi.Models;

namespace restapi.Data
{
    public class RestapiContext : DbContext
    {
        public RestapiContext(DbContextOptions<RestapiContext> opt) : base(opt)
        {

        }
        public DbSet<Command> Commands {get ; set ;}
    }
}