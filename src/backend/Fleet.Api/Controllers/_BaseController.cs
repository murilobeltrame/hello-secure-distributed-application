using Fleet.Api.Models.Entities;
using Fleet.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Fleet.Api.Controllers
{
	public abstract class BaseController<T> : Controller where T: BaseEntity
    {
        private readonly BaseRepository<T> _repository;

        public BaseController(BaseRepository<T> repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Fetch()
        {
            return Ok(await _repository.FetchAsync());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] T value)
        {
            if (value == null || !ModelState.IsValid) return BadRequest();
            var result = await _repository.CreateAsync(value);
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return NotFound();
            await _repository.DeleteAsync(entity);
            return NoContent();
        }
    }
}

