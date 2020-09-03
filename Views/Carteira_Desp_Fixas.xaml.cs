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
    public partial class Carteira_Desp_Fixas : ContentPage
    {
        public Carteira_Desp_Fixas()
        {
            InitializeComponent();
        }
        public void Adicionar(object sender, EventArgs e)
        {
            DisplayAlert("Controle", "Adicionado!", "OK");
        }
    }
}