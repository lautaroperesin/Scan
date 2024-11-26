using CommunityToolkit.Mvvm.Messaging;
using ScanApp.Class;
using ScanApp.ViewModels;

namespace ScanApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
        //BindingContext = new IniciarSesionViewModel();
        /////C�DIGO QUE para preparar la recepci�n de mensajes y la llamada al m�todo RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceibedMessage(mensaje);
        });
    }
    private async void OnReceibedMessage(Message mensaje)
    {
    }
}