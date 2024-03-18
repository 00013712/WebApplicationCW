using KeyStoreApplication.Data;
using KeyStoreApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace KeyStoreApplication.Repositories
{
    public class KeysRepository : IKeyStoreRepository
    {
        private readonly KeyStoreApplicationDBContext _dbContext;

        public KeysRepository(KeyStoreApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<KeyStore>> GetAllKeys()
        {
            var keystores = await _dbContext.Keystore.Include(k => k.UserStore).ToListAsync();
            return keystores;
        }

        public async Task<KeyStore> GetSingleKey(int Id)
        {
            return await _dbContext.Keystore.Include(k => k.UserStore).FirstOrDefaultAsync(k => k.Id == Id);
        }

        public async Task CreateKey(KeyStore keystore)
        {
            await _dbContext.Keystore.AddAsync(keystore);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteKey(int Id)
        {
            var keystore = await _dbContext.Keystore.FirstOrDefaultAsync(k => k.Id == Id);
            if (keystore != null)
            {
                _dbContext.Keystore.Remove(keystore);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateKey(KeyStore keystore)
        {
            _dbContext.Entry(keystore).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
