using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prac_INE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int edad = Int32.Parse(txtEdad.Text);

            if (edad < 18)
            {
                Navigation.PushAsync(new Menor());
            } else
            {
                Navigation.PushAsync(new INE());
            }
        }
    }
}
