using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;

namespace AbcProyecto
{
    public partial class Form1 : Form
    {
        SqlMsSql sql;
        SqlPostgres sqlPg;
        public Form1()
        {
            InitializeComponent();
            sql = new SqlMsSql();
            sqlPg = new SqlPostgres();
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            /******************Codigo para NHIBERNATE*********************************            
            int iId = Int32.Parse( txtId.Text);
            ProductosRepository producto = new ProductosRepository();
            var resultado = producto.GetById(iId);            
            dgvMsql.Rows.Add(resultado.idproducto, resultado.nombre, resultado.descripcion, resultado.cantidad);
            */
            int iId = Int32.Parse(txtId.Text);            
            dgvMsql.DataSource = sql.getProductosId(iId);
        }
        
        private void btnNombre_Click(object sender, EventArgs e)
        {
            /******************Codigo para NHIBERNATE*********************************
            ProductosRepository producto = new ProductosRepository();
            var resultado = producto.GetByNombre(txtNombre.Text);
            dgvMsql.Rows.Add(resultado.idproducto, resultado.nombre, resultado.descripcion, resultado.cantidad);
            */
            string name = txtNombre.Text;            
            dgvMsql.DataSource = sql.getProductosName(name);
        }
        private void btnBuscarGral_Click(object sender, EventArgs e)
        {            
            dgvMsql.DataSource = sql.getProductos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ModalInsertar moInsert = new ModalInsertar();
            moInsert.bandera = 1;
            moInsert.ShowDialog();
            
            dgvMsql.DataSource = sql.getProductos();
        }

        private void dgvMsql_DoubleClick(object sender, EventArgs e)
        {            
            ModalUpdate moUpdate = new ModalUpdate();            
            DataGridViewRow row = dgvMsql.CurrentRow;
            moUpdate.setValorProducto(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), Int32.Parse(row.Cells[3].Value.ToString()));
            moUpdate.bandera = 1;
            moUpdate.ShowDialog();

            dgvMsql.DataSource = sql.getProductos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMsql.CurrentRow;
            sql.deleteProducto(Int32.Parse(row.Cells[0].Value.ToString()));
            dgvMsql.DataSource = sql.getProductos();
        }
        //===============================================================Botones Para Petaña De PostgresSql===============================================================
        private void btnPgId_Click(object sender, EventArgs e)
        {
            int iId = Int32.Parse(txtPgId.Text);
            dgvMsql.DataSource = sqlPg.getProductosId(iId);
        }

        private void btnPgName_Click(object sender, EventArgs e)
        {
            string name = txtPgName.Text;
            dgvMsql.DataSource = sqlPg.getProductosName(name);
        }

        private void btnPgBuscar_Click(object sender, EventArgs e)
        {
            dgvPsql.DataSource = sqlPg.getProductos();
        }

        private void btnPgInsertar_Click(object sender, EventArgs e)
        {
            ModalInsertar moInsert = new ModalInsertar();
            moInsert.bandera = 2;
            moInsert.ShowDialog();

            dgvMsql.DataSource = sqlPg.getProductos();
        }

        private void btnPgDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMsql.CurrentRow;
            sqlPg.deleteProducto(Int32.Parse(row.Cells[0].Value.ToString()));
            dgvMsql.DataSource = sqlPg.getProductos();
        }

        private void dgvPsql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ModalUpdate moUpdate = new ModalUpdate();
            DataGridViewRow row = dgvMsql.CurrentRow;
            moUpdate.setValorProducto(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), Int32.Parse(row.Cells[3].Value.ToString()));
            moUpdate.bandera = 2;
            moUpdate.ShowDialog();

            dgvMsql.DataSource = sqlPg.getProductos();
        }

    }
}
