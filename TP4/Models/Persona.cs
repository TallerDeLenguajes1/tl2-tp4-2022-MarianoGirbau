public class Persona{
    public int ID { get; set; }
    public string nombre { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }

    public Persona(){

    }
    public Persona( string nombre, string direccion, string telefono)
    {
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

}