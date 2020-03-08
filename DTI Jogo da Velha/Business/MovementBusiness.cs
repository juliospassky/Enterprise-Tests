
using System;
using GameAPI.Data;
using System.Linq;
using GameAPI.Models;
using System.Collections.Generic;
using System.Drawing;

namespace GameAPI.Business
{
    public static class MovementBusiness
    {
        public static bool IsValidGameID(DataContext context, Guid id)
        {
            return context.Games.Any(o => o.Id == id);
        }

        public static bool IsPlayerTurn(DataContext context, Movement model, Guid id)
        {
            var game = context.Games.FirstOrDefault(o => o.Id == id);
            return game.turn == model.player;
        }

        public static bool IsValidPosition(DataContext context, int x, int y, Guid id)
        {         
            var matrix = context.Positions.Where(o => o.GameID == id).ToList();
            var index = GetIndex(x, y);

            if (matrix[index].player == ' ')
                return true;

            return false;
        }

        private static int GetIndex(int x, int y)
        {
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == x && j == y)
                    {
                        return index;
                    }
                    index++;
                }
            }
            return 0;
        }       
    }
}