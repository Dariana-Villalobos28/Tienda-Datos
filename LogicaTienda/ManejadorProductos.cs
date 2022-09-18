using System.Collections.Generic;
using EntidadesTienda;
using AccesoDatosTienda;
namespace LogicaTienda.PresentacionTienda
{
    public class ManejadorProductos
    {
        private ProductosAccesoDatos _ProductosAccesoDatos = new ProductosAccesoDatos();
      
        public List<Productos> GetProductos(string dato)
        {
            var ListProductos = _ProductosAccesoDatos.GetProductos(dato);
            return ListProductos;
        }
        public void GuardarProductos(Productos productos)
        {
            _ProductosAccesoDatos.GuardarProductos(productos);
        }
    }
}
