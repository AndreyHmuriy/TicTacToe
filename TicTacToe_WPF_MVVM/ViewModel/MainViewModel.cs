using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicTacToe_WPF_MVVM.Model;

namespace TicTacToe_WPF_MVVM.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public CellViewModel[,] Cells;
        private CellViewModel lastUsedCell;

        public CellViewModel Cell1 { get; set; }
        public CellViewModel Cell2 { get; set; }
        public CellViewModel Cell3 { get; set; }

        public CellViewModel Cell4 { get; set; }
        public CellViewModel Cell5 { get; set; }
        public CellViewModel Cell6 { get; set; }

        public CellViewModel Cell7 { get; set; }
        public CellViewModel Cell8 { get; set; }
        public CellViewModel Cell9 { get; set; }

        public GameStatus GameStatus { get; set; }

        private void InitializationCells()
        {
            Cell1 = new CellViewModel();
            Cell2 = new CellViewModel();
            Cell3 = new CellViewModel();

            Cell4 = new CellViewModel();
            Cell5 = new CellViewModel();
            Cell6 = new CellViewModel();

            Cell7 = new CellViewModel();
            Cell8 = new CellViewModel();
            Cell9 = new CellViewModel();

            Cells = new CellViewModel[,]
            {
                {
                    Cell1,
                    Cell2,
                    Cell3
                },
                {
                    Cell4,
                    Cell5,
                    Cell6
                },
                {
                    Cell7,
                    Cell8,
                    Cell9
                }
            };
        }

        public MainViewModel()
        {
            InitializationCells();      
        }

        #region Commands
        private readonly RelayCommand _changeStatus;
        public ICommand ChangeStatusCommand => _changeStatus ?? new RelayCommand(ChangeStatusCell);

        public void ChangeStatusCell(object parameter)
        {
            if (parameter.GetType() != typeof(CellViewModel)) 
                throw new ArgumentException("parameter");

            CellViewModel cell = parameter as CellViewModel;
            if (cell.Status == CellStatus.Empty)
            {
                SetStatusCell(cell);
                lastUsedCell = cell;

                if (IsGameOver(Cells))
                {
                    System.Windows.MessageBox.Show("Игра окончена");
                    ResetAllStatus();
                }
                else if (IsDraw(Cells))
                {
                    System.Windows.MessageBox.Show("Ничья");
                    ResetAllStatus();
                }
            }
            else
            {
                if (cell == lastUsedCell)
                {
                    cell.Status = CellStatus.Empty;
                    GameStatus = (GameStatus == GameStatus.Cross) ? GameStatus.Zero : GameStatus.Cross;
                }
            }
        }

        private readonly RelayCommand _resetAllStatus;
        public ICommand ResetAllStatusCommand => _resetAllStatus ?? new RelayCommand((x)=>ResetAllStatus());

        public void ResetAllStatus()
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Cells[i, j].Status = CellStatus.Empty;
                }
            }
            GameStatus = GameStatus.Cross;
        }
        #endregion

        private void SetStatusCell(CellViewModel cell)
        {
            switch (GameStatus)
            {
                case GameStatus.Cross:
                    if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Cross;
                    }
                    GameStatus = GameStatus.Zero;
                    break;
                case GameStatus.Zero:
                    if (cell.Status == CellStatus.Empty)
                    {
                        cell.Status = CellStatus.Zero;
                    }
                    GameStatus = GameStatus.Cross;
                    break;
            }
        }

        private bool IsDraw(CellViewModel[,] cells)
        {
            bool result = true;
            for (int i = 0; i < cells.GetLength(0); i++)
            {                
                for (int j = 0; j < cells.GetLength(0); j++)
                {
                    CellViewModel cell = cells[i, j];
                    if (cell.Status == CellStatus.Empty)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }

        private bool IsGameOver(CellViewModel[,] cells)
        {
            return (CheckHorizontalLines(cells) || CheckVerticallLines(cells) || CheckDiagonal(cells));
        }

        private bool CheckDiagonal(CellViewModel[,] cells)
        {
            bool win = true;

            CellStatus cellStatus = cells[0, 0].Status;
            if (cellStatus != CellStatus.Empty)
            {
                for (int i = 1; i < cells.GetLength(0); i++)
                {
                    if (cellStatus != cells[i, i].Status)
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
            cellStatus = cells[0, cells.GetLength(0) - 1].Status;
            if (cellStatus != CellStatus.Empty)
            {
                for (int i = 1; i < cells.GetLength(0); i++)
                {
                    if (cellStatus != cells[i, (cells.GetLength(0) - 1) - i].Status)
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

        private bool CheckVerticallLines(CellViewModel[,] cells)
        {
            bool win = true;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                win = true;
                CellStatus cellStatus = cells[0, i].Status;

                if (cellStatus == CellStatus.Empty)
                {
                    win = false;
                    continue;
                }

                for (int j = 1; j < cells.GetLength(0); j++)
                {
                    if (cellStatus != cells[j, i].Status)
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

        private bool CheckHorizontalLines(CellViewModel[,] cells)
        {
            bool win = true;
            for (int i = 0; i < cells.GetLength(0);i++)
            {
                win = true;
                CellStatus cellStatus = cells[i, 0].Status;

                if (cellStatus == CellStatus.Empty)
                {
                    win = false;
                    continue;
                }

                for (int j = 1; j < cells.GetLength(0); j++)
                {
                    if (cellStatus != cells[i, j].Status)
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
