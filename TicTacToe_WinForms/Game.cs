using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_WinForms
{
    class Game
    {
        private Cell[,] cells = null;
        private GameStatus gameStatus = GameStatus.Reset;
        private Button lastButton = null;

        public Game(Cell[,] cells)
        {
            this.cells = cells;
            gameStatus = GameStatus.Reset;

            foreach (Cell item in cells)
            {
                item.Button.Click += CellAction;
                item.Button.Tag = item;
            }
        }

        public void Reset()
        {
            gameStatus = GameStatus.Reset;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    cells[i, j].Status = CellStatus.Empty;
                }
            }
            gameStatus = GameStatus.Cross;
        }

        public void CellAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Cell cell = (Cell)button.Tag;
            if(cell.Button == lastButton
                && cell.Status !=CellStatus.Empty)
            {
                switch (gameStatus)
                {
                    case GameStatus.Cross:
                        if (cell.Status == CellStatus.Zero)
                        {
                            gameStatus = GameStatus.Zero;
                        }
                        break;
                    case GameStatus.Zero:
                        if (cell.Status == CellStatus.Cross)
                        {
                            gameStatus = GameStatus.Cross;
                        }
                        break;
                }
                cell.Status = CellStatus.Empty;
            }
            else
            {
                if (gameStatus == GameStatus.Cross)
                {
                    if (cell.Status == CellStatus.Cross
                        && cell.Button == lastButton)
                    {
                        cell.Status = CellStatus.Empty;
                    }
                    else if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Cross;
                        gameStatus = GameStatus.Zero;
                        lastButton = cell.Button;
                    }
                }
                else if (gameStatus == GameStatus.Zero)
                {
                    if (cell.Status == CellStatus.Zero
                        && cell.Button == lastButton)
                    {
                        cell.Status =  CellStatus.Empty;
                    }
                    else if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Zero;
                        gameStatus = GameStatus.Cross;
                        lastButton = cell.Button;
                    }
                }

                if (Check())
                {
                    MessageBox.Show("Игра окончена");
                    Reset();
                }
            }
        }

        private bool Check()
        {
            return CheckAllLines(CellStatus.Cross) || CheckAllLines(CellStatus.Zero);
        }

        private bool CheckAllLines(CellStatus status)
        {
            for(int i = 0;i<3;i++)
            {
                if(CheckHorizontalLine(i, status))
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (CheckVerticalLine(i, status))
                {
                    return true;
                }
            }

            if (CheckDiagonal(status))
            {
                return true;
            }

            return false;
        }

        private bool CheckHorizontalLine(int line, CellStatus status)
        {
            bool win = true;
            for(int i =0; i<3;i++)
            {
                if(cells[line,i].Status!=status)
                {
                    win = false;
                    break;
                }
            }
            return win;
        }

        private bool CheckVerticalLine(int line, CellStatus status)
        {
            bool win = true;
            for (int i = 0; i < 3; i++)
            {
                if (cells[i, line].Status != status)
                {
                    win = false;
                    break;
                }
            }
            return win;
        }

        private bool CheckDiagonal(CellStatus status)
        {
            bool win = true;
            for(int i =0;i<3;i++)
            {
                if (cells[i, i].Status != status)
                {
                    win = false;
                    break;
                }
            }

            if (win) return true;

            win = true;
            for (int i = 0; i < 3; i++)
            {
                if (cells[2-i, i].Status != status)
                {
                    win = false;
                    break;
                }
            }
            return win;
        }
    }
}
