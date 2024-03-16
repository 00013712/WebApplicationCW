using KeyStoreApplication.Data;
using KeyStoreApplication.Data.Migrations;
using Microsoft.EntityFrameworkCore;

namespace KeyStoreApplication.Repositories
{
    public class UsersRepository : IUserStoreRepository
    {
        private readonly KeyStoreApplicationDBContext _dbContext;

        public UsersRepository(KeyStoreApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Models.UserStore>> GetAllUsers()
        {
            var Userstores = await _dbContext.Userstore.ToListAsync();
            return Userstores;
        }

        public async Task<Models.UserStore> GetSingleUser(int Id)
        {
            return await _dbContext.Userstore.FirstOrDefaultAsync(u => u.Id == Id);
        }

        public async Task CreateUser(Models.UserStore userstore)
        {
            await _dbContext.Userstore.AddAsync(userstore);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(int Id)
        {
            var userstore = await _dbContext.Userstore.FirstOrDefaultAsync(u => u.Id == Id);
            if (userstore != null)
            {
                _dbContext.Userstore.Remove(userstore);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateUser(Models.UserStore userstore)
        {
            _dbContext.Entry(userstore).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }


    }
}
