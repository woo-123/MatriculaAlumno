using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;    


namespace MatriculaAlumno.Data
{

    public class ApplicationDbContext : IdentityDbContext {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        
        {
            

        }
        public DbSet<MatriculaAlumno.Models.Registro> DataContactos {get; set;}
    }
}