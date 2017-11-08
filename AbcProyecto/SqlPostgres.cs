using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace AbcProyecto
{
    class SqlPostgres
    {
        public OdbcConnection Conexion { get; set; }
        public OdbcCommand Comando { get; set; }
        public OdbcDataAdapter Adaptador { get; set; }

        OdbcDataReader reader = null; // Recibe y maneja resultados de consultas

        string cadenaConexion = "Driver ={PostgreSQL ODBC Driver(UNICODE)}; Server = 127.0.0.1; Port = 5432; Database = AbcMsql; Trusted_connection=yes; Uid = postgres; Pwd = 321654;";

        /*string cadenaConexion = "DRIVER={PostgreSQL}; Server=localhost;"       + "DATABASE=aforeglobal;"
            + "Trusted_connection=yes;"
            + "UID=sysaforeglobal;"
            + "PWD=a2901ba525795f1fd311642f98c9f160;";
            */

        
        public SqlPostgres()
        {
            Conexion = new OdbcConnection(cadenaConexion);
            //Conexion.Open();
            Comando = new OdbcCommand();
            Comando.Connection = Conexion;
            Adaptador = new OdbcDataAdapter(Comando);
            
        }

        public DataTable getProductos()
        {
            string sintaxis = "";
            DataTable tabla = new DataTable();
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc;";
                        
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;            
            reader = Comando.ExecuteReader();

            tabla.Load(reader);
            return tabla;

        }
        public DataTable getProductosName(string name)
        {
            string sintaxis = "";
            DataTable tabla = new DataTable();
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc where nombre='" + name + "';";

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;
            reader = Comando.ExecuteReader();

            tabla.Load(reader);
            return tabla;
        }
        public DataTable getProductosId(int id)
        {
            string sintaxis = "";
            DataTable tabla = new DataTable();
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc where idproducto=" + id + ";";

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;
            reader = Comando.ExecuteReader();

            tabla.Load(reader);
            return tabla;
        }
        public void setProducto(Producto pro)
        {
            string sintaxis = "";
            sintaxis = "insert into productosabc (nombre,descripcion,cantidad) values('" + pro.nombre + "','" + pro.descripcion + "'," + pro.cantidad + ")";

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;
            reader = Comando.ExecuteReader();

        }
        public void updateProducto(Producto pro)
        {
            string sintaxis = "";
            sintaxis = "update productosabc	set nombre='" + pro.nombre + "',descripcion='" + pro.descripcion + "',cantidad=" + pro.cantidad + " where idproducto=" + pro.idproducto + ";";

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;
            reader = Comando.ExecuteReader();
        }
        public void deleteProducto(int id)
        {
            string sintaxis = "";
            sintaxis = "delete from productosabc where idproducto=" + id + ";";

            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sintaxis;
            reader = Comando.ExecuteReader();

        }

    }
}
