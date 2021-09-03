using Data.DAO;
using Data.Entity;
using System;

namespace Data
{
    public class Repository<TDao, TEntity> 
        where TDao : DaoBase<TEntity> 
        where TEntity : EntityId
    {
        private static TDao _dao;

        static Repository() => _dao = (TDao)Activator.CreateInstance(typeof(TDao));

        public static void Create(TEntity entity) => _dao.Create(entity);

        public static void Delete(TEntity entity) => _dao.Delete(entity);

        public static TEntity Select(int id) => _dao.Select(id);

    }
}
