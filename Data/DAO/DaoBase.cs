using NHibernate;

namespace Data.DAO
{
    public class DaoBase<T> where T : class
    {
        public void Create(T entity)
        {
            ISession session = NHibernateClass.GetCurrentSession();
            try
            {
                using ITransaction transaction = session.BeginTransaction();
                session.Save(entity);
                transaction.Commit();
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        public void Update(T entity)
        {
            ISession session = NHibernateClass.GetCurrentSession();
            try
            {
                using ITransaction transaction = session.BeginTransaction();
                session.Update(entity);
                transaction.Commit();
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        public void Delete(T entity)
        {
            ISession session = NHibernateClass.GetCurrentSession();
            try
            {
                using ITransaction transaction = session.BeginTransaction();
                session.Delete(entity);
                transaction.Commit();
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }

        public T Select(int id)
        {
            ISession session = NHibernateClass.GetCurrentSession();
            try
            {
                using ITransaction transaction = session.BeginTransaction();
                return (T)session.Get(typeof(T), id);
            }
            finally
            {
                NHibernateClass.CloseSession();
            }
        }
    }
}
