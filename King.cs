using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class King : ChessPiece
    {
        
            public King(string color, int x, int y) : base(color, x, y) { }

            public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
            {
                // Tướng di chuyển 1 ô trong phạm vi cung điện
                return Math.Abs(startX - endX) <= 1 && Math.Abs(startY - endY) <= 1;
            }
        }
    
}
