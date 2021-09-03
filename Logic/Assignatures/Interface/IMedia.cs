using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IMedia : IService<DtoMedia>
    {
        public string ReajusteSalarial(float n1, float n2, float n3);
    }
}
