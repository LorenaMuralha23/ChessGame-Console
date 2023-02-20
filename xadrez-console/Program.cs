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
            ChessPosition position = new ChessPosition('c', 7);

            Console.WriteLine(position);
            Console.WriteLine(position.ToPosition());


        }
    }
}
