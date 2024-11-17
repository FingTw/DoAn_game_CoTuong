using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class ChessLogic
    {
        private ChessBoard _board;

        public ChessLogic(ChessBoard board)
        {
            _board = board;
        }

        public bool IsCheckmate(string currentPlayer)
        {
            ChessPiece enemyKing = FindKing(currentPlayer == "Red" ? "Black" : "Red");

            if (enemyKing != null && IsInCheck(enemyKing))
            {
                return !CanEscapeCheck(enemyKing);
            }

            return false;
        }

        private ChessPiece FindKing(string color)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    ChessPiece piece = _board.GetPieceAt(row, col);
                    if (piece is King && piece.Color == color)
                    {
                        return piece;
                    }
                }
            }
            return null;
        }

        private bool IsInCheck(ChessPiece king)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    ChessPiece piece = _board.GetPieceAt(row, col);
                    if (piece != null && piece.Color != king.Color && piece.CanMove(row, col, king.X, king.Y, _board))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CanEscapeCheck(ChessPiece king)
        {
            for (int x = king.X - 1; x <= king.X + 1; x++)
            {
                for (int y = king.Y - 1; y <= king.Y + 1; y++)
                {
                    if (IsValidPosition(x, y) && !IsInCheck(king))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < 10 && y >= 0 && y < 9;
        }
    }
}
