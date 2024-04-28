using Mvvm.ViewModels;
using Mvvm.Messenger.Messages;

namespace Mvvm.Messenger;

public class CoolMessenger : IMessenger
{
    private Dictionary<Type, Action<BaseViewModel, IMessage>> _registrations;

    public CoolMessenger()
    {
        _registrations = new();
    }

    public void Register<TMessage>(BaseViewModel sender, Action<BaseViewModel, IMessage> action)
        where TMessage : IMessage
    {
        var type = typeof(TMessage);

        _registrations.TryAdd(type, action);
    }

    public void Send<TMessage>(BaseViewModel sender, IMessage message)
        where TMessage : IMessage
    {
        var type = typeof(TMessage);

        if (_registrations.ContainsKey(type))
        {
            _registrations[type](sender, message);
        }
    }

    public static IMessenger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CoolMessenger();
            }

            return _instance;
        }
    }

    private static IMessenger? _instance;
}