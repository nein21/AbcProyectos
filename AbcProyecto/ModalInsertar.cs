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
    public partial class ModalInsertar : Form
    {
        public int bandera = 0;
        public ModalInsertar()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string sNombre = txtInsNombre.Text;
            string sDescripcion = txtInsDescr.Text;
            int iCantidad = Int32.Parse(txtInsCant.Text);
            //int iId = Int32.Parse(txtInsID.Text);
            Producto pro = new Producto();
            pro.nombre = sNombre;
            pro.descripcion = sDescripcion;
            pro.cantidad = iCantidad;

            SqlMsSql sql = new SqlMsSql();
            SqlPostgres sqlPg = new SqlPostgres();
            if (bandera == 1)
            {
                sql.setProducto(pro);
            }
            if (bandera == 2)
            {
                sqlPg.setProducto(pro);
            }
            
            this.Close();

            /******************Codigo para NHIBERNATE*********************************
            ProductosRepository producto = new ProductosRepository();
            producto.Add(pro);
            */
        }
    }
}
