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
    public partial class Registro : ContentPage
    {
        private string usr = null;
        private double total_pagar;
        public Registro(string usuario)
        {
            InitializeComponent();
            usr = usuario;
            txt_usr.Text = usr;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double pagar = 1800;
                double pago_mensual = Convert.ToDouble(txt_monto.Text);
                double cuota =0;
                double cuota3 = 0;
                if(pago_mensual>0 && pago_mensual < 1800)
                {
                    cuota = pagar - pago_mensual;
                    cuota3 = (cuota / 3)+(pagar*0.05);
                    total_pagar = (cuota3 * 3) + pagar;
                    txt_mensual.Text = Convert.ToString(cuota3);
                }
                else
                {
                    DisplayAlert("Error", "Los valores no son correctos", "OK");
                }

            }catch(Exception ex)
            {
               DisplayAlert("Error", ex.Message, "OK");
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string nombre= txt_Nombre.Text;
                string stotalPagar = Convert.ToString(total_pagar);
                if(nombre == null || nombre == "" && stotalPagar==null || stotalPagar == "0")
                {
                    await DisplayAlert("Error", "Primero tienes que Colocar el nombre y calcular","OK");
                }
                else
                {
                    await DisplayAlert("Correcto", "“Elemento guardado con exito", "OK");
                    await Navigation.PushAsync(new Resumen(usr,stotalPagar,nombre));
                }
            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}