using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal abstract class ChessPiece
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public ChessPiece(string color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }

        // Phương thức di chuyển cần được triển khai ở các lớp con
        public abstract bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board);

    }
}