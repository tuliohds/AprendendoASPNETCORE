using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SJT___Sua_Jornada_na_Tecnologia.Models
{
    public class Contexto : DbContext
    {
        //Registrando classes criadas para registro no BD
        public DbSet<Jornada> Jornadas { get; set; }

        public DbSet<Pergunta> Perguntas { get; set; }

        public DbSet<Profissao> Profissoes { get; set; }

        public DbSet<Resposta> Respostas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        //MODIFICANDO O PADRAO DO .NET CORE AO CRIAR BD, DEVIDO AS CHAVES ESTRANGEIRAS
        //FLUENTAPI - MUDANDO O COMPORTAMENTO PADRAO DO ENTITY FRAMEWORK
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Jornada>().HasOne(j => j.Usuario).WithMany(u => u.Jornada).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Jornada>().HasOne(j => j.Pergunta).WithMany(p => p.Jornada).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Jornada>().HasOne(j => j.Resposta).WithMany(r => r.Jornada).OnDelete(DeleteBehavior.NoAction);
        }

        // CLASSE PASSANDO OPÇÕES PARA O CONSTRUTOR DO FRAMEWORK
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    }
}
