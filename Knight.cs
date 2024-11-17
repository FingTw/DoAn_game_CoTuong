using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Knight : ChessPiece
    {
        public Knight(string color, int x, int y) : base(color, x, y) { }

        public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Mã di chuyển theo hình chữ L
            return (Math.Abs(startX - endX) == 2 && Math.Abs(startY - endY) == 1) ||
                   (Math.Abs(startX - endX) == 1 && Math.Abs(startY - endY) == 2);
        }
    }
}
