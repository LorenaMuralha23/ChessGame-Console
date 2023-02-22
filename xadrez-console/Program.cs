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

                while (!game.isFinished)
                {
                    Console.Clear();

                    Screen.ShowBoard(game.board);
                    Console.WriteLine();
                    Console.Write("Digite a origem: ");
                    Position origin = (Screen.ReadChessPosition()).ToPosition();

                    Console.Write("Digite o destino: ");
                    Position destiny = (Screen.ReadChessPosition()).ToPosition();

                    game.ExecuteMove(origin, destiny);
                }


            }
            catch (ChessboardException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
