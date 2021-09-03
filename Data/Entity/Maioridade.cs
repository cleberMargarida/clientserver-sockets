namespace Data.Entity
{
    public class Maioridade : EntityId
    {
        public virtual string Nome { get; set; }

        public virtual string Sexo { get; set; }

        public virtual int Idade { get; set; }
    }
}
