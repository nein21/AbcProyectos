using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcProyecto
{
    class Producto
    {
        public virtual int idproducto { get; set; }
        public virtual string nombre { get; set; }
        public virtual string descripcion { get; set; }
        public virtual int cantidad { get; set; }

        public void clonarProducto(Producto pro)
        {
            this.idproducto     =   pro.idproducto;
            this.nombre         =   pro.nombre;
            this.descripcion    =   pro.descripcion;
            this.cantidad       =   pro.cantidad;
        }
    }
}
