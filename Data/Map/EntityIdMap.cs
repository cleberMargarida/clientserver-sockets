using Data.Entity;
using FluentNHibernate.Mapping;

namespace Data.Map
{
    public class EntityIdMap<T> : ClassMap<T> where T : EntityId
    {
        public EntityIdMap() => Id(x => x.Id).GeneratedBy.Increment();
    }
}