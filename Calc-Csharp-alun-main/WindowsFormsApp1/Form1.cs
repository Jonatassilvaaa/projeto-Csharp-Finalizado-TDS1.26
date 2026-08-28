using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public decimal Valor { get; set; }

        public decimal Resultado { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void btn_um_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void btn_dois_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void btn_quatro_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void btn_sete_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void btn_oito_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void btn_nove_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txt_resultado.Text);
            txt_resultado.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            decimal segundoValor = Convert.ToDecimal(txt_resultado.Text);

            if (OperacaoSelecionada == Operacao.Adicao)
            {
                Resultado = Valor + segundoValor;
            }
            else if (OperacaoSelecionada == Operacao.Subtracao)
            {
                Resultado = Valor - segundoValor;
            }
            else if (OperacaoSelecionada == Operacao.Multiplicacao)
            {
                Resultado = Valor * segundoValor;
            }
            else if (OperacaoSelecionada == Operacao.Divisao)
            {
                Resultado = Valor / segundoValor;
            }

            txt_resultado.Text = Convert.ToString(Resultado);
        }
    }
}
