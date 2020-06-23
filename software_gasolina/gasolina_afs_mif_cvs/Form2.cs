using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasolina_afs_mif_cvs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            lbl_valor.Text = Globals.total.ToString("C");
            lbl_valor2.Text = Globals.total.ToString("C");
        }

        private void lbl_valor_Click(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lbl_valor.Text = Globals.total.ToString("C");
            lbl_valor2.Text = Globals.total.ToString("C");
        }
        double pagar, final, pagar1, final1; 

        private void btn_pagar_Click(object sender, EventArgs e)
        {
     
            double cartao_vld = Convert.ToDouble(txt_cartao.Text);
            // MessageBox.Show("eai:" + cartao_vld);


            if (cartao_vld <= 15 && cartao_vld >= 17)
            {
                MessageBox.Show("Problema encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cartão validado.", "Confirmado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    pagar = Convert.ToInt16(txt_valorpagar1.Text);
                    final = pagar - Globals.total;
                    MessageBox.Show("Nº do cartão:" + txt_cartao.Text + "\n\n\n Troco: " + final.ToString("C"));
                }
                catch
                {
                    MessageBox.Show("Problema encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limparDados();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    pagar1 = Convert.ToInt16(txt_valorpagar2.Text);
                    final1 = pagar1 - Globals.total;
                    MessageBox.Show("Nº da agencia:" + txt_agencia.Text + "\n Nº da conta: " + txt_conta.Text + "\n Nome do banco: " + txt_nomebanco.Text + " \n\n\n Troco: " + final1.ToString("C"), "Compra paga com sucesso!", MessageBoxButtons.OK);   
            }
            catch
            {
                MessageBox.Show("Problema encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limparDados();
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_gasolina musa = new frm_gasolina();
            musa.Show();
            this.Hide();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void txt_pagar_TextChanged(object sender, EventArgs e)
        {
        }

        string senha;
        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            senha = Convert.ToString(txt_senha);
            txt_senha.PasswordChar = '*';

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limparDados();
        }
        private void limparDados()
        {
            //FUNÇÃO PARA LIMPAR OS DADOS DIRETAMENTE
            txt_cartao.Clear();
            txt_nomebanco.Clear();
            txt_conta.Clear();
            txt_senha.Clear();
            txt_agencia.Clear();
            txt_valorpagar2.Clear();
            //formas tentadas para clear o textbox
            //txt_valorpagar1.ToString();
            //pagar = Convert.ToInt16(txt_valorpagar1.Text);
            txt_valorpagar1.Text = ""; //erro aqui, o clear não está apagando esse textbox
            // txt_valorpagar1.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_cartao.Visible = true;
            lbl_valor.Visible = true;
            grp_lele.Visible = true;
            lbl_mostrarvalor.Visible = true;
            lbl_ncartao.Visible = true;
            lbl_valorpagar1.Visible = true;
            btn_pagar.Visible = true;
            txt_valorpagar1.Visible = true;

            //ocultar o outro
            grp_pagamentocr.Visible = false;
            btn_pagar2.Visible = false;
            txt_agencia.Visible = false;
            txt_conta.Visible = false;
            txt_nomebanco.Visible = false;
            label10.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            txt_valorpagar2.Visible = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {

            grp_pagamentocr.Visible = true;
            btn_pagar2.Visible = true;
            txt_agencia.Visible = true;
            txt_cartao.Visible = true;
            txt_conta.Visible = true;
            txt_nomebanco.Visible = true;
            label10.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            txt_valorpagar2.Visible = true;


            //ocultar o outro
            txt_cartao.Visible = false;
            lbl_valor.Visible = false;
            grp_lele.Visible = false;
            lbl_mostrarvalor.Visible = false;
            lbl_ncartao.Visible = false;
            lbl_valorpagar1.Visible = false;
            btn_pagar.Visible = false;
        }
        private void btn_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crie um programa para um posto de gasolina do tipo “self-service” (você escolhe o seu combustível e paga no caixa). O usuário poderá escolher o combustível em um painel com radio buttons  onde constará o valor  a ser pago por litro conforme a escolha. Poderá ainda escolher quantos litros comprar e/ou encher o tanque (a bomba trava automaticamente). O pagamento poderá ser feito em dinheiro (calcula o troco), com cartão de crédito ou débito. O programa não deve travar em hipótese alguma e deve sempre apresentar uma mensagem amigável ao usuário caso haja alguma inconsistência dos dados. Para proteção do programa utilize tratamento de erros (try catch) nas caixas de texto que necessitam de dados específicos(ex: apenas números e / ou valores positivos).Se usar cartão de crédito deverá colocar 16 números para prosseguir o pagamento.Se for débito, colocar o nome do Banco, nº da agência e nº da conta.As senhas podem ser de 4 dígitos apenas para testes. Crie funções para efetuar os cálculos do programa e permitir o pagamento com base no conteúdo dos campos digitados. Apresentar o total abastecido em litros, valor a pagar e do troco caso tenha.Agradecer pela preferência e retornar com todos os campos vazios e caixas desmarcadas. \n\n\n Carlos Vinícius Souza Dos Santos\n Matheus Ileck Farias", "Sobre o software", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txt_cartao_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_nomebanco_TextChanged(object sender, EventArgs e)
        {
        }
        private void lbl_valor2_Click(object sender, EventArgs e)
        {
        }
    }
}
