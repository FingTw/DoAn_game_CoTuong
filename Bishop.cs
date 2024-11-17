using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Bishop : ChessPiece
    {
        public Bishop(string color, int x, int y) : base(color, x, y) { }

        public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Tượng di chuyển chéo
            return Math.Abs(startX - endX) == Math.Abs(startY - endY);
        }
    }
}
