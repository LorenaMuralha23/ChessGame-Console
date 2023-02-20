using System;
using chessboard;

namespace chess
{
    class ChessGame
    {
        public Chessboard board { get; private set; }
        private int shift;
        private Color currentPlayer;

        public ChessGame()
        {
            board = new Chessboard(8, 8);
            shift = 1;
            currentPlayer = Color.Branca;
            AddPiece();
        }

        public void ExecuteMove(Position origin, Position destiny)
        {
            ChessPiece p = board.RemovePiece(origin);
            p.AddMovement();
            ChessPiece catchPiece = board.RemovePiece(destiny);
            board.AddPiece(p, destiny);
        }

        public void AddPiece()
        {
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('c', 1).ToPosition());
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('c', 2).ToPosition());
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('d', 2).ToPosition());
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('e', 2).ToPosition());
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('e', 1).ToPosition());
            board.AddPiece(new Tower(board, Color.Branca), new ChessPosition('d', 1).ToPosition());

            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('c', 7).ToPosition());
            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('c', 8).ToPosition());
            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('d', 7).ToPosition());
            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('e', 7).ToPosition());
            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('e', 8).ToPosition());
            board.AddPiece(new Tower(board, Color.Preta), new ChessPosition('d', 8).ToPosition());
        }
       
    }
}
