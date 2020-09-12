using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicTacToe_WPF_MVVM.Model;

namespace TicTacToe_WPF_MVVM.ViewModel
{
    class CellViewModel : ViewModelBase
    {
        private Model.Cell _cell;

        public CellViewModel()
        {
            _cell = new Model.Cell();
        }

        public CellViewModel(Model.Cell cell)
        {
            this._cell = cell;
        }

        public Model.CellStatus Status
        {
            get => _cell.CellStatus;
            set
            {
                _cell.CellStatus = value;
                OnPropertyChanged(nameof(Status));
            }
        }
    }
}
