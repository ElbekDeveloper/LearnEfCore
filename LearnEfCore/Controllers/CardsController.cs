using LearnEfCore.Data;
using LearnEfCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnEfCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CardsController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Card>> PostAsync(Card card)
        {
            await this.applicationDbContext.Cards.AddAsync(card);
            await this.applicationDbContext.SaveChangesAsync();

            return Ok(card);
        }
    }
}
