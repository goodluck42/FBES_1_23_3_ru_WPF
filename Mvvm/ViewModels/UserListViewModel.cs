using System.Windows;
using Mvvm.Commands;
using Mvvm.Messenger;
using Mvvm.Messenger.Messages;

namespace Mvvm.ViewModels;

public class UserListViewModel : BaseViewModel
{

    private RelayCommand? _addCommand;
    public RelayCommand AddCommand
    {
        get
        {
            if (_addCommand == null)
            {
                _addCommand = new RelayCommand(param =>
                {
                    CoolMessenger.Instance.Send<ChangeViewModel>(this, new ChangeViewModel(new AddUserViewModel()));
                });
            }

            return _addCommand;
        }
    }

    private RelayCommand? _removeCommand;
    
    public RelayCommand RemoveCommand
    {
        get
        {
            if (_removeCommand == null)
            {
                _removeCommand = new RelayCommand(param =>
                {
                    MessageBox.Show("Helloy");
                });
            }

            return _removeCommand;
        }
    }
    
    private RelayCommand? _updateCommand;
    
    public RelayCommand UpdateCommand
    {
        get
        {
            if (_updateCommand == null)
            {
                _updateCommand = new RelayCommand(param =>
                {
                    MessageBox.Show("Nothing there");
                });
            }

            return _updateCommand;
        }
    }
}