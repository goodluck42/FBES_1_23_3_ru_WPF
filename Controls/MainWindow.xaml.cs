using System.Globalization;
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

namespace Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
    {
        if (e.Source is CheckBox checkBox)
        {
            MessageBox.Show($"CheckBox: {checkBox.IsChecked}");
        }

        if (e.Source is RadioButton radioButton)
        {
            MessageBox.Show($"RadioButton ({radioButton.Name}): {radioButton.IsChecked}");
        }
    }

    private void LangComboBox_OnSelected(object sender, RoutedEventArgs e)
    {
        if (sender is ComboBox comboBox)
        {
            if (LangIndex == null)
            {
                LangIndex = new Run();
            }

            if (LangName == null)
            {
                LangName = new Run();
            }
            
            LangIndex.Text = comboBox.SelectedIndex.ToString();
            LangName.Text = ((ComboBoxItem)(comboBox.SelectedItem)).Content.ToString();
        }
    }

    private void RangeBase_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        SliderValue.Text = e.NewValue.ToString(CultureInfo.CurrentCulture);
    }

    private int _counter = 0;
    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        CounterTextBlock.Text = (_counter++).ToString();
    }

    private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
    {
        MessageBox.Show(e.Key.ToString());
    }
}