
using System;
using System.Collections.Generic;
using System.Linq;
using GameAPI.Models;

namespace GameAPI.Business
{
    public static class GameBusiness
    {
        public static char GetRdnPlayer()
        {
            var random = new Random();
            var index = random.Next(2);

            if (index == 0)
                return 'O';
            else
                return 'X';
        }

        public static char ChangeTurn(char currentTurn)
        {
            if (currentTurn == 'X')
                return 'O';
            else
                return 'X';
        }

        public static List<Position> Positions(Game model)
        {
            var positions = new List<Position>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    positions.Add(new Position() { id = Guid.NewGuid(), GameID = model.Id, player = ' ', x = i, y = j });
            }
            return positions;
        }

        public static bool IsWinner(List<Position> positions, char player)
        {
            #region Win in columns
            if (positions[0].player == player && positions[1].player == player && positions[2].player == player)
                return true;

            if (positions[3].player == player && positions[4].player == player && positions[5].player == player)
                return true;

            if (positions[6].player == player && positions[7].player == player && positions[8].player == player)
                return true;
            #endregion

            #region Win in lines
            if (positions[0].player == player && positions[3].player == player && positions[6].player == player)
                return true;

            if (positions[1].player == player && positions[4].player == player && positions[7].player == player)
                return true;

            if (positions[2].player == player && positions[5].player == player && positions[8].player == player)
                return true;
            #endregion

            #region Win in X
            if (positions[0].player == player && positions[4].player == player && positions[8].player == player)
                return true;

            if (positions[6].player == player && positions[4].player == player && positions[2].player == player)
                return true;
            #endregion

            return false;
        }

        public static bool IsDraw(List<Position> positions, Guid id)
        {   
           return !positions.Select(o => o.player == ' ' && o.GameID == id).ToList().Contains(true);
        }
    }
}