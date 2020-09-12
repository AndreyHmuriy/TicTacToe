using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WPF.Controls
{
    interface ICell
    {
        TicTacToe_WPF.CellStatus Status { get; set; }
        //event EventHandler Click;
    }
}
