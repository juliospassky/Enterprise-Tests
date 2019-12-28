using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GameAPI.Models;
using GameAPI.Data;
using System;
using System.Linq;
using System.Net;
using GameAPI.Business;

namespace GameAPI.Contoller
{
    [ApiController]
    [Route("/game/{id:guid}/movement")]
    public class MovementController : ControllerBase
    {
        private DataContext _context;
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Movement>> Post([FromServices] DataContext context, [FromBody] Movement model, Guid id)
        {
            if(ModelState.IsValid)
            {
                #region Validations
                    if(!MovementBusiness.IsValidGameID(context, id))
                        return(NotFound("Partida não encontrada"));
                    
                    if(!MovementBusiness.IsPlayerTurn(context, model, id))
                        return(NotFound("Não é turno do jogador"));

                #endregion


                model.Id = Guid.NewGuid();
                context.Movements.Add(model);

                var game = context.Games.FirstOrDefault(o => o.Id == id);      
                game.turn = GameBusiness.ChangeTurn(game.turn);
                
                await context.SaveChangesAsync();
                return model;
            }
            
            return(BadRequest(ModelState));           
        }
    }
}