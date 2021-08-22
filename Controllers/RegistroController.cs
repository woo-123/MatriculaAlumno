
using Microsoft.AspNetCore.Mvc;
using MatriculaAlumno.Models;
using MatriculaAlumno.Data;


namespace MatriculaAlumno.Controllers
{
    
    public class RegistroController:Controller
    {
        private readonly ApplicationDbContext _context;
        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index (){
            return View();
        }

        public IActionResult Create(Registro objRegistro)
        {
            _context.Add(objRegistro);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno ya esta Registrado";
            return View("Index");
        }

        
    }
}