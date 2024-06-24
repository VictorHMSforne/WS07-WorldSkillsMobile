using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Model;
using WS.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePesquisa2 : ContentPage
    {
        public PagePesquisa2()
        {
            InitializeComponent();
        }
        void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void btnContinuar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string dbPath = "";
                ServiceDbDados serviceDb = new ServiceDbDados(dbPath);
                Dados dados = new Dados();
                dados.DoencasInfec = txtDoen.Text;
                dados.Alergias = txtAler.Text;
                dados.Cirurgias = txtCirur.Text;
                dados.TransfuSangue = txtTrans.Text;
                dados.MedicamentoContinuo = txtMedi.Text;
                dados.Outros = txtOutros.Text;
                if (rdDoenN.IsChecked == true)
                {
                     txtDoen.Text = "Não";
                    dados.DoencasInfec = txtDoen.Text;
                }
                if (rdAlerN.IsChecked == true)
                {
                    txtAler.Text = "Não";
                    dados.Alergias = txtAler.Text;
                }
                if (rdCirurN.IsChecked == true)
                {
                    txtCirur.Text = "Não";
                    dados.Cirurgias = txtCirur.Text;
                }
                if (rdTransN.IsChecked == true)
                {
                    txtTrans.Text = "Não";
                    dados.TransfuSangue = txtTrans.Text;
                }
                if (rdMediN.IsChecked == true)
                {
                    txtMedi.Text = "Não";
                    dados.MedicamentoContinuo = txtMedi.Text;
                }
                serviceDb.Inserir(dados);
                Navigation.PushAsync(new PagePesquisa3());

            }
            catch (Exception er)
            {
                DisplayAlert(er.Message, "Erro", "Ok");
            }
        }
    }
}