using System;
using System.Collections.Generic;
using System.Text;
using chessboard;

namespace chess
{
    class ChessPosition
    {

        public char columns { get; set; }
        public int lines { get; set; }

        public ChessPosition()
        {
        }

        public ChessPosition(char column, int line)
        {
            this.columns = column;
            this.lines = line;
        }

        public Position ToPosition()
        {
            return new Position(8 - lines, columns - 'a'); 
        }

        public override string ToString()
        {
            return "" + columns + lines;
        }

    }
}
