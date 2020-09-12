using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TicTacToe_WPF_MVVM.ViewModel;

namespace TicTacToe_WPF_MVVM
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow view = new MainWindow();
            MainViewModel viewModel = new MainViewModel();
            view.DataContext = viewModel;
            view.Show();
        }

        //MainView view = new MainView(); // создали View
        //MainViewModel viewModel = new ViewModels.MainViewModel(books); // Создали ViewModel
        //view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
        //    view.Show();
    }
}
