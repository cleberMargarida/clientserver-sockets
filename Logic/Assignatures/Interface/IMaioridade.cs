using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IMaioridade : IService<DtoMaioridade>
    {
        public string EhMaiorIdade(string nome, string sexo, int idade);
    }
}
