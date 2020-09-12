using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_WinForms_MVP.Controls
{
    public enum CellStatus
    {
        Empty,
        Cross,
        Zero
    }

    public class Cell : ICell
    {
        readonly Button button = null;
        public event EventHandler Click;

        const string CROSS = "X";
        const string ZERO = "O";
        const string EMPTY = "";

        public Cell(Button button)
        {
            this.button = button;

            button.Click += Button_Click;
            Click += Cell_Click;
        }

        public CellStatus Status
        {
            get => GetStatus();
            set => SetStatus(value);
        }

        /// <summary>
        /// Установить статус Cell
        /// </summary>
        /// <param name="newStatus">Новый статус</param>
        private void SetStatus(CellStatus newStatus)
        {
            switch (newStatus)
            {
                case CellStatus.Empty:
                    button.Text = EMPTY;
                    break;
                case CellStatus.Cross:
                    button.Text = CROSS;
                    break;
                case CellStatus.Zero:
                    button.Text = ZERO;
                    break;
            }
        }

        /// <summary>
        /// Получить статус Cell 
        /// </summary>
        /// <returns>Статус Button</returns>
        private CellStatus GetStatus()
        {
            switch (button.Text)
            {
                case CROSS:
                    return CellStatus.Cross;
                case ZERO:
                    return CellStatus.Zero;
                case EMPTY:
                    return CellStatus.Empty;
            }
            return CellStatus.Empty;
        }

        public override string ToString()
        {
            return button.Name;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Click?.Invoke(this, e);
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class CellEnumerator : IEnumerator
    {
        Cell[,] cells;
        int position = -1;

        public CellEnumerator(Cell[,] cells)
        {
            this.cells = cells;
        }

        public bool MoveNext()
        {
            position++;
            return (position < cells.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get => Current;
        }

        public Cell Current
        {
            get
            {
                try
                {
                    return cells[position / cells.GetLength(0), position % cells.GetLength(0)];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
