using System.ComponentModel;
using System.Runtime.CompilerServices;
using Mvvm.Messenger;
using Mvvm.Messenger.Messages;

namespace Mvvm.ViewModels;

public class MainViewModel : BaseViewModel, INotifyPropertyChanged
{
    public MainViewModel()
    {
        _viewModel = new UserListViewModel();

        CoolMessenger.Instance.Register<ChangeViewModel>(this, (sender, message) =>
        {
            if (message is ChangeViewModel changeViewModel)
            {
                ViewModel = changeViewModel.ViewModel;
            }
        });
    }
    
    private BaseViewModel _viewModel;

    public BaseViewModel ViewModel
    {
        get => _viewModel;
        set => SetField(ref _viewModel, value);
    }

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