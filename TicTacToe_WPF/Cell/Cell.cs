using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TicTacToe_WPF
{
    public enum CellStatus
    {
        Empty,
        Cross,
        Zero
    }

    public class Cell : INotifyPropertyChanged
    {
        private CellStatus status;
        public CellStatus Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
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
