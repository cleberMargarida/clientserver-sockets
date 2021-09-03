using Data.Entity;
using FluentNHibernate.Mapping;

namespace Data.Map
{
    class MaioridadeMap : ClassMap<Maioridade>
    {
        public MaioridadeMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Nome);
            Map(x => x.Idade);
            Map(x => x.Sexo);
            Table("Pessoa");
        }
    }
}