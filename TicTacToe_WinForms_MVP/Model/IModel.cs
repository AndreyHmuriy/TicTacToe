using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WinForms_MVP
{
    interface  IModel
    {
        void SetCellStatus(Controls.ICell cell);
        bool isGameOver(Controls.Table table);
        GameStatus Status { get; set; }
    }
}
