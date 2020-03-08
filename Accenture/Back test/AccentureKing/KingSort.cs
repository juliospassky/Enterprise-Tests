using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccentureKing
{
    public class KingSort
    {
        public string[] kings;

        public KingSort(string[] kings)
        {
            this.kings = kings;
        }

        /// <summary>Ordenação pelo método da Bolha</summary>
        /// <param name="kings">Reis</param>
        /// <returns>Arranjo ordenado</returns>
        public string[] GetSortedList(string[] kings)
        {
             return kings.OrderBy(c => c, new AlphanumComparator()).ToArray();
        }
    }

}
