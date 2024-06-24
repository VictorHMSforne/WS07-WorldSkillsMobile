using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WS.Model;
using WS.Services;

namespace WS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePesquisa3 : ContentPage
    {
        public PagePesquisa3()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Clicked(object sender, EventArgs e)
        {
            string dbPath = "";
            ServiceDbDados serviceDb = new ServiceDbDados(dbPath);
            Dados dados = new Dados();
            dados.FuncoesAnteriores = txtFunc.Text;
            dados.AcidentesTrabalho = txtAcidente.Text;
            if (rdAcidenteN.IsChecked == true)
            {
                txtAcidente.Text = "Não";
                dados.AcidentesTrabalho = txtAcidente.Text;
            }
            serviceDb.Inserir(dados);
            DisplayAlert("Obrigado por Finalizar Nossa Pesquisa", "Pesquisa", "OK");
            Navigation.PushAsync(new PagePrincipal());
        }
    }
}