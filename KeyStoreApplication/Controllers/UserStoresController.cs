using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeyStoreApplication.Data;
using KeyStoreApplication.Models;
using KeyStoreApplication.Repositories;

namespace KeyStoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStoresController : ControllerBase
    {
        private readonly KeyStoreApplicationDBContext _context;
        private readonly IUserStoreRepository _usersStoreRepository;
        public UserStoresController(IUserStoreRepository usersStoreRepository)
        {
            _usersStoreRepository = usersStoreRepository;
        }

        // GET: api/KeyStores
        [HttpGet]
        public async Task<IEnumerable<UserStore>> GetUsers()
        {
            return await _usersStoreRepository.GetAllUsers();
        }

        // GET: api/KeyStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserStore>> GetUserStore(int id)
        {
            var userstore = await _usersStoreRepository.GetSingleUser(id);
            if (userstore == null)
            {
                return NotFound();
            }
            return Ok(userstore);
        }

        // PUT: api/KeyStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserStore(int id, UserStore userStore)
        {
            if (id != userStore.Id)
            {
                return BadRequest();
            }

            /* _context.Entry(keyStore).State = EntityState.Modified;*/

            await _usersStoreRepository.UpdateUser(userStore);

            return NoContent();
        }

        // POST: api/KeyStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserStore>> PostUserStore(UserStore userStore)
        {
            await _usersStoreRepository.CreateUser(userStore);
            return CreatedAtAction("GetUserStore", new { id = userStore.Id }, userStore);
        }

        // DELETE: api/KeyStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserStore(int id)
        {
            await _usersStoreRepository.DeleteUser(id);
            return NoContent();
        }
    }
}
