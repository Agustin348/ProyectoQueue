namespace TestProject1
{
    public class PruebasServicioCliente
    {
        [Fact]
        public void PruebaAgregarClienteACola()
        {
            // Arrange
            ServicioCliente servicioCliente = new ServicioCliente();
            Cliente cliente1 = new Cliente { Id = 1, Nombre = "Juan Perez", Email = "juan.perez@example.com" };
            Cliente cliente2 = new Cliente { Id = 2, Nombre = "Maria Lopez", Email = "maria.lopez@example.com" };

            // Act
            servicioCliente.AgregarClienteACola(cliente1);
            servicioCliente.AgregarClienteACola(cliente2);

            // Assert
            Assert.Equal(2, servicioCliente.ObtenerCantidadDeClientesEnCola());
        }

        [Fact]
        public void PruebaObtenerSiguienteClienteDeCola()
        {
            // Arrange
            ServicioCliente servicioCliente = new ServicioCliente();
            Cliente cliente1 = new Cliente { Id = 1, Nombre = "Juan Perez", Email = "juan.perez@example.com" };
            Cliente cliente2 = new Cliente { Id = 2, Nombre = "Maria Lopez", Email = "maria.lopez@example.com" };

            // Act
            servicioCliente.AgregarClienteACola(cliente1);
            servicioCliente.AgregarClienteACola(cliente2);
            Cliente siguienteCliente = servicioCliente.ObtenerSiguienteClienteDeCola();

            // Assert
            Assert.Equal(1, siguienteCliente.Id);
            Assert.Equal("Juan Perez", siguienteCliente.Nombre);
            Assert.Equal("juan.perez@example.com", siguienteCliente.Email);
            Assert.Equal(1, servicioCliente.ObtenerCantidadDeClientesEnCola());
        }

        [Fact]
        public void PruebaObtenerSiguienteClienteDeColaVacia()
        {
            // Arrange
            ServicioCliente servicioCliente = new ServicioCliente();

            // Assert
            Assert.Throws<Exception>(() => servicioCliente.ObtenerSiguienteClienteDeCola());
        }
    }
}