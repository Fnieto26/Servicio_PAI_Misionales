using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ServicioPAI.Repository.Entities;

namespace ServicioPAI.Models
{
    public partial class Context : DbContext
    {
        public Context()
        {           
        }
        public Context(DbContextOptions<Context> options)
               : base(options)
        {
        }
        public virtual DbSet<PersonaEntity> PersonaEntity { get; set; }

    }
}
