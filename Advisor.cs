using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Advisor : ChessPiece
    {
        public Advisor(string color, int x, int y) : base(color, x, y) { }

        public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
        {
            // Sĩ di chuyển chéo trong cung điện
            return Math.Abs(startX - endX) == 1 && Math.Abs(startY - endY) == 1;
        }
    }
}
