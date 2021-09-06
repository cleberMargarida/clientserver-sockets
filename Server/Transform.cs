using Data.Entity;
using Logic.Assignatures.DTO;

namespace Server
{
    public static class Transform
    {
        public static Maioridade InEntity(DtoMaioridade dto) => new Maioridade
        {
            Id = 0,
            Idade = dto.Idade,
            Nome = dto.Nome,
            Sexo = dto.Sexo
        };
    }
}
