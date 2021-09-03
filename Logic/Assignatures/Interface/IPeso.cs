using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IPeso : IService<DtoPeso>
    {
        public string PesoIdeal(string sexo, double altura);
    }
}
