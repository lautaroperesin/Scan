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
        if (mensaje.Value == "AbrirManwhas")
        {
            await Navigation.PushAsync(new ManwhasView());
        }
        if (mensaje.Value == "AbrirPopulares")
        {
            await Navigation.PushAsync(new ManwhasPopularesView());
        }
        if (mensaje.Value == "AbrirSolicitud")
        {
            await Navigation.PushAsync(new SolicitudView());
        }
        if (mensaje.Value == "AgregarSolicitud")
        {
            await Navigation.PushAsync(new AddEditSolicitudView());
        }
        if (mensaje.Value == "EditarSolicitud")
        {
            await Navigation.PushAsync(new AddEditSolicitudView(mensaje.SolicitudAEditar));
        }

        if (mensaje.Value =="CerrarVentana")
        {
            await Navigation.PopAsync();
        }
        if (mensaje.Value == "AbrirAppShell")
        {
            await Navigation.PushAsync(new ScanShell());
        }
    }
}