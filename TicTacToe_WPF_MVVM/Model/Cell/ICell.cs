using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WPF_MVVM.Model
{
    interface ICell
    {
        CellStatus Status { get; set; }
    }
}
