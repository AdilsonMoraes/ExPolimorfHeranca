using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ex1_ClassAbstHeranca
{
    public partial class Form1 : Form
    {
        public class Pessoa
        {
            public int PessoaID { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Endereco { get; set; }
            public int Numero { get; set; }
            public string CEP { get; set; }
            public string UF { get; set; }

        }

        public abstract class SalvarPessoa : Pessoa
        {
            public abstract void RecuperarPessoa();

            public static  List<Pessoa> SalvaDados()
            {
                var RecuperarPessoa = new List<Pessoa>();
                return RecuperarPessoa;
            }
        }

        public class ConsultarPessoa : SalvarPessoa
        {
            public override void RecuperarPessoa()
            {
                PessoaID = 1;
                Nome = "Joao";
                Telefone = "(047) 98765-4321";
                Endereco = "Rua teste";
                Numero = 10;
                CEP = "05846-645";
                UF = "SC";
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarPessoa pessoa = new ConsultarPessoa();
            var Dados = "";
            pessoa.RecuperarPessoa();
            Dados = pessoa.PessoaID + " - "
                +  pessoa.Nome + "\r\n" 
                + pessoa.Telefone + "\r\n"
                + pessoa.Endereco + ","
                + pessoa.Numero + "\r\n"
                + pessoa.CEP + " - "
                + pessoa.UF;
            label1.Text = Dados;
        }



        public Form1()
        {
            InitializeComponent();
        }
    }
}
