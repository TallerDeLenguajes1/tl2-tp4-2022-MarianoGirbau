public class Persona{
    public int ID { get; set; }
    public string nombre { get; set; }
    public string direccion { get; set; }
    public string telefono { get; set; }

    public Persona(int ID, string nombre, string direccion, string telefono){

        this.ID = ID;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;

    }

}