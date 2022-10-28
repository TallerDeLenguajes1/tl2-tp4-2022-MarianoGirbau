public class Cadete : Persona{

    private int PagoPedidos=300;

    public Cadete(int ID, string nombre, string direccion, string telefono) : base(ID,nombre,direccion,telefono){
    }
    
    /*
    public void ListarPedidos(){
        foreach (var pedido in Pedidos)
        {
            Console.WriteLine("Numero de pedido: "+pedido.Numero);
            Console.WriteLine("Observacion: "+pedido.Obs);
            Console.WriteLine("Cliente: "+pedido.Cliente);
            Console.WriteLine("Estado: "+pedido.Estado);
        }
    }
    public int JornadaACobrar(){
        return Pedidos.Where(x => x.Estado == Pedido.EstadoPedido.Entregado).ToList().Count * PagoPedidos;
    }
    */
}