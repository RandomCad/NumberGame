using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class Program
    {
        private static int[] GameBord = new int[3] { 4, 6, 8 };
        static void Main(string[] args)
        {
            bool player1IsActiv = true;
            while (!ChekVorGameEnd())
            {
                int[] mouve = new int[3];
                Console.Write(((player1IsActiv) ? "Player 1:" : "Player 2:") + $"\n{GameBord[0]}\t\n{GameBord[1]}\t\n{GameBord[2]}\t");
                Console.CursorTop -= 2;
                mouve[0] = int.Parse(Console.ReadLine());
                Console.Write($"{GameBord[1]}\t");
                mouve[1] = int.Parse(Console.ReadLine());
                Console.Write($"{GameBord[2]}\t");
                mouve[2] = int.Parse(Console.ReadLine());
                for (int i = 0; i < 3; i++) GameBord[i] -= mouve[i];
                player1IsActiv = !player1IsActiv;
            }
            //Todo: write the game loop
            //Todo: write the game logic 

        }

        private static bool ChekVorGameEnd()
        {
            bool isGreterOrWon = false;
            foreach (var item in GameBord)
            {
                if (item > 0 && !isGreterOrWon) isGreterOrWon = true;
                else if (item > 0) return false;
            }
            return true;
        }
    }
}
