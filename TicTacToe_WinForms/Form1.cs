using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_WinForms
{
    enum GameStatus
    {
        Reset,
        Cross,
        Zero
    }

    enum CellStatus
    {
        Empty,
        Cross,
        Zero
    }

    public partial class Form1 : Form
    {
        Game game = null;
        Button[,] buttonArray = new Button[3, 3];
        Cell[,] Cells = new Cell[3, 3];

        public Form1()
        {
            InitializeComponent();            

            Cells[0, 0] = new Cell(btn1);
            Cells[0, 1] = new Cell(btn2);
            Cells[0, 2] = new Cell(btn3);

            Cells[1, 0] = new Cell(btn4);
            Cells[1, 1] = new Cell(btn5);
            Cells[1, 2] = new Cell(btn6);
            
            Cells[2, 0] = new Cell(btn7);
            Cells[2, 1] = new Cell(btn8);
            Cells[2, 2] = new Cell(btn9);

            game = new Game(Cells);
            game.Reset();
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            game.Reset();
        }
    }
}
