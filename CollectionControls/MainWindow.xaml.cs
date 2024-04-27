using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
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

namespace CollectionControls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, INotifyPropertyChanged
{
    private Vehicle? _dataVehicle;
    private Vehicle? _newVehicle;

    public MainWindow()
    {
        InitializeComponent();
        
        DataContext = this;
        DataVehicle = new Vehicle
        {
            Id = 1,
            Model = "Wood",
            Name = "Quick Car"
        };
        
        NewVehicle = new();
    }

    public ObservableCollection<Vehicle> Vehicles { get; set; } = new();

    public Vehicle NewVehicle
    {
        get => _newVehicle;
        set
        {
            _newVehicle = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewVehicle)));
        }
    }

    public Vehicle? DataVehicle
    {
        get => _dataVehicle;
        set
        {
            _dataVehicle = value;
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DataVehicle)));
        }
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (DataVehicle == null)
        {
            return;
        }
        
        DataVehicle.Name = "Test";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void AddVehicle(object sender, RoutedEventArgs e)
    {
        Vehicles.Add(NewVehicle);

        NewVehicle = new();
    }
}