using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prac_INE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int edad = Int32.Parse(txtEdad.Text);

            if (edad < 18)
            {
                Navigation.PushAsync(new Menor());
            }
            else
            {
                Navigation.PushAsync(new INE());
            }
        }
    }
}