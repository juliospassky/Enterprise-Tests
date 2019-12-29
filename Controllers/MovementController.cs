using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameAPI.Models;
using GameAPI.Data;
using System;
using System.Linq;
using GameAPI.Business;

namespace GameAPI.Contoller
{
    [ApiController]
    [Route("/game/{id:guid}/movement")]
    public class MovementController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Movement>> Post([FromServices] DataContext context, [FromBody] Movement model, Guid id)
        {
            if (ModelState.IsValid)
            {
                
                #region Validations Post
                if (!MovementBusiness.IsValidGameID(context, id))
                    return (NotFound("Partida não encontrada"));

                if (!MovementBusiness.IsPlayerTurn(context, model, id))
                    return (NotFound("Não é turno do jogador"));

                if (!MovementBusiness.IsValidPosition(context, model.position.x, model.position.y, id))
                    return (NotFound("Posição inválida"));
                #endregion


                model.Id = Guid.NewGuid();
                context.Movements.Add(model);

                var game = context.Games.FirstOrDefault(o => o.Id == id);
                game.turn = GameBusiness.ChangeTurn(game.turn);

                var position = context.Positions.FirstOrDefault(o => o.GameID == id);
                position.player = model.player;

                await context.SaveChangesAsync();

                #region Validations End Game
                if (GameBusiness.IsWinner(game.matrix.ToList(), model.player))
                    return (NotFound($"Partida finalizada, win {model.player}"));

                if (GameBusiness.IsDraw(game.matrix.ToList()))
                {
                    return (NotFound("Partida finalizada, draw"));
                }
                #endregion

                return model;
            }

            return (BadRequest(ModelState));
        }
    }
}