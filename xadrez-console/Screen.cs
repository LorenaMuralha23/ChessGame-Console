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

                for (int j = 0; j < board.columns; j++)
                {

                    if (board.Piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(board.Piece(i, j) + " ");
                    }

                }

                Console.WriteLine();

            }

        }

    }
}
