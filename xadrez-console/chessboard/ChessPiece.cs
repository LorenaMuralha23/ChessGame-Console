using System;
using System.Collections.Generic;
using System.Text;

namespace chessboard
{
    class ChessPiece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int qntMovement { get; protected set; }
        public Chessboard chessboard { get; protected set; }

        public ChessPiece(Position position, Color color, Chessboard chessboard)
        {
            this.position = position;
            this.color = color;
            this.chessboard = chessboard;
            this.qntMovement = 0;
        }
    }
}
