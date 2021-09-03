using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface ISalario : IService<DtoSalario>
    {
        public string CalculoSalarioLiquido(string nome, string nivel, double salario, int dependentes);
    }
}
