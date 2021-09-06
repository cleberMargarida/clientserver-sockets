using Data.DAO;
using Data.Entity;

namespace Data
{
    public class DataPersistence<TEntity> where TEntity : EntityId
    {
        private static DaoBase<TEntity> _dao;

        static DataPersistence() => _dao = new DaoBase<TEntity>();

        public static void Create(TEntity entity) => _dao.Create(entity);

        public static void Update(TEntity entity) => _dao.Update(entity);

        public static void Delete(TEntity entity) => _dao.Delete(entity);

        public static TEntity Select(int id) => _dao.Select(id);

    }
}
