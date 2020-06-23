namespace gasolina_afs_mif_cvs
{
    partial class frm_gasolina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gasolina));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_aditiva = new System.Windows.Forms.RadioButton();
            this.rdb_diesel = new System.Windows.Forms.RadioButton();
            this.rdb_alcool = new System.Windows.Forms.RadioButton();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.rdb_etanol = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_qtlitros = new System.Windows.Forms.TextBox();
            this.btn_etank = new System.Windows.Forms.Button();
            this.lbl_qtlitros = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.lbl_qttank = new System.Windows.Forms.Label();
            this.txt_qttank = new System.Windows.Forms.TextBox();
            this.btn_pagar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_volt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_aditiva);
            this.groupBox1.Controls.Add(this.rdb_diesel);
            this.groupBox1.Controls.Add(this.rdb_alcool);
            this.groupBox1.Controls.Add(this.lbl_valor);
            this.groupBox1.Controls.Add(this.rdb_etanol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Gasolina";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_aditiva
            // 
            this.rdb_aditiva.AutoSize = true;
            this.rdb_aditiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_aditiva.Location = new System.Drawing.Point(188, 31);
            this.rdb_aditiva.Name = "rdb_aditiva";
            this.rdb_aditiva.Size = new System.Drawing.Size(60, 19);
            this.rdb_aditiva.TabIndex = 3;
            this.rdb_aditiva.TabStop = true;
            this.rdb_aditiva.Text = "Aditiva";
            this.rdb_aditiva.UseVisualStyleBackColor = true;
            this.rdb_aditiva.CheckedChanged += new System.EventHandler(this.rdb_aditiva_CheckedChanged);
            // 
            // rdb_diesel
            // 
            this.rdb_diesel.AutoSize = true;
            this.rdb_diesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_diesel.Location = new System.Drawing.Point(97, 31);
            this.rdb_diesel.Name = "rdb_diesel";
            this.rdb_diesel.Size = new System.Drawing.Size(60, 19);
            this.rdb_diesel.TabIndex = 2;
            this.rdb_diesel.TabStop = true;
            this.rdb_diesel.Text = "Diesel";
            this.rdb_diesel.UseVisualStyleBackColor = true;
            this.rdb_diesel.CheckedChanged += new System.EventHandler(this.rdb_diesel_CheckedChanged);
            // 
            // rdb_alcool
            // 
            this.rdb_alcool.AutoSize = true;
            this.rdb_alcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_alcool.Location = new System.Drawing.Point(279, 31);
            this.rdb_alcool.Name = "rdb_alcool";
            this.rdb_alcool.Size = new System.Drawing.Size(58, 19);
            this.rdb_alcool.TabIndex = 1;
            this.rdb_alcool.TabStop = true;
            this.rdb_alcool.Text = "Álcool";
            this.rdb_alcool.UseVisualStyleBackColor = true;
            this.rdb_alcool.CheckedChanged += new System.EventHandler(this.rdb_alcool_CheckedChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.Green;
            this.lbl_valor.Location = new System.Drawing.Point(200, 79);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(60, 18);
            this.lbl_valor.TabIndex = 7;
            this.lbl_valor.Text = "testeste";
            this.lbl_valor.Visible = false;
            // 
            // rdb_etanol
            // 
            this.rdb_etanol.AutoSize = true;
            this.rdb_etanol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_etanol.Location = new System.Drawing.Point(6, 31);
            this.rdb_etanol.Name = "rdb_etanol";
            this.rdb_etanol.Size = new System.Drawing.Size(60, 19);
            this.rdb_etanol.TabIndex = 0;
            this.rdb_etanol.TabStop = true;
            this.rdb_etanol.Text = "Etanol";
            this.rdb_etanol.UseVisualStyleBackColor = true;
            this.rdb_etanol.CheckedChanged += new System.EventHandler(this.rdb_etanol_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor da gasolina por litro:";
            // 
            // txt_qtlitros
            // 
            this.txt_qtlitros.Location = new System.Drawing.Point(215, 148);
            this.txt_qtlitros.Name = "txt_qtlitros";
            this.txt_qtlitros.Size = new System.Drawing.Size(100, 20);
            this.txt_qtlitros.TabIndex = 2;
            this.txt_qtlitros.TextChanged += new System.EventHandler(this.txt_qtlitros_TextChanged);
            // 
            // btn_etank
            // 
            this.btn_etank.Location = new System.Drawing.Point(142, 197);
            this.btn_etank.Name = "btn_etank";
            this.btn_etank.Size = new System.Drawing.Size(166, 23);
            this.btn_etank.TabIndex = 3;
            this.btn_etank.Text = "Encher o Tanque";
            this.btn_etank.UseVisualStyleBackColor = true;
            this.btn_etank.Click += new System.EventHandler(this.btn_etank_Click);
            // 
            // lbl_qtlitros
            // 
            this.lbl_qtlitros.AutoSize = true;
            this.lbl_qtlitros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtlitros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_qtlitros.Location = new System.Drawing.Point(22, 149);
            this.lbl_qtlitros.Name = "lbl_qtlitros";
            this.lbl_qtlitros.Size = new System.Drawing.Size(147, 17);
            this.lbl_qtlitros.TabIndex = 4;
            this.lbl_qtlitros.Text = "Quantidade por litros:";
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(373, 146);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(94, 23);
            this.btn_comprar.TabIndex = 6;
            this.btn_comprar.Text = "Confirmar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // lbl_qttank
            // 
            this.lbl_qttank.AutoSize = true;
            this.lbl_qttank.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qttank.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_qttank.Location = new System.Drawing.Point(3, 22);
            this.lbl_qttank.Name = "lbl_qttank";
            this.lbl_qttank.Size = new System.Drawing.Size(227, 17);
            this.lbl_qttank.TabIndex = 8;
            this.lbl_qttank.Text = "Quantidade disponível no tanque: ";
            this.lbl_qttank.Visible = false;
            // 
            // txt_qttank
            // 
            this.txt_qttank.Location = new System.Drawing.Point(237, 19);
            this.txt_qttank.Name = "txt_qttank";
            this.txt_qttank.Size = new System.Drawing.Size(100, 20);
            this.txt_qttank.TabIndex = 9;
            this.txt_qttank.Visible = false;
            this.txt_qttank.TextChanged += new System.EventHandler(this.txt_qttank_TextChanged);
            // 
            // btn_pagar2
            // 
            this.btn_pagar2.Location = new System.Drawing.Point(366, 18);
            this.btn_pagar2.Name = "btn_pagar2";
            this.btn_pagar2.Size = new System.Drawing.Size(89, 23);
            this.btn_pagar2.TabIndex = 10;
            this.btn_pagar2.Text = "Confirmar";
            this.btn_pagar2.UseVisualStyleBackColor = true;
            this.btn_pagar2.Visible = false;
            this.btn_pagar2.Click += new System.EventHandler(this.btn_pagar2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_qttank);
            this.panel1.Controls.Add(this.btn_pagar2);
            this.panel1.Controls.Add(this.txt_qttank);
            this.panel1.Location = new System.Drawing.Point(12, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 66);
            this.panel1.TabIndex = 11;
            // 
            // btn_volt
            // 
            this.btn_volt.Location = new System.Drawing.Point(399, 197);
            this.btn_volt.Name = "btn_volt";
            this.btn_volt.Size = new System.Drawing.Size(71, 23);
            this.btn_volt.TabIndex = 11;
            this.btn_volt.Text = "Não encher";
            this.btn_volt.UseVisualStyleBackColor = true;
            this.btn_volt.Click += new System.EventHandler(this.btn_volt_Click);
            // 
            // frm_gasolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(479, 321);
            this.Controls.Add(this.btn_volt);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.txt_qtlitros);
            this.Controls.Add(this.lbl_qtlitros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_etank);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_gasolina";
            this.Text = "Posto de Gasolina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_aditiva;
        private System.Windows.Forms.RadioButton rdb_diesel;
        private System.Windows.Forms.RadioButton rdb_alcool;
        private System.Windows.Forms.RadioButton rdb_etanol;
        private System.Windows.Forms.TextBox txt_qtlitros;
        private System.Windows.Forms.Button btn_etank;
        private System.Windows.Forms.Label lbl_qtlitros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_qttank;
        private System.Windows.Forms.TextBox txt_qttank;
        private System.Windows.Forms.Button btn_pagar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_volt;
    }
}

