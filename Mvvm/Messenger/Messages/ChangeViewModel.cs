using Mvvm.ViewModels;

namespace Mvvm.Messenger.Messages;

public class ChangeViewModel : IMessage
{
    public ChangeViewModel(BaseViewModel viewModel)
    {
        ViewModel = viewModel;
    }
    
    public BaseViewModel ViewModel { get; }
}