using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WinForms_MVP
{
    class Presenter: IPresenter
    {
        private IView view;
        private IModel model;

        public Presenter(IView view, IModel model)
        {
            this.view = view;
            this.model = model;

            foreach(Controls.Cell cell in view.Table)
            {
                cell.Click += OnClick;
            }

            view.Reset += OnReset;
        }

        public void OnClick(object sender, EventArgs e)
        {
            model.SetCellStatus((Controls.ICell) sender);
            if(model.isGameOver(view.Table))
            {
                System.Windows.Forms.MessageBox.Show("Game Over");
                Reset();
            }
        }

        public void Run()
        {
            view.Show();
        }

        public void OnReset(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            view.Table.Reset();
            model.Status = GameStatus.Cross;
        }
    }
}
