using System;
using System.Collections;

namespace TicTacToe_WPF_MVVM.Model
{
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
