using Microsoft.AspNetCore.Mvc;
using WebAPIPractical.Model;
using WebAPIPractical.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPractical.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IGenericRepository<User> _repoUser;

        public LoginController(IGenericRepository<User> repoUser)
        {
            _repoUser = repoUser;
        }

        [HttpGet("get-profile/{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var user = _repoUser.GetById(id);
            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                var result = _repoUser.Insert(user);
                if (result)
                {
                    return Ok(user);
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }

        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
