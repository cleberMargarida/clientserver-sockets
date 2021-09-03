using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface INatacao : IService<DtoNatacao>
    {
        public string Categoria(int idade);
    }
}
