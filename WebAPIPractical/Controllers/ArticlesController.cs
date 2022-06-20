using Microsoft.AspNetCore.Mvc;
using WebAPIPractical.Model;
using WebAPIPractical.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIPractical.Controllers
{
    [Route("api/v2")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IGenericRepository<Article> _repoArticle;

        public ArticlesController(IGenericRepository<Article> repoArticle)
        {
            _repoArticle = repoArticle;
        }

        // GET: api/<ArticlesController>
        [HttpGet("GetAllArticles")]
        public async Task<ActionResult> Get()
        {
            var articles = _repoArticle.GetAll();
            return Ok(articles);
        }

        // GET api/<ArticlesController>/5
        [HttpGet("article/{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var article = _repoArticle.GetById(id);
            return Ok(article);
        }

        // POST api/<ArticlesController>
        [HttpPost("AddArticle")]
        public async Task<ActionResult> AddArticle([FromBody] Article article)
        {
            if (ModelState.IsValid)
            {
                var result = _repoArticle.Insert(article);
                if (result)
                {
                    return Ok(article);
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

        // PUT api/<ArticlesController>/5
        [HttpPut("UpdateArticle")]
        public async Task<ActionResult> Put([FromBody] Article article)
        {
            if (ModelState.IsValid)
            {
                //article = _repoArticle.GetById(id);
                var result = _repoArticle.Update(article);
                if (result)
                {
                    return Ok(article);
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

        // DELETE api/<ArticlesController>/5
        [HttpDelete("delete-article/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var article = _repoArticle.GetById(id);
            if (article != null)
            {
                var result = _repoArticle.Delete(article);
                if (result)
                {
                    return Ok();
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
    }
}
