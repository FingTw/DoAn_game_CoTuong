using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{

    internal class Pawn : ChessPiece
        {
            public Pawn(string color, int x, int y) : base(color, x, y) { }

            public override bool CanMove(int startX, int startY, int endX, int endY, ChessBoard board)
            {
                // Tốt di chuyển 1 ô về phía trước, nhưng nếu qua sông thì có thể di chuyển ngang
                if (this.Color == "Red")
                {
                    return (startX == endX && endY == startY + 1); // Di chuyển thẳng
                }
                else
                {
                    return (startX == endX && endY == startY - 1); // Di chuyển thẳng
                }
            }
        }
    }

