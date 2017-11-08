using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AbcProyecto
{
    class SqlMsSql
    {
        //string cadena = "Data Source=NEINHIFE\\;Initial Catalog=IF;Integrated Security=True";
        //string cadena = "Data Source=BETRUNS-PC\\;Initial Catalog=IF;Integrated Security=True";
        //string cadena = "Data Source=NEINHIFE-PC\\NEINHIFE;Initial Catalog=IF;Integrated Security=True";
        //string cadena = "Data Source=192.168.1.22,1433; Network Library=DBMSSOCN; Initial "
        //    + "Catalog=IF; User=nein; Password=efrain21";
        //string cadena = "Data Source=192.168.1.103,1433;Initial Catalog=IF;User=nein;Password=efrain21";
        //Data Source=192.168.1.103,1433; Network Library=DBMSSOCN; Initial Catalog=IF; User=nein; Password=efrain21
        string cadena;
        SqlConnection conexion;
        SqlDataAdapter adap;
        public SqlMsSql()
        {
            cadena = "Data Source=PROMEXING-HP\\;Initial Catalog=AbcMsql;Integrated Security=True";
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }
        public DataTable getProductos()
        {
            string sintaxis = "";
            DataTable tabla = new DataTable();
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc;";
            adap = new SqlDataAdapter(sintaxis, conexion);
            adap.Fill(tabla);
            return tabla;
        }
        public DataTable getProductosName(string name)
        {
            string sintaxis = "";            
            DataTable tabla = new DataTable();            
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc where nombre='"+name+"';";
            adap = new SqlDataAdapter(sintaxis, conexion);            
            adap.Fill(tabla);            
            return tabla;
        }
        public DataTable getProductosId(int id)
        {
            string sintaxis = "";            
            DataTable tabla = new DataTable();            
            sintaxis = "select idproducto,nombre,descripcion,cantidad from productosabc where idproducto="+id+";";
            adap = new SqlDataAdapter(sintaxis, conexion);            
            adap.Fill(tabla);            
            return tabla;
        }
        public void setProducto(Producto pro)
        {
            string sintaxis = "";            
            sintaxis = "insert into productosabc (nombre,descripcion,cantidad) values('"+pro.nombre+"','"+pro.descripcion+"',"+pro.cantidad+")";
            adap = new SqlDataAdapter(sintaxis, conexion);
            adap.SelectCommand.ExecuteNonQuery();

        }
        public void updateProducto(Producto pro)
        {
            string sintaxis = "";            
            sintaxis = "update productosabc	set nombre='" + pro.nombre + "',descripcion='" + pro.descripcion + "',cantidad=" + pro.cantidad + " where idproducto=" + pro.idproducto + ";";
            adap = new SqlDataAdapter(sintaxis, conexion);
            adap.SelectCommand.ExecuteNonQuery();

        }
        public void deleteProducto(int id)
        {
            string sintaxis = "";            
            sintaxis = "delete from productosabc where idproducto="+id+";";
            adap = new SqlDataAdapter(sintaxis, conexion);
            adap.SelectCommand.ExecuteNonQuery();
        }
    }
}
