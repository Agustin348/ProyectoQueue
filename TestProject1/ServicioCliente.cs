namespace TestProject1
{
    public class ServicioCliente
    {
        private Queue<Cliente> colaClientes;

        public ServicioCliente()
        {
            colaClientes = new Queue<Cliente>();
        }

        public void AgregarClienteACola(Cliente cliente)
        {
            colaClientes.Enqueue(cliente);
        }

        public Cliente ObtenerSiguienteClienteDeCola()
        {
            if (colaClientes.Any())
            {
                return colaClientes.Dequeue();
            }
            else
            {
                throw new Exception("No hay clientes en la cola");
            }
        }

        public int ObtenerCantidadDeClientesEnCola()
        {
            return colaClientes.Count();
        }
    }
}