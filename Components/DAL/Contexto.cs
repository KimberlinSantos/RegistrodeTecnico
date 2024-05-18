using Microsoft.EntityFrameworkCore;
using RegistrodeTecnico.Components.Pages;
using RegistroTecnicos.Models;
using System.Collections.Generic;
namespace RegistroTecnicos.DAL
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options)
        : base(options) { }

        public DbSet<Tecnicos> Tecnicos { get; set; }
    }
}
