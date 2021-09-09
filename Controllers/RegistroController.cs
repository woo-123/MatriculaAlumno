
using Microsoft.AspNetCore.Mvc;
using MatriculaAlumno.Models;
using MatriculaAlumno.Data;
using System.Linq;

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
        
            return View(_context.DataContactos.ToList());

        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost] 
        public IActionResult Create(Registro objRegistro)
        {
            _context.Add(objRegistro);
            _context.SaveChanges();
            ViewData["Message"] = "El Alumno ya esta Registrado";
            return View();
        }

        public IActionResult Edit (int id)
        {
            Registro objRegistro = _context.DataContactos.Find(id);
            if(objRegistro == null){
                return NotFound();
            }
            return View(objRegistro);
        }
        
        [HttpPost]
        public IActionResult Edit (int id,[Bind("Id,Apellidos,Carrera,Nombres,DNI,FechaNacimiento,Genero")] Registro objRegistro){
            _context.Update(objRegistro);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto ya esta actualizado";
             return View(objRegistro);
        }
       

        public IActionResult Delete (int id)
        {
            Registro objRegistro = _context.DataContactos.Find(id);
            _context.DataContactos.Remove(objRegistro);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}