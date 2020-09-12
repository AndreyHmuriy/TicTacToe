using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Linq;
using MyTable = TicTacToe_WPF.Controls.Table;


namespace TicTacToe_WPF
{
    enum GameStatus
    {
        Cross,
        Zero
    }

    public partial class MainWindow : Window
    {
        private Cell lastUsedCell = null;
        MyTable table = new MyTable(3,3);
        GameStatus gameStatus;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTable();
            gameStatus = GameStatus.Cross;
        }

        private void InitializeTable()
        {
            btn1.DataContext = table[0, 0] = new Cell();
            btn2.DataContext = table[0, 1] = new Cell();
            btn3.DataContext = table[0, 2] = new Cell();

            btn4.DataContext = table[1, 0] = new Cell();
            btn5.DataContext = table[1, 1] = new Cell();
            btn6.DataContext = table[1, 2] = new Cell();

            btn7.DataContext = table[2, 0] = new Cell();
            btn8.DataContext = table[2, 1] = new Cell();
            btn9.DataContext = table[2, 2] = new Cell();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.DataContext.GetType() != typeof(Cell))
            {
                throw new ArgumentException("DataContext кнопки не является типом Cell");
            }

            Cell cell = button.DataContext as Cell;

            if (cell.Status == CellStatus.Empty)
            {
                SetStatusCell(cell);
                lastUsedCell = cell;

                if(IsGameOver(table))
                {
                    MessageBox.Show("Игра окончена");
                    Button_Reset(sender, e);
                }
                else if(IsDraw(table))
                {
                    MessageBox.Show("Ничья");
                    Button_Reset(sender, e);
                }
            }
            else
            {
                if(cell == lastUsedCell)
                {
                    cell.Status = CellStatus.Empty;
                    gameStatus = (gameStatus == GameStatus.Cross) ? GameStatus.Zero : GameStatus.Cross;
                }
            }
        }

        private void SetStatusCell(Cell cell)
        {
            switch (gameStatus)
            {
                case GameStatus.Cross:
                    if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Cross;
                    }
                    gameStatus = GameStatus.Zero;
                    break;
                case GameStatus.Zero:
                    if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Zero;
                    }
                    gameStatus = GameStatus.Cross;
                    break;
            }
        }

        private void Button_Reset(object sender, RoutedEventArgs e)
        {
            table.Reset();
            gameStatus = GameStatus.Cross;
            lastUsedCell = null;
        }

        private bool IsDraw(MyTable table)
        {
            bool result = true;
            foreach(Cell cell in table)
            {
                if(cell.Status == CellStatus.Empty)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool IsGameOver(MyTable table)
        {
            return (CheckHorizontalLines(table) || CheckVerticallLines(table) || CheckDiagonal(table));
        }

        private bool CheckDiagonal(MyTable table)
        {
            bool win = true;

            CellStatus cellStatus = table [0, 0].Status;
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
        private bool CheckVerticallLines(MyTable table)
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

        private bool CheckHorizontalLines(MyTable table)
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
    }
}
