using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    public sealed class GamePlaySaveClass
    {
        private static GamePlaySaveClass SingletonInstance = null;
        private static readonly object padlock = new object();

        public static GamePlaySaveClass Instance
        {
            get
            {
                lock (padlock)
                {
                    if (SingletonInstance == null)
                    {
                        SingletonInstance = new GamePlaySaveClass();
                    }
                    return SingletonInstance;
                }
            }
        }


        GameBord[] bords;
        int[][] refrenzes;

        GamePlaySaveClass()
        {
        }
        public void SaveMouve()
        {
            throw new NotImplementedException();
        }
    }
}
