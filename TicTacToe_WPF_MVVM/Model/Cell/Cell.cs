using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TicTacToe_WPF_MVVM.Model
{
    public class Cell
    {
        public CellStatus CellStatus { get; set; }

        public Cell()
        {
            CellStatus = CellStatus.Empty;
        }
    }

    //public class Cell : INotifyPropertyChanged
    //{
    //    private CellStatus status;
    //    public CellStatus Status
    //    {
    //        get => status;
    //        set
    //        {
    //            status = value;
    //            OnPropertyChanged(nameof(Status));
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;
    //    public void OnPropertyChanged(string prop)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    //    }
    //}
}
