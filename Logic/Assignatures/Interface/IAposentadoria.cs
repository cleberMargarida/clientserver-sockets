using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IAposentadoria : IService<DtoAposentadoria>
    {
        public string PermiteAposentadoria(int idade, int tempo);
    }
}
