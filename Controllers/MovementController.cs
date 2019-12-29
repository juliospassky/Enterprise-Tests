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
                    return new JsonResult(new {msg = "Partida não encontrada"});
                
                if (!MovementBusiness.IsPlayerTurn(context, model, id))
                    return new JsonResult(new {msg = "Não é turno do jogador"});

                if (!MovementBusiness.IsValidPosition(context, model.position.x, model.position.y, id))
                    return new JsonResult(new {msg = "Posição inválida"});
                #endregion


                model.Id = Guid.NewGuid();
                context.Movements.Add(model);

                var game = context.Games.FirstOrDefault(o => o.Id == id);
                game.turn = GameBusiness.ChangeTurn(game.turn);

                var positions = context.Positions.FirstOrDefault(o => o.GameID == id && o.x == model.position.x && o.y == model.position.y);
                positions.player = model.player;

                await context.SaveChangesAsync();

                var finalPositions = context.Positions.Where(o => o.GameID == id).ToList();

                #region Validations End Game
                if (GameBusiness.IsWinner(finalPositions, model.player))
                    return new JsonResult(new {msg = "Partida finalizada", winner = $"{model.player}"});

                if (GameBusiness.IsDraw(finalPositions, id))
                    return new JsonResult(new {msg = "Partida finalizada", winner = "Draw"});
                
                #endregion

                return model;
            }

            return (BadRequest(ModelState));
        }
    }
}