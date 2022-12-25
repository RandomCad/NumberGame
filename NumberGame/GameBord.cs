using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class GameBord
    {
        public int[] Bord = new int[] { 4, 6, 8 };

        public GameBord()
        {
            //throw new NotImplementedException();
        }
        public bool Mouve(int[] mouve)
        {
            if (!IsValidMouve(mouve))
            {
                Console.WriteLine("Your input wasn't a valide mouve pleas retry.");
                return false;
            }
            for (int i = 0; i < 3; i++) Bord[i] -= mouve[i];
            return IsWineMouve();
        }
        private bool IsWineMouve()
        {
            foreach (var item in Bord) if (item > 1) return false;
            return true;
        }
        private bool IsValidMouve(int[] mouve)
        {
            bool ContainsAMouve = false;
            foreach (var item in mouve)
            {
                if (item < 0) return false;
                if (item > 0 && !ContainsAMouve) ContainsAMouve = true;
                else if (item > 0) return false;
            }
            return true;
        }
        private void SaveMouve()
        {
            throw new NotImplementedException();
        }
    }
}
