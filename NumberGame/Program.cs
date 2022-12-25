using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    static class Program
    {
        private static GamePlaySaveClass GamePlay;
        static void Main(string[] args)
        {
            GamePlay = GamePlaySaveClass.Instance;
            GameBord bord = new GameBord();
            bool player1IsActiv = true;
            int[] mouve = new int[3];
            do
            {
                Console.Write(((player1IsActiv) ? "Player 1:" : "Player 2:") + $"\n{bord.Bord[0]}\t\n{bord.Bord[1]}\t\n{bord.Bord[2]}\t");
                Console.CursorTop -= 2;
                mouve[0] = int.Parse(Console.ReadLine());
                Console.Write($"{bord.Bord[1]}\t");
                mouve[1] = int.Parse(Console.ReadLine());
                Console.Write($"{bord.Bord[2]}\t");
                mouve[2] = int.Parse(Console.ReadLine());
                player1IsActiv = !player1IsActiv;
            } while (!bord.Mouve(mouve));
        }
    }
}
