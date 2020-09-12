using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_WinForms_MVP.Controls;

namespace TicTacToe_WinForms_MVP
{
    enum GameStatus
    {
        Cross,
        Zero
    }

    sealed class Model : IModel
    {
        private ICell lastUsedCell = null;
        private GameStatus status = GameStatus.Cross;

        public GameStatus Status
        {
            get => status;
            set => status = value;
        }

        public bool isGameOver(Table table)
        {
            return (CheckHorizontalLines(table)||CheckVerticallLines(table)||CheckDiagonal(table));
        }

        private bool CheckDiagonal(Table table)
        {
            bool win = true;

            CellStatus cellStatus = table[0, 0].Status;
            if (cellStatus != CellStatus.Empty)
            {
                for (int i = 1; i < table.Rows; i++)
                {
                    if (cellStatus != table[i, i].Status)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }
            else
            {
                win = false;
            }
            if (win) return true;

            win = true;
            cellStatus = table[0, table.Columns - 1].Status;
            if (cellStatus != CellStatus.Empty)
            {
                for (int i = 1; i < table.Rows; i++)
                {
                    if (cellStatus != table[i, (table.Columns - 1) - i].Status)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }
            else
            {
                win = false;
            }
            return win;
        }
        private bool CheckVerticallLines(Table table)
        {
            bool win = true;
            for (int i = 0; i < table.Columns; i++)
            {
                win = true;
                CellStatus cellStatus = table[0, i].Status;

                if (cellStatus == CellStatus.Empty)
                {
                    win = false;
                    continue;
                }

                for (int j = 1; j < table.Rows; j++)
                {
                    if (cellStatus != table[j, i].Status)
                    {
                        win = false;
                        break;
                    }
                }

                if (win)
                {
                    return true;
                }
            }
            return win;
        }

        private bool CheckHorizontalLines(Table table)
        {
            bool win = true;
            for (int i = 0; i < table.Rows; i++)
            {
                win = true;
                CellStatus cellStatus = table[i, 0].Status;

                if (cellStatus == CellStatus.Empty)
                {
                    win = false;
                    continue;
                }

                for (int j = 1; j < table.Columns; j++)
                {
                    if (cellStatus != table[i, j].Status)
                    {
                        win = false;
                        break;
                    }
                }

                if (win)
                {
                    return true;
                }
            }
            return win;
        }

        public void SetCellStatus(ICell cell)
        {
            if(Status == GameStatus.Cross)
            {
                if(cell.Status == CellStatus.Empty)
                {
                    cell.Status = CellStatus.Cross;
                    Status = GameStatus.Zero;
                    lastUsedCell = cell;
                }
                else if( cell.Status == CellStatus.Zero
                    && cell == lastUsedCell)
                {
                    cell.Status = CellStatus.Empty;
                    Status = GameStatus.Zero;
                }               
                
            }
            else if (Status == GameStatus.Zero)
            {
                if(cell.Status == CellStatus.Empty)
                {
                    cell.Status = CellStatus.Zero;
                    Status = GameStatus.Cross;
                    lastUsedCell = cell;
                }
                else if (cell.Status == CellStatus.Cross
                    && cell == lastUsedCell)
                {
                    cell.Status = CellStatus.Empty;
                    Status = GameStatus.Cross;
                }                 
            }
        }
    }
}
