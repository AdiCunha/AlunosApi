using AlunosApi.Models;

namespace AlunosApi.Services.Interfaces {
    public interface IAlunoService {

        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetAlunoById(int id);
        Task<IEnumerable<Aluno>> GetAlunosByName(string name);

        Task CreateAluno(Aluno aluno);

        Task UpdateAluno(Aluno aluno);

        Task DeleteAluno(Aluno aluno);

    }
}
