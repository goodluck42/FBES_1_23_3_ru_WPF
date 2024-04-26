using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionControls;

public record Vehicle : INotifyPropertyChanged
{
    private string _name = null!;
    public int Id { get; set; }

    public string Name
    {
        get => _name;
        set => SetField(ref _name, value);
    }

    public string Model { get; set; }  = null!;
    
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}