using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class AlunosController : Controller
    {
        private readonly List<Aluno> alunos = new List<Aluno>();

        public AlunosController()
        {
            alunos.Add(new Aluno()
            {
                Nome = "Ariane Lacerda",
                Disciplina = "Engenharia de Software",
                Ra = "215641",
                P1 = 10,
                P2 = 8

            });

            alunos.Add(new Aluno()
            {
                Nome = "Felipe Cardoso",
                Disciplina = "Redes de Computadores",
                Ra = "123456",
                P1 = 10,
                P2 = 10


            });
        }

        public IActionResult Index()
        {
            return View(alunos);
        }

        public IActionResult Details(string id)
        {
            var aluno = alunos.Find(a => a.Ra == id);
            if (aluno == null) return NotFound();

            return View(aluno);
        }
    }
}
