using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbcProyecto
{
    class ProductosRepository : IProductosRepository
    {
        public void Add(Producto producto)
        {
            //throw new NotImplementedException();
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Save(producto);
                    
                    transaction.Commit();
                }
            }
        }

        public Producto GetById(int id)
        {
            //throw new NotImplementedException();
            using (NHibernateManager manager = new NHibernateManager())
            {
                return manager.Session.Get<Producto>(id,LockMode.Read);                
            }
        }

        public Producto GetByNombre(string name)
        {

            //throw new NotImplementedException();
            Producto pro = new Producto();
            pro.nombre = name;
            using (NHibernateManager manager = new NHibernateManager())
            {
                //return manager.Session.CreateCriteria(typeof(Producto)).Add(Restrictions.Eq("nombre", nombre)).UniqueResult<Producto>();
                //return manager.Session.CreateCriteria<Producto>().Add(Expression.Eq("nombre",(string)name)).UniqueResult<Producto>();
                //return manager.Session.CreateSQLQuery("select * from productosabc where nombre=" + nombre);
                return manager.Session.CreateCriteria<Producto>().Add(Expression.Eq("nombre", new string[] {name})).UniqueResult<Producto>();
              
            }
        }

        public void Remove(Producto producto)
        {
            //throw new NotImplementedException();
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Delete(producto);
                    transaction.Commit();
                }
            }
        }

        public void Update(Producto producto)
        {
            //throw new NotImplementedException();
            using (NHibernateManager manager = new NHibernateManager())
            {
                using (ITransaction transaction = manager.Session.BeginTransaction())
                {
                    manager.Session.Update(producto);
                    transaction.Commit();
                }
            }
        }
    }
}
