using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVerficar_Click(object sender, EventArgs e)
        {
            //Verificar se os Textbox não estão vazios
            if (TxtbNome.Text == "" || TxtbSobrenome.Text == "" || TxtbAnoDeNasc.Text == "")
            {
                MessageBox.Show("Os campos de Nome,Sobrenome e Ano de nascimento não podem estar vazios",
                    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Converte o texto digitado no Textbox(TxtbAnoDeNasc) em um int(AnoDeNasc)
                if (int.TryParse(TxtbAnoDeNasc.Text, out int AnoDeNasc) && AnoDeNasc >= 1940)
                {

                    //calcula a idade do usuario subtraindo o ano atual pelo ano de nascimento da pessea 
                    int idade = DateTime.Now.Year - AnoDeNasc;
                    // verifica se a pessoa é ou não maior de idade 
                    if (idade >= 18)
                    {
                        // Trocar a imagem do picb resultado para "v" e mostrar a mensagem de bem-vindo ao usuario
                        PicbVerifacacao.Image = Properties.Resources.Okmatrix;
                        LblResultado.Text = $"Bem-vindo {TxtbNome.Text} {TxtbSobrenome.Text},\nvocê é maior de idade({idade}),\n" +
                        "está liberado para entrar \nna Matrix.";
                        LblResultado.ForeColor = Color.White;
                    }
                    else
                    {
                        PicbVerifacacao.Image = Properties.Resources.errormatrix;
                        LblResultado.Text = $"Você não está liberado\n para entrar no matrix";
                        LblResultado.ForeColor = Color.Red;
                    }
                }
                else
                {
                    //Mostra uma mensagem de erro caso a pessoa digite uma data irreal (Abaixo de 1940 ou acima do ano atual)
                    MessageBox.Show("Ano inválido.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os dados 
            TxtbNome.Clear();
            TxtbSobrenome.Clear();
            TxtbAnoDeNasc.Clear();
            PicbVerifacacao.Image = null;
            LblResultado.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Encerrar o programa
            Application.Exit();
        }
    }
}
