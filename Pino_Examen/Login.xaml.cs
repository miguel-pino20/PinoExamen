using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pino_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btn_Ingresar_Clicked(object sender, EventArgs e)
        {
            try { 
            string usr = txt_Usuario.Text;
            string clv = txt_Clave.Text;
            if (usr.Equals("estudiante2021")&& clv.Equals("uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(usr));
            }
            else
            {
                await  DisplayAlert("Error", "Datos incorrectos", "OK");
            }
            }catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}