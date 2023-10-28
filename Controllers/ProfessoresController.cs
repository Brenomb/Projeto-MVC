using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly List<Professores> professores = new List<Professores>();

        public ProfessoresController()
        {
            professores.Add(new Professores
            {
                Ra = "696969",
                Nome = "Claudio Nunes",
                Materia = "Engenharia de Software",
                Turno = "Noturno",
                Salario = 7000
            });

            professores.Add(new Professores
            {
                Ra = "011010",
                Nome = "Fernando Branquinho",
                Materia = "Prática de programação",
                Turno = "Noturno",
                Salario = 10000
            });
        }

        public IActionResult Index()
        {
            return View(professores);
        }

        public IActionResult Details(string id)
        {
            var professor = professores.Find(a => a.Ra == id);
            if (professor == null) return NotFound();

            return View(professor);
        }
    }
}

