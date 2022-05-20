using AlunosApi.Context;
using AlunosApi.Models;
using AlunosApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Services.Implementacao {
    public class AlunoService : IAlunoService {

        private readonly AppDbContext _context;

        public AlunoService(AppDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAlunos() {
            return await _context.Alunos.ToListAsync();
        }
        public async Task<Aluno> GetAlunoById(int id) {
            var aluno = await _context.Alunos.FindAsync(id);
            return aluno;
        }
        public async Task<IEnumerable<Aluno>> GetAlunosByName(string name) {
            IEnumerable<Aluno> alunos;
            if (string.IsNullOrEmpty(name)) {
                alunos = await _context.Alunos.Where(n => n.Nome.Contains(name)).ToArrayAsync();
            } else {
                alunos = await GetAlunos();
            }
            return alunos;
        }
        public async Task CreateAluno(Aluno aluno) {
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAluno(Aluno aluno) {

            _context.Entry(aluno).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAluno(Aluno aluno) {
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
        }
    }
}
