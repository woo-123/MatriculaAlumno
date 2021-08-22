using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatriculaAlumno.Models
{

    [Table("t_Alumno")]
    public class Registro {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set ; }
        [Column("apellidos")]
        public string Apellidos {get; set ;}
        [Column("carrera")]
        public string Carrera {get; set ;}
        [Column("nombres")]
        public string Nombres {get; set ;}
        [Column("dni")]
        public string DNI {get; set ;}
        [Column("fechaNacimiento")]
        public DateTime FechaNacimiento {get; set ;}
        [Column("genero")]
        public string Genero {get; set ;}


    }







}