using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            Start();
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations.. You Won !!");
            Close();
        }

        public void Start()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Block_MouseEnter(object sender, EventArgs e)
        {
            Start();
        }
    }
}
