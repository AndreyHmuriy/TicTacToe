using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_WinForms
{
    class Cell : ICell
    {
        const string Cross = "X";
        const string Zero = "O";
        const string Empty = "";

        private Button button = null;


        public Button Button {
            get => button;
            private set => button = value;
        }

        public Cell(Button button)
        {
            Button = button ?? throw new ArgumentNullException("Button = null");
        }

        public CellStatus Status
        {
            get
            {
                return GetStatus(button);
            }
            set
            {
                SetStatus(button, value);
            }
        }

        public static CellStatus GetStatus(Button button)
        {
            if(button.Text == Cross)
            {
                return CellStatus.Cross;
            }
            else if (button.Text == Zero)
            {
                return CellStatus.Zero;
            }
            else
            {
                return CellStatus.Empty;
            }
        }

        public static void SetStatus(Button button, CellStatus cellStatus)
        {
            switch(cellStatus)
            {
                case CellStatus.Cross:
                    button.Text = Cross;
                    break;
                case CellStatus.Zero:
                    button.Text = Zero;
                    break;
                case CellStatus.Empty:
                    button.Text = Empty;
                    break;
            }
        }
    }
}
