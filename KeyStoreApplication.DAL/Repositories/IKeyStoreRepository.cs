using KeyStoreApplication.Models;

namespace KeyStoreApplication.Repositories
{
    //Made by Wiut student 00013712
    public interface IKeyStoreRepository
    {
        Task<IEnumerable<KeyStore>> GetAllKeys();
        Task<KeyStore> GetSingleKey(int Id);
        Task CreateKey(KeyStore keystore);
        Task UpdateKey(KeyStore keystore);
        Task DeleteKey(int Id);
    }

    //Made by Wiut student 00013712
}
