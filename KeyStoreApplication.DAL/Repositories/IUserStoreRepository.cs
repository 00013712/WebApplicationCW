using KeyStoreApplication.Models;

namespace KeyStoreApplication.Repositories
{
    //Made by Wiut student 00013712
    public interface IUserStoreRepository
    {
        Task<IEnumerable<UserStore>> GetAllUsers();
        Task<UserStore> GetSingleUser(int Id);
        Task CreateUser(UserStore userstore);
        Task UpdateUser(UserStore userstore);
        Task DeleteUser(int Id);
    }

    //Made by Wiut student 00013712
}
