using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbcProyecto
{
    public partial class ModalUpdate : Form
    {
        Producto proUpdate;
        public int bandera = 0;
        public ModalUpdate()
        {
            InitializeComponent();
        }
        public void setValorProducto(int id,string name,string descrip,int cant)
        {
            proUpdate = new Producto();
            proUpdate.idproducto = id;
            proUpdate.nombre = name;
            proUpdate.descripcion = descrip;
            proUpdate.cantidad = cant;
            //
            txtUpID.Text =""+proUpdate.idproducto;
            txtUpNombre.Text = proUpdate.nombre;
            txtUpDescr.Text = proUpdate.descripcion;
            txtUpCant.Text = "" + proUpdate.cantidad;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            proUpdate.nombre = txtUpNombre.Text;
            proUpdate.descripcion = txtUpDescr.Text;
            proUpdate.cantidad = Int32.Parse( txtUpCant.Text);

            SqlMsSql sql = new SqlMsSql();
            SqlPostgres sqlPg = new SqlPostgres();
            if (bandera == 1)
            {
                sql.updateProducto(proUpdate);
            }
            if (bandera==2)
            {
                sqlPg.updateProducto(proUpdate);
            }            
            this.Close();
        }
    }
}
