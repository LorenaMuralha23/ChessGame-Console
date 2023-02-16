using System;
using chessboard;

namespace chess
{
    class King : ChessPiece
    {

        public King(Chessboard board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "K";
        }

    }
}
