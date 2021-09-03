using Logic.Assignatures.DTO;

namespace Logic.Assignatures.Interface
{
    public interface IService<Dto> where Dto : DtoBase
    {
        public string GetResponse(Dto dto);
    }
}
