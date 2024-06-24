using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using WS.Model;

namespace WS.Services
{
    public class ServiceDbDados
    {
        SQLiteConnection con;
        
        public string StatusMessage { get; set; }
        public ServiceDbDados(string dbPath)
        {
            if (dbPath == "")
                dbPath = App.dBpath;
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Dados>();
        }
        public void Inserir(Dados dados)
        {
            try
            {
                //if (string.IsNullOrEmpty(pressao.Sistole.ToString()))
                //    throw new Exception("Por Favor, Insira o valor para Sístole");
                //if (string.IsNullOrEmpty(pressao.Diastole.ToString()))
                //    throw new Exception("Por Favor, Insira o valor para Diástole");
                //int result = conn.Insert(pressao);
                //if (result != 0)
                //{
                //    this.StatusMessage = string.Format("Valores da Pressão Inseridos com Sucesso");
                //}
                //else
                //{
                //    this.StatusMessage = string.Format("Não foi possível Inserir os valores da Pressão");
                //}
                con.Insert(dados);
            }
            catch (Exception er)
            {
                throw new Exception(er.Message);
            }
        }

    }
}
