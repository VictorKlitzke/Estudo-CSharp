using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Mais(object sender, EventArgs e)
        {
            quantidade++;
            LBQauntidade.Text = quantidade.ToString();  
        }
        private void Button_Menos(object sender, EventArgs e)
        {
            if (quantidade != 0) {
                quantidade--;
                LBQauntidade.Text = quantidade.ToString();
            }else
            {
                DisplayAlert("ERRO", "Valores a menos não são aceitos!", "OK");
            }

        }
    }
}
