using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sgi_app.domain.entities;
using sgi_app.domain.ports;
using sgi_app.infrastructure.mysql;
using MySql.Data.MySqlClient;


namespace sgi_app.infrastructure.repositories
{
    public class ProveedorRepository : IGenericRepository<Proveedor>, IProveedorRepository
    {

        private readonly ConexionSingleton _conexion;
      

        public ProveedorRepository(string connectionString)
        {
            _conexion = ConexionSingleton.Instancia(connectionString);
        }

        public List<Proveedor> GetAll()
{
    var proveedores = new List<Proveedor>(); // Lista para almacenar los proveedores
    var connec = _conexion.ObtenerConexion();

    string query = "SELECT * FROM Proveedor";
    using (var command = new MySqlCommand(query, connec))
    {
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
               
                var proveedor = new Proveedor()
                {
                    Id = reader.GetInt32("id"),
                    TerceroId = reader.GetInt32("tercero_id"),
                    Dcto = reader.GetDouble("dcto"),
                    DiaPago = reader.GetInt32("dia_pago")
                };

                proveedores.Add(proveedor);
            }
        }
    }
    return proveedores;
}


        public void Add(Proveedor entity)
        {
           
        }
        public void Update(Proveedor entity)
        {
           
        }
        public void Delete(int id)
        {
           
        }
    }
    
       
    
}