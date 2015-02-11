
using System.Data.Entity;

namespace DAL.Models
{
    public class PaulContext : DbContext
    {
        public DbSet<Film> Film { get; set; }
    }
}
