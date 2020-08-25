using Contak.Models;
using Microsoft.EntityFrameworkCore;

namespace Contak.Data
{
    public class ContakContext : DbContext
    {
        public ContakContext(DbContextOptions<ContakContext> opt) : base(opt)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}