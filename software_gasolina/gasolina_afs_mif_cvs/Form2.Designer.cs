namespace gasolina_afs_mif_cvs
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_ncartao = new System.Windows.Forms.Label();
            this.grp_lele = new System.Windows.Forms.GroupBox();
            this.txt_valorpagar1 = new System.Windows.Forms.TextBox();
            this.lbl_valorpagar1 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_mostrarvalor = new System.Windows.Forms.Label();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.grp_pagamentocr = new System.Windows.Forms.GroupBox();
            this.txt_valorpagar2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nomebanco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pagar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_pagarc = new System.Windows.Forms.Button();
            this.btn_pagarcr = new System.Windows.Forms.Button();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.grp_lele.SuspendLayout();
            this.grp_pagamentocr.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ncartao
            // 
            this.lbl_ncartao.AutoSize = true;
            this.lbl_ncartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ncartao.Location = new System.Drawing.Point(6, 30);
            this.lbl_ncartao.Name = "lbl_ncartao";
            this.lbl_ncartao.Size = new System.Drawing.Size(89, 16);
            this.lbl_ncartao.TabIndex = 0;
            this.lbl_ncartao.Text = "Nº do cartão :";
            // 
            // grp_lele
            // 
            this.grp_lele.Controls.Add(this.txt_valorpagar1);
            this.grp_lele.Controls.Add(this.lbl_valorpagar1);
            this.grp_lele.Controls.Add(this.btn_pagar);
            this.grp_lele.Controls.Add(this.lbl_valor);
            this.grp_lele.Controls.Add(this.lbl_mostrarvalor);
            this.grp_lele.Controls.Add(this.txt_cartao);
            this.grp_lele.Controls.Add(this.lbl_ncartao);
            this.grp_lele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_lele.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grp_lele.Location = new System.Drawing.Point(12, 53);
            this.grp_lele.Name = "grp_lele";
            this.grp_lele.Size = new System.Drawing.Size(358, 196);
            this.grp_lele.TabIndex = 2;
            this.grp_lele.TabStop = false;
            this.grp_lele.Text = "Pagamento no cartão";
            this.grp_lele.Visible = false;
            this.grp_lele.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_valorpagar1
            // 
            this.txt_valorpagar1.Location = new System.Drawing.Point(150, 63);
            this.txt_valorpagar1.Name = "txt_valorpagar1";
            this.txt_valorpagar1.Size = new System.Drawing.Size(124, 22);
            this.txt_valorpagar1.TabIndex = 9;
            this.txt_valorpagar1.TextChanged += new System.EventHandler(this.txt_pagar_TextChanged);
            // 
            // lbl_valorpagar1
            // 
            this.lbl_valorpagar1.AutoSize = true;
            this.lbl_valorpagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorpagar1.Location = new System.Drawing.Point(3, 64);
            this.lbl_valorpagar1.Name = "lbl_valorpagar1";
            this.lbl_valorpagar1.Size = new System.Drawing.Size(116, 16);
            this.lbl_valorpagar1.TabIndex = 8;
            this.lbl_valorpagar1.Text = "Valor para pagar :";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.Location = new System.Drawing.Point(7, 165);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar.TabIndex = 4;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_valor.Location = new System.Drawing.Point(259, 168);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(38, 16);
            this.lbl_valor.TabIndex = 3;
            this.lbl_valor.Text = "valor";
            this.lbl_valor.Click += new System.EventHandler(this.lbl_valor_Click);
            // 
            // lbl_mostrarvalor
            // 
            this.lbl_mostrarvalor.AutoSize = true;
            this.lbl_mostrarvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostrarvalor.Location = new System.Drawing.Point(130, 168);
            this.lbl_mostrarvalor.Name = "lbl_mostrarvalor";
            this.lbl_mostrarvalor.Size = new System.Drawing.Size(96, 16);
            this.lbl_mostrarvalor.TabIndex = 2;
            this.lbl_mostrarvalor.Text = "Valor a pagar :";
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(120, 26);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(154, 22);
            this.txt_cartao.TabIndex = 1;
            this.txt_cartao.TextChanged += new System.EventHandler(this.txt_cartao_TextChanged);
            // 
            // grp_pagamentocr
            // 
            this.grp_pagamentocr.Controls.Add(this.txt_valorpagar2);
            this.grp_pagamentocr.Controls.Add(this.label10);
            this.grp_pagamentocr.Controls.Add(this.txt_senha);
            this.grp_pagamentocr.Controls.Add(this.label9);
            this.grp_pagamentocr.Controls.Add(this.txt_conta);
            this.grp_pagamentocr.Controls.Add(this.label7);
            this.grp_pagamentocr.Controls.Add(this.txt_nomebanco);
            this.grp_pagamentocr.Controls.Add(this.label6);
            this.grp_pagamentocr.Controls.Add(this.lbl_valor2);
            this.grp_pagamentocr.Controls.Add(this.label4);
            this.grp_pagamentocr.Controls.Add(this.txt_agencia);
            this.grp_pagamentocr.Controls.Add(this.label5);
            this.grp_pagamentocr.Controls.Add(this.btn_pagar2);
            this.grp_pagamentocr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_pagamentocr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grp_pagamentocr.Location = new System.Drawing.Point(400, 53);
            this.grp_pagamentocr.Name = "grp_pagamentocr";
            this.grp_pagamentocr.Size = new System.Drawing.Size(358, 242);
            this.grp_pagamentocr.TabIndex = 3;
            this.grp_pagamentocr.TabStop = false;
            this.grp_pagamentocr.Text = "Pagamento no crédito";
            this.grp_pagamentocr.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_valorpagar2
            // 
            this.txt_valorpagar2.Location = new System.Drawing.Point(125, 177);
            this.txt_valorpagar2.Name = "txt_valorpagar2";
            this.txt_valorpagar2.Size = new System.Drawing.Size(124, 22);
            this.txt_valorpagar2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Valor para pagar :";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(70, 118);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(102, 22);
            this.txt_senha.TabIndex = 15;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Senha :";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(162, 52);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(135, 22);
            this.txt_conta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nº da conta :";
            // 
            // txt_nomebanco
            // 
            this.txt_nomebanco.Location = new System.Drawing.Point(150, 82);
            this.txt_nomebanco.Name = "txt_nomebanco";
            this.txt_nomebanco.Size = new System.Drawing.Size(147, 22);
            this.txt_nomebanco.TabIndex = 11;
            this.txt_nomebanco.TextChanged += new System.EventHandler(this.txt_nomebanco_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nome do banco :";
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_valor2.Location = new System.Drawing.Point(273, 216);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(38, 16);
            this.lbl_valor2.TabIndex = 9;
            this.lbl_valor2.Text = "valor";
            this.lbl_valor2.Click += new System.EventHandler(this.lbl_valor2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor a pagar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(150, 24);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(147, 22);
            this.txt_agencia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nº da agencia :";
            // 
            // btn_pagar2
            // 
            this.btn_pagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar2.Location = new System.Drawing.Point(6, 213);
            this.btn_pagar2.Name = "btn_pagar2";
            this.btn_pagar2.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar2.TabIndex = 5;
            this.btn_pagar2.Text = "Pagar";
            this.btn_pagar2.UseVisualStyleBackColor = true;
            this.btn_pagar2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(-3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 10);
            this.panel1.TabIndex = 16;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(12, 339);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(128, 23);
            this.btn_voltar.TabIndex = 16;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(170, 339);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(129, 23);
            this.btn_limpar.TabIndex = 17;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(318, 339);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(128, 23);
            this.btn_sair.TabIndex = 18;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_pagarc
            // 
            this.btn_pagarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagarc.Location = new System.Drawing.Point(109, 12);
            this.btn_pagarc.Name = "btn_pagarc";
            this.btn_pagarc.Size = new System.Drawing.Size(128, 23);
            this.btn_pagarc.TabIndex = 19;
            this.btn_pagarc.Text = "Pagar no cartão";
            this.btn_pagarc.UseVisualStyleBackColor = true;
            this.btn_pagarc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_pagarcr
            // 
            this.btn_pagarcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagarcr.Location = new System.Drawing.Point(525, 12);
            this.btn_pagarcr.Name = "btn_pagarcr";
            this.btn_pagarcr.Size = new System.Drawing.Size(128, 23);
            this.btn_pagarcr.TabIndex = 19;
            this.btn_pagarcr.Text = "Pagar no crédito";
            this.btn_pagarcr.UseVisualStyleBackColor = true;
            this.btn_pagarcr.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sobre
            // 
            this.btn_sobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sobre.Location = new System.Drawing.Point(709, 339);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(49, 23);
            this.btn_sobre.TabIndex = 21;
            this.btn_sobre.Text = "Sobre";
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(768, 367);
            this.Controls.Add(this.btn_sobre);
            this.Controls.Add(this.btn_pagarcr);
            this.Controls.Add(this.btn_pagarc);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_pagamentocr);
            this.Controls.Add(this.grp_lele);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Pagamento";
            this.grp_lele.ResumeLayout(false);
            this.grp_lele.PerformLayout();
            this.grp_pagamentocr.ResumeLayout(false);
            this.grp_pagamentocr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ncartao;
        private System.Windows.Forms.GroupBox grp_lele;
        private System.Windows.Forms.TextBox txt_valorpagar1;
        private System.Windows.Forms.Label lbl_valorpagar1;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_mostrarvalor;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.GroupBox grp_pagamentocr;
        private System.Windows.Forms.TextBox txt_valorpagar2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nomebanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pagar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_pagarc;
        private System.Windows.Forms.Button btn_pagarcr;
        private System.Windows.Forms.Button btn_sobre;
    }
}