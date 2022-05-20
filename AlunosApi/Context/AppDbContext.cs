using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<Aluno>? Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno {
                    AlunoId = 1,
                    Nome = "Adí Kauan da Cunha dos Santos",
                    Email = "adi.kauan02@gmail.com",
                    Idade = 24
                },
                new Aluno {
                    AlunoId = 2,
                    Nome = "Paula Silva Pereira",
                    Email = "pispispaulinha@gmail.com",
                    Idade = 22
                }
                );
        }






    }
}
