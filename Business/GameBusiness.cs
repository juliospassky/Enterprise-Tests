
using System;

namespace GameAPI.Business
{
    public static class GameBusiness
    {
        public static char GetRdnPlayer(){
            var random = new Random();
            var index =  random.Next(2);
            
            if(index == 0)
                return 'O';
            else 
                return 'X';
        }

        public static char ChangeTurn(char currentTurn){
            if(currentTurn == 'X')
                return 'O';
            else 
                return 'X';
        }
    }
}