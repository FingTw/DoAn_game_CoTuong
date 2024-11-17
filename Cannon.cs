using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Cannon :ChessPiece
    {
        public Cannon(string color, int x, int y) : base(color, x, y) { }

        public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Pháo di chuyển như Xe nhưng phải có quân cản đường nếu muốn ăn quân đối phương
            if (startX == endX || startY == endY)
            {
                // Kiểm tra nếu có quân cản đường
                return IsBlockedForCapture(startX, startY, endX, endY, board);
            }
            return false;
        }

        private bool IsBlockedForCapture(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Kiểm tra có quân cờ cản đường không (cần thêm chi tiết kiểm tra quân cản)
            return true; // Đơn giản hoá cho ví dụ
        }
    }
}
