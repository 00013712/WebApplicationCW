using KeyStoreApplication.Models;

namespace KeyStoreApplication.Repositories
{
    public interface IUserStoreRepository
    {
        Task<IEnumerable<UserStore>> GetAllUsers();
        Task<UserStore> GetSingleUser(int Id);
        Task CreateUser(UserStore userstore);
        Task UpdateUser(UserStore userstore);
        Task DeleteUser(int Id);
    }
}
