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
    public partial class frm_gasolina : Form
    {
       
        public frm_gasolina()
        {
            InitializeComponent();
        }
        private void btn_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_etanol.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qtlitros.Text);
                    Globals.total = Globals.valor * Globals.etanol;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_diesel.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qtlitros.Text);
                    Globals.total = Globals.valor * Globals.diesel;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_aditiva.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qtlitros.Text);
                    Globals.total = Globals.valor * Globals.aditiva;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_alcool.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qtlitros.Text);
                    Globals.total = Globals.valor * Globals.alcool;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Form2 go = new Form2();
                go.Show();
            }
            catch
            {
                MessageBox.Show("Problema encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                }


        private void btn_etank_Click(object sender, EventArgs e)
        {
            lbl_qtlitros.Visible = false;
            txt_qtlitros.Visible = false;
            lbl_qttank.Visible = true;
            txt_qttank.Visible = true;
            btn_comprar.Visible = false;
            btn_pagar2.Visible = true;
        }

        private void btn_pagar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdb_etanol.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qttank.Text);
                    Globals.total = Globals.valor * Globals.etanol;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_diesel.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qttank.Text);
                    Globals.total = Globals.valor * Globals.diesel;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_aditiva.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qttank.Text);
                    Globals.total = Globals.valor * Globals.aditiva;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdb_alcool.Checked)
                {
                    Globals.valor = Convert.ToInt16(txt_qttank.Text);
                    Globals.total = Globals.valor * Globals.alcool;
                    MessageBox.Show("Total é: " + Globals.total.ToString("C"), "Valor da compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Form2 go = new Form2();
                go.Show();
            }
            catch {
                MessageBox.Show("Problema encontrado.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdb_etanol_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_etanol.Checked)
            {
                Globals.etanol = 2.00;
                lbl_valor.Text = Globals.etanol.ToString("C");
                lbl_valor.Visible = true;
                

            }
        }

        private void rdb_diesel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_diesel.Checked)
            {
                Globals.diesel = 2.10;
                lbl_valor.Text = Globals.diesel.ToString("C");
                lbl_valor.Visible = true;
            }
        }

        private void rdb_aditiva_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_aditiva.Checked)
            {
                Globals.aditiva = 2.60;
                lbl_valor.Text = Globals.aditiva.ToString("C");
                lbl_valor.Visible = true;
            }
        }

        private void rdb_alcool_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_alcool.Checked)
            {
                Globals.alcool = 3.00;
                lbl_valor.Text = Globals.alcool.ToString("C");
                lbl_valor.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_qttank_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_volt_Click(object sender, EventArgs e)
        {
            lbl_qtlitros.Visible = true;
            txt_qtlitros.Visible = true;
            lbl_qttank.Visible = false;
            txt_qttank.Visible = false;
            btn_comprar.Visible = true;
            btn_pagar2.Visible = false;
        }

        private void txt_qtlitros_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class Globals
    {
        public static double etanol, aditiva, diesel, alcool, valor, total, valorn;
    }
}
