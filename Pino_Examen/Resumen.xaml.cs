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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string total_pagar,string nombre)
        {
            InitializeComponent();
            txt_Usuario.Text = usuario;
            txt_Nombre.Text = nombre;
            txt_TotalPagar.Text = total_pagar;
        }
    }
}