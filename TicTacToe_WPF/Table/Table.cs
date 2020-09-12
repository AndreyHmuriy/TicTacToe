using System;
using System.Collections;

namespace TicTacToe_WPF.Controls
{
    public class Table : IEnumerable
    {
        readonly Cell[,] cells;
        readonly int rows, columns;

        public int Rows
        {
            get => rows;
        }

        public int Columns
        {
            get => columns;
        }

        public Table(int rows, int columns)
        {
            if (rows < 1) throw new ArgumentException("Количество строк не может быть меньше одного");
            if (columns < 1) throw new ArgumentException("Количество столбцов не может быть меньше одного");

            this.rows = rows;
            this.columns = columns;
            cells = new Cell[rows, columns];
        }

        public Cell this[int rowIndex, int columnIndex]
        {
            get
            {
                return cells[rowIndex, columnIndex];
            }
            set
            {
                cells[rowIndex, columnIndex] = value;
            }
        }

        public void Reset()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    cells[i, j].Status = CellStatus.Empty;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new CellEnumerator(cells);
        }
    }
}
