using System.Threading.Tasks;

namespace lib
{
    public interface IDataStore
    {
        Dto Save(Dto dto);

        Task<Dto> SaveAsync(Dto dto);
    }
}
