using System;
using chessboard;
using chess;
using exceptions;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame game = new ChessGame();
                Screen.ShowBoard(game.board);
            }
            catch (ChessboardException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
