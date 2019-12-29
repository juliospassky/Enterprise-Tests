using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameAPI.Models;
using GameAPI.Data;
using System;
using GameAPI.Business;

namespace GameAPI.Contoller
{
    [ApiController]
    [Route("/game")]
    public class GameController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Game>>> Get([FromServices] DataContext context)
        {
            var games = await context.Games.ToListAsync();
            return games;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Game>> Post([FromServices] DataContext context, [FromBody] Game model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                model.firstPlayer = GameBusiness.GetRdnPlayer();
                model.turn = model.firstPlayer;
                //model.matrix = GameBusiness.Positions(context);
                var matrix = new List<Position>();
                for (int i = 0; i < 9; i++)
                {
                    matrix.Add(new Position() { id = Guid.NewGuid(), GameID = model.Id, player = ' ' });
                }

                context.Positions.AddRange(matrix);

                context.Games.Include(o => o.matrix);
                context.Games.Add(model); 
                               
                await context.SaveChangesAsync();
                return model;
            }

            return (BadRequest(ModelState));
        }
    }
}