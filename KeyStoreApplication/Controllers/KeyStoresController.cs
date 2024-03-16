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
    public class KeyStoresController : ControllerBase
    {
        private readonly KeyStoreApplicationDBContext _context;
        private readonly IKeyStoreRepository _keysStoreRepository;
        public KeyStoresController(IKeyStoreRepository keysStoreRepository)
        {
            _keysStoreRepository = keysStoreRepository;
        }

        // GET: api/KeyStores
        [HttpGet]
        public async Task<IEnumerable<KeyStore>> Getkeystores()
        {
            return await _keysStoreRepository.GetAllKeys();
        }

        // GET: api/KeyStores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KeyStore>> GetKeyStore(int id)
        {
            var keystore = await _keysStoreRepository.GetSingleKey(id);
            if (keystore == null)
            {
                return NotFound();
            }
            return Ok(keystore);
        }

        // PUT: api/KeyStores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKeyStore(int id, KeyStore keystore)
        {
            if (id != keystore.Id)
            {
                return BadRequest();
            }
            await _keysStoreRepository.UpdateKey(keystore);
            return NoContent();
        }

        // POST: api/KeyStores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KeyStore>> PostKeyStore(KeyStore keystore)
        {
            await _keysStoreRepository.CreateKey(keystore);
            return CreatedAtAction("GetKeyStore", new { id = keystore.Id }, keystore);
        }

        // DELETE: api/KeyStores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKeyStore(int id)
        {
            await _keysStoreRepository.DeleteKey(id);
            return NoContent();
        }
    }
}
