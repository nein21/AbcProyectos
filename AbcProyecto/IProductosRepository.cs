using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcProyecto
{
    interface IProductosRepository
    {
        void Add(Producto producto);
        void Update(Producto producto);
        void Remove(Producto producto);
        Producto GetById(int id);
        Producto GetByNombre(string nombre);
    }
}
