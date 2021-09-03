using Data.Entity;

namespace Data.Map
{
    public class MaioridadeMap : EntityIdMap<Maioridade>
    {
        public MaioridadeMap()
        {
            Map(x => x.Nome);
            Map(x => x.Idade);
            Map(x => x.Sexo);
            Table("Pessoa");
        }
    }
}