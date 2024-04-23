using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Layouts;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        var button1 = new Button
        {
            Content = "Button1"
        };
        
        var button2 = new Button
        {
            Content = "Button2"
        };

        NamesListBox.Items.Add(button1);
        NamesListBox.Items.Add(button2);
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        MyTextBlock.Text = $"R{Random.Shared.Next(1000, 9999)}C{Random.Shared.Next(1000, 9999)}";
    }
}