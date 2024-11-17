using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Rook : ChessPiece
    {
        public Rook(string color, int x, int y) : base(color, x, y) { }

        public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Xe di chuyển theo hàng ngang hoặc dọc không bị cản trở
            return startX == endX || startY == endY;
        }
    }
}
