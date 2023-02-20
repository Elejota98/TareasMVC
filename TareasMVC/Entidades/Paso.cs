namespace TareasMVC.Entidades
{
    public class Paso
    {
        public Guid Id { get; set; }
        public int TareaId { get; set; }  //Esta es la llave foranea        
        public Tarea Tarea { get; set; } //Propiedad de navegación, me permite cargar la data relacionada de la tarea como un comboBox
        public string Descripcion { get; set; }
        public bool Realizado { get; set; }
        public int Orden { get; set; }
    }
}
