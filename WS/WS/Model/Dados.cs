using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WS.Model
{
    [Table("Dados")]
    public class Dados
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id { get; set; }
        public string ClinicoOcupa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string DoencasInfec { get; set; }
        public string Alergias { get; set; }
        public string Cirurgias { get; set; }
        public string TransfuSangue { get; set; }
        public string MedicamentoContinuo { get; set; }
        public string Outros { get; set; }

        ///
        public string FuncoesAnteriores { get; set; }
        public string AcidentesTrabalho { get; set; }

        public Dados()
        {
            this.Id = 0;
            this.ClinicoOcupa = "";
            this.DoencasInfec = "";
            this.Alergias = "";
            this.Cirurgias = "";
            this.TransfuSangue = "";
            this.MedicamentoContinuo = "";
            this.Outros = "";
            this.FuncoesAnteriores = "";
            this.AcidentesTrabalho = "";
        }
    }
}
