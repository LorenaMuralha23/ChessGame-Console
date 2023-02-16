﻿using System;
using System.Collections.Generic;
using System.Text;

namespace chessboard
{
    class Chessboard
    {

        public int lines { get; set; }
        public int columns { get; set; }
        private ChessPiece[,] pieces;

        public Chessboard(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new ChessPiece[lines, columns];
        }

        public ChessPiece Piece(int line, int column)
        {
            return pieces[line, column];
        }

        public void AddPiece(ChessPiece p, Position pos)
        {
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }

    }
}
