namespace repasoSemana4.Views;

public partial class vRepaso : ContentPage
{
    public vRepaso()
    {
        InitializeComponent();
        txtNombre.Text = "Daniel";
        txtNivel.Text = "Octavo";
        txtCarrera.Text = "Sistemas";

	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new vReporte(txtNombre.Text, txtCarrera.Text, txtNivel.Text, txtUsuario.Text));
        }
        catch (Exception)
        {

            
        }
    }

    private void btnRegistrarse_Clicked(object sender, EventArgs e)
    {

    }
}