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

        public ChessPiece(Chessboard chessboard, Color color)
        {
            this.position = null;
            this.color = color;
            this.chessboard = chessboard;
            this.qntMovement = 0;
        }

        public void AddMovement()
        {
            qntMovement++;
        }

    }
}
