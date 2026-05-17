namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // Alterado para public para garantir que o XAML tenha acesso total
    public async void ButtonSobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}