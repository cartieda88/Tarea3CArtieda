using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Tarea2CArtieda
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }


        private async void btnAbrirVistaDos_clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "estudiante2020" && pass == "uisrael2020")
            {
                await Navigation.PushAsync(new Vista_Dos(user, pass));
            }
            else
                await DisplayAlert("Sistemas de Notas", "Usuario o Clave son incorrectos!!", "Cerrar");

        }

    }
}
