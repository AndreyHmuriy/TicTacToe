using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe_WinForms_MVP.Controls;

namespace TicTacToe_WinForms_MVP
{
    public partial class Form1 : Form, IView
    {
        readonly Table table;
        public event EventHandler<EventArgs> Reset;

        public Table Table
        {
            get => table;
        }

        public Form1()
        {
            InitializeComponent();

            table = new Table(3, 3);
            
            table[0, 0] = new Cell(btn1);
            table[0, 1] = new Cell(btn2);
            table[0, 2] = new Cell(btn3);

            table[1, 0] = new Cell(btn4);
            table[1, 1] = new Cell(btn5);
            table[1, 2] = new Cell(btn6);

            table[2, 0] = new Cell(btn7);
            table[2, 1] = new Cell(btn8);
            table[2, 2] = new Cell(btn9);

        }

        public new void Show()
        {
            Application.Run(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset?.Invoke(sender,e);
        }
    }
}
