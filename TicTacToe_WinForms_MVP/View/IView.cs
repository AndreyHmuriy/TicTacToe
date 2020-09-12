using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe_WinForms_MVP.Controls;

namespace TicTacToe_WinForms_MVP
{
    interface IView
    {
        event EventHandler<EventArgs> Reset;
        Table Table { get; }
        void Show();
        void Close();
    }
}
