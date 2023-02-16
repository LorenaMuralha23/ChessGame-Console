using System;
using chessboard;
using chess;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard cB = new Chessboard(8, 8);


            cB.AddPiece(new Tower(cB, Color.Preta), new Position(0, 0));
            cB.AddPiece(new Tower(cB, Color.Preta), new Position(1, 3));
            cB.AddPiece(new King(cB, Color.Preta), new Position(2, 4));

            Screen.ShowBoard(cB);

        }
    }
}
