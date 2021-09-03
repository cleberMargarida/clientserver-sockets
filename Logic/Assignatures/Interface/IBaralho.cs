using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IBaralho : IService<DtoBaralho>
    {
        public string NomeDaCarta(int numero, int naipe);
    }
}
