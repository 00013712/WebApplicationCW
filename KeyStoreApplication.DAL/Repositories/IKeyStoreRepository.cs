using KeyStoreApplication.Models;

namespace KeyStoreApplication.Repositories
{
    public interface IKeyStoreRepository
    {
        Task<IEnumerable<KeyStore>> GetAllKeys();
        Task<KeyStore> GetSingleKey(int Id);
        Task CreateKey(KeyStore keystore);
        Task UpdateKey(KeyStore keystore);
        Task DeleteKey(int Id);
    }
}
