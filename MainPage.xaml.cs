using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototipoTelas.Views;
using Xamarin.Forms;

namespace PrototipoTelas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void Login(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "Clicou", "Não clicou");
        }
        public async void EsqueciSenha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecuperacaoSenha());
        }
        public void GerarSenha(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "Clicou", "Não clicou");
        }
        public void Adicionar(object sender, EventArgs e)
        {
            DisplayAlert("Controle", "Adicionado!", "OK");
        }
    }
}
