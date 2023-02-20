using System;
using chessboard;

namespace xadrez_console
{
    class Screen
    {

        public static void ShowBoard(Chessboard board)
        {

            for (int i = 0; i < board.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.columns; j++)
                {

                    if (board.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }

                }

                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");

        }

        public static void PrintPiece(ChessPiece piece)
        {
            if (piece.color == Color.Branca)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }

    }
}
