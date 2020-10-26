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
        int suma1;
        int suma2;
        int suma3;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSumar_clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtDato1.Text);
                double dato2 = Convert.ToDouble(txtDato2.Text);

                double s1 = dato1 * (0.30);
                double e1 = dato2 * (0.20);
                double suma = s1 + e1;
                txtResultado.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "Aceptar");
            }
        }

        private void btnSumar2_clicked(object sender, EventArgs e)
        {
            try
            {
                double dato3 = Convert.ToDouble(txtDato3.Text);
                double dato4 = Convert.ToDouble(txtDato4.Text);

                double s2 = dato3 * (0.30);
                double e2 = dato4 * (0.20);
                double suma2 = s2 + e2;
                txtResultado2.Text = suma2.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "Aceptar");
            }
        }

        private void btnSumar3_clicked(object sender, EventArgs e)
        {
           
                double suma1 = Convert.ToDouble(txtResultado.Text);
                double suma2 = Convert.ToDouble(txtResultado2.Text);

                double f1 = suma1;
                double f2 = suma2;
                double suma3 = f1 + f2;
                txtResultado3.Text = suma3.ToString();

            if (suma3 > 7)
            {
                DisplayAlert("Estado del Estudiante","Aprobado..!", "Guardar");
            } 
            else  DisplayAlert("Estado del Estudiante", "Reprobado..!", "Guardar");
        }

    }
}
