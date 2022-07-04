using _10DesignPattern.Models;
using _10DesignPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace _10DesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RankController : Controller
    {
        private IRankService rankService;
        public RankController(HeroDBContext context)
        {
            rankService = new RankService(context);
        }

        [HttpGet]
        public ActionResult<List<Ranks>> Get(string keyword)
        {
            try
            {
                return rankService.Search(keyword);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post(Ranks ranks)
        {
            try
            {
                var data = rankService.Create(ranks);
                return Ok(data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
