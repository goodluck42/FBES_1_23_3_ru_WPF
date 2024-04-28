using System.Configuration;
using System.Data;
using System.Windows;
using Mvvm.ViewModels;
using Mvvm.Views;

namespace Mvvm;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        var view = new MainView
        {
            DataContext = new MainViewModel()
        };

        view.ShowDialog();
        
        base.OnStartup(e);
    }
}