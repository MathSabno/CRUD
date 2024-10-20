using CRUD.Entidade;
using Microsoft.EntityFrameworkCore;

namespace CRUD.EF
{
    public class TarefaDbContext : DbContext
    {
        public TarefaDbContext() { }


        public DbSet<Tarefa> Tasks { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=INSTDB001;Trusted_Connection=True;");
    }
}
