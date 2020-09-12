using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WinForms_MVP.Controls
{
    interface ICell
    {
        CellStatus Status { get; set; }
        event EventHandler Click;
    }
}
