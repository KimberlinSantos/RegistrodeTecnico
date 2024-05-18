using Microsoft.EntityFrameworkCore;
using RegistrodeTecnico.Components.Pages;

namespace RegistroTecnicos.DAL
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
        : base(options) { }

        public DbSet<Tecnico> Tecnicos { get; set; }
    }
}
