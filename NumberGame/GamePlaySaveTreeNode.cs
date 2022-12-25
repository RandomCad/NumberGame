using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class GamePlaySaveTreeNode
    {
        public GameBord bord;
        public int[] mouve;
        public List<GamePlaySaveTreeNode> ChildTreeNodes;

        public GamePlaySaveTreeNode(GameBord x, int[] y)
        {
            bord = x;
            mouve = y;
            ChildTreeNodes = new List<GamePlaySaveTreeNode>();
        }
    }
}
