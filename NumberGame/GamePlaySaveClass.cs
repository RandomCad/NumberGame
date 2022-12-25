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


        GamePlaySaveTreeNode StartNode;

        GamePlaySaveClass()
        {
            StartNode = new GamePlaySaveTreeNode(new GameBord(GameBord.StartBord), new int[0]);
            //Todo: add the methode wich reads the saved states form a/the file.
        }
        public void SaveMouve()
        {
            throw new NotImplementedException();
        }
    }
}
