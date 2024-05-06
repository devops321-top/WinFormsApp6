using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class Game
    {
        private string[] symbols = ["X", "O"];
        private int steps = 0;
        private Player[] players = [new Player("X"),new Player("O")];
        public void Click(Button button,int n,Label label)
        {
            if (button.Text != "") 
                return;
            int step = steps % symbols.Length;
            label.Text = players[step].SetCombo(n);
            steps++;
            button.Text = symbols[step];
        }
    }
}
