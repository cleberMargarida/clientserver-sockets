using Logic.Assignatures.Interface;
using Logic.Assignatures.DTO;

namespace Logic.Implementations
{
    /// <summary>
    /// Questão 7
    /// </summary>
    public class Aposentadoria : IAposentadoria
    {
        public string GetResponse(DtoAposentadoria dto) => PermiteAposentadoria(dto.Idade, dto.Tempo);

        public string PermiteAposentadoria(int idade, int tempo)
        {
            if (idade < 0 || idade > 100) return "Idade invalida.";
            if (tempo < 0 || tempo > 80) return "Tempo de contribuicao invalido.";

            if (idade >= 65 || tempo >= 30 || (idade >= 60 && tempo >= 25)) return "Aposentadoria liberada!";

            return "Aposentadoria nao permitida.";
        }
    }
}
