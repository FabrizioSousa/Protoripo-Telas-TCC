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
    public partial class Carteira_Renda : ContentPage
    {
        public Carteira_Renda()
        {
            InitializeComponent();
        }
        public void Renda(object sender, EventArgs e)
        {
            DisplayAlert("Teste", "Clicou", "Não clicou");
        }
        public void Adicionar(object sender, EventArgs e)
        {
            DisplayAlert("Controle", "Adicionado!", "OK");
        }
    }
}