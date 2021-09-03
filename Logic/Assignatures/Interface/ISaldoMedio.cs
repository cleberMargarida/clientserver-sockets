using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface ISaldoMedio : IService<DtoSaldoMedio>
    {
        public string CalculoDeCredito(double saldo);
    }
}
