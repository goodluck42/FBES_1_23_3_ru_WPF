using Mvvm.Commands;
using Mvvm.Messenger;
using Mvvm.Messenger.Messages;

namespace Mvvm.ViewModels;

public class AddUserViewModel : BaseViewModel
{
    private RelayCommand? _backCommand;
    
    public RelayCommand BackCommand
    {
        get
        {
            if (_backCommand == null)
            {
                _backCommand = new RelayCommand(param =>
                {
                    CoolMessenger.Instance.Send<ChangeViewModel>(this,
                        new ChangeViewModel(new UserListViewModel()));
                });
            }

            return _backCommand;
        }
    }
}