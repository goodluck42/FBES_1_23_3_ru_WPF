using Mvvm.ViewModels;
using Mvvm.Messenger.Messages;

namespace Mvvm.Messenger;

public interface IMessenger
{
    void Register<TMessage>(BaseViewModel sender, Action<BaseViewModel, IMessage> action)
        where TMessage : IMessage;

    void Send<TMessage>(BaseViewModel sender, IMessage message)
        where TMessage : IMessage;
}