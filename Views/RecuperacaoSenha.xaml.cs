using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrototipoTelas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecuperacaoSenha : ContentPage
    {
        public RecuperacaoSenha()
        {
            InitializeComponent();

          
        }
        public void Login(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "Clicou", "Não clicou");
        }
        public void GerarSenha(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "Clicou", "Não clicou");
        }
        public async void EsqueciSenha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}