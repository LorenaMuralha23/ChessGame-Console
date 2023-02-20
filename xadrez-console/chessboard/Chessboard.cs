using System;
using System.Collections.Generic;
using System.Text;
using exceptions;

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

        public ChessPiece Piece(Position pos)
        {
            ValidPosition(pos);
            return pieces[pos.line, pos.column];
        }

        public void AddPiece(ChessPiece p, Position pos)
        {
            if (ThereIsPiece(pos))
            {
                throw new ChessboardException("Position Error: There is already a piece on this position!");
            }

            pieces[pos.line, pos.column] = p; 
            p.position = pos;
        }

        public bool ThereIsPiece(Position pos)
        {
            ValidatePosition(pos);
            return Piece(pos) != null;
        }

        public bool ValidPosition(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new ChessboardException("Invalid Position!");
            }
        }

    }
}
