using System;
using chessboard;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard cB = new Chessboard(8, 8);


            Screen.ShowBoard(cB);

        }
    }
}
