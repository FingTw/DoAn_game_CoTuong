using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_game_CoTuong
{
    public partial class GameForm : Form
    {
        private Game _game;

        public GameForm()
        {
            InitializeComponent();
            _game = new Game();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //// Ví dụ lấy tọa độ từ giao diện (bạn có thể lấy từ các ô nhập liệu trên giao diện)
            //int startX = Convert.ToInt32(txtStartX.Text);
            //int startY = Convert.ToInt32(txtStartY.Text);
            //int endX = Convert.ToInt32(txtEndX.Text);
            //int endY = Convert.ToInt32(txtEndY.Text);

            //if (_game.MovePiece(startX, startY, endX, endY))
            //{
            //    _game.Board.DisplayBoard();  // Cập nhật lại bàn cờ sau khi di chuyển
            //}
            //else
            //{
            //    MessageBox.Show("Nước đi không hợp lệ!");
            //}
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
