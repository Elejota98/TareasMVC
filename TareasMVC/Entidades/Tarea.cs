using Microsoft.EntityFrameworkCore.Update.Internal;
using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Entidades
{
    public class Tarea
    {
        //lave primaria
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Paso> Pasos { get; set; } //Acá cargo los pasos que corresponde a esa tarea.

        //Una tarea tiene muchos pasos y un paso tiene solo una tarea

        public List<ArchivoAdjunto> ArchivoAdjuntos { get; set; }

    }
}
