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
                var positions = GameBusiness.Positions(model);
                
                context.Positions.AddRange(positions);
                context.Games.Add(model); 
                               
                await context.SaveChangesAsync();
                return model;
            }

            return (BadRequest(ModelState));
        }
    }
}