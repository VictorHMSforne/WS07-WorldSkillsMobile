using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Model;
using WS.Services;
using WS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.AppleSignInAuthenticator;

namespace WS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class PagePrincipal : ContentPage
    {
        string escolha;
        public PagePrincipal()
        {
            InitializeComponent();
            rdAdimissional.CheckedChanged += RadioButton_CheckedChanged;
            rdPeriodico.CheckedChanged += RadioButton_CheckedChanged;
            rdMudanca.CheckedChanged += RadioButton_CheckedChanged;
            rdRetorno.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string dbPath = "";
                ServiceDbDados serviceDb = new ServiceDbDados(dbPath);
                Dados dados = new Dados();
                dados.Nome = txtNome.Text;
                dados.CPF = txtCPF.Text;
                dados.Endereco = txtEndereco.Text;
                dados.Cidade = txtCidade.Text;
                dados.ClinicoOcupa = escolha;
                serviceDb.Inserir(dados);
                Navigation.PushAsync(new PagePesquisa2());
            }
            catch (Exception er)
            {
                DisplayAlert(er.Message, "Erro", "Ok");
            }
            
        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {

        }

        void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            if (e.Value) 
            {
                RadioButton selectedRadioButton = (RadioButton)sender;

                if (selectedRadioButton == rdAdimissional)
                {
                    rdPeriodico.IsChecked = false;
                    rdMudanca.IsChecked = false;
                    rdRetorno.IsChecked = false;

                }
                else if (selectedRadioButton == rdMudanca)
                {
                    rdPeriodico.IsChecked = false;
                    rdAdimissional.IsChecked = false;
                    rdRetorno.IsChecked = false;
                }
                else if (selectedRadioButton == rdPeriodico)
                {
                    rdMudanca.IsChecked = false;
                    rdRetorno.IsChecked = false;
                    rdAdimissional.IsChecked = false;
                }
                else if (selectedRadioButton == rdRetorno)
                {
                    rdMudanca.IsChecked = false;
                    rdAdimissional.IsChecked = false;
                    rdPeriodico.IsChecked = false;
                }

                escolha = selectedRadioButton.Content.ToString();

            }
        }
    }
}