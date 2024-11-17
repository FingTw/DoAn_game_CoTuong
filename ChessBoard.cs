using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class ChessBoard
    {
        private ChessPiece[,] board = new ChessPiece[10, 9]; // Ma trận bàn cờ

        public ChessBoard()
        {
            // Khởi tạo bàn cờ với các quân cờ ban đầu
            InitializeBoard();
        }

        // Khởi tạo bàn cờ với các quân cờ
        private void InitializeBoard()
        {
            // Đặt các quân cờ vào vị trí ban đầu (chỉ là ví dụ, cần các lớp con của ChessPiece)
            board[0, 0] = new Rook("Black", 0, 0);  // Ví dụ cho quân xe
                                                    // Tiếp tục thêm các quân cờ khác như mã, tượng, sĩ, tướng, etc.
        }

        public ChessPiece GetPieceAt(int x, int y)
        {
            return board[x, y]; // Trả về quân cờ tại vị trí x, y
        }

        // Hiển thị bàn cờ lên GUI
        public void DisplayBoard()
        {
            // Cần thiết lập GUI để hiển thị ma trận bàn cờ
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    ChessPiece piece = board[row, col];
                    Console.Write(piece != null ? piece.ToString() : "Empty");
                }
                Console.WriteLine();
            }
        }

        // Di chuyển quân cờ
        public bool MovePiece(int startX, int startY, int endX, int endY)
        {
            ChessPiece piece = board[startX, startY];

            if (piece != null && piece.CanMove(startX, startY, endX, endY, this))
            {
                board[endX, endY] = piece;
                board[startX, startY] = null;
                return true; // Di chuyển thành công
            }
            return false; // Nước đi không hợp lệ
        }

        // Kiểm tra điều kiện chiếu tướng
        public bool IsCheckmate()
        {
            // Giả sử kiểm tra chiếu tướng đối với Tướng
            ChessPiece enemyKing = FindKing("Red"); // Tìm tướng của đối phương
            return enemyKing != null && IsInCheck(enemyKing); // Kiểm tra chiếu tướng
        }

        private ChessPiece FindKing(string color)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    ChessPiece piece = board[row, col];
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
                    ChessPiece piece = board[row, col];
                    if (piece != null && piece.Color != king.Color && piece.CanMove(row, col, king.X, king.Y, this))
                    {
                        return true; // Tướng đang bị chiếu
                    }
                }
            }
            return false;
        }
    }
}
