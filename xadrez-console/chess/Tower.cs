using System;
using chessboard;

namespace chess
{
    class Tower : ChessPiece
    {

        public Tower(Chessboard board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}

