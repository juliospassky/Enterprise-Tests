
using System;
using GameAPI.Data;
using System.Linq;
using GameAPI.Models;

namespace GameAPI.Business
{
    public static class MovementBusiness
    {
        public static bool IsValidGameID(DataContext context, Guid id){            
            return context.Games.Any(o => o.Id == id);
        }

        public static bool IsPlayerTurn(DataContext context, Movement model, Guid id){            
            var game = context.Games.FirstOrDefault(o => o.Id == id);  
            return game.turn == model.player;
        }
    }
}