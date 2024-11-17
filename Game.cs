using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_game_CoTuong
{
    internal class Game
    {
        private ChessBoard _board;
        private ChessLogic _logic;
        private string currentPlayer;

        public Game()
        {
            _board = new ChessBoard();
            _logic = new ChessLogic(_board);
            currentPlayer = "Red";  // Bắt đầu với người chơi "Red"
        }

        public void StartGame()
        {
            // Hiển thị bàn cờ ban đầu
            _board.DisplayBoard();

            // Lượt chơi sẽ diễn ra ở đây (giả sử có một vòng lặp cho lượt đi)
            while (true)
            {
                // Hiển thị lượt chơi của người chơi hiện tại
                Console.WriteLine($"Lượt của {currentPlayer}");

                // Tiến hành di chuyển quân cờ
                if (MoveTurn())
                {
                    _board.DisplayBoard(); // Cập nhật bàn cờ sau khi di chuyển
                }

                // Kiểm tra xem có chiếu tướng không
                if (_logic.IsCheckmate(currentPlayer))
                {
                    Console.WriteLine($"{currentPlayer} thua cuộc! Chiếu tướng!");
                    break;
                }

                // Chuyển lượt cho người chơi còn lại
                currentPlayer = currentPlayer == "Red" ? "Black" : "Red";
            }
        }

        private bool MoveTurn()
        {
            // Xử lý di chuyển quân cờ trong lượt đi
            // Yêu cầu người chơi nhập tọa độ và thực hiện di chuyển

            // Ví dụ:
            // int startX = 1, startY = 1, endX = 2, endY = 2;
            // return _board.MovePiece(startX, startY, endX, endY);

            // Tạm thời trả về true cho ví dụ
            return true;
        }
    }
}
