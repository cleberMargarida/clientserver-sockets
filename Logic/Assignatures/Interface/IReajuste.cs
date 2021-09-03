using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IReajuste : IService<DtoReajuste>
    {
        public string ReajusteSalarial(string nome, string cargo, double salario);
    }
}
