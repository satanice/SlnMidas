﻿namespace Apresentacao
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.dgwFornecedor = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cpoNome = new System.Windows.Forms.TextBox();
            this.CaixaPesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cpoCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cpoCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cpoTelefone = new System.Windows.Forms.TextBox();
            this.cpoEmail = new System.Windows.Forms.TextBox();
            this.cpoEndereco = new System.Windows.Forms.TextBox();
            this.cpoCidade = new System.Windows.Forms.TextBox();
            this.cpoUf = new System.Windows.Forms.TextBox();
            this.cpoRazaoSocial = new System.Windows.Forms.TextBox();
            this.lbl_data_hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwFornecedor
            // 
            this.dgwFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CNPJ,
            this.RazaoSocial,
            this.Endereco,
            this.Cidade,
            this.Uf,
            this.Cpf,
            this.Email,
            this.Telefone,
            this.Ativo});
            this.dgwFornecedor.Location = new System.Drawing.Point(44, 70);
            this.dgwFornecedor.Name = "dgwFornecedor";
            this.dgwFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwFornecedor.Size = new System.Drawing.Size(782, 211);
            this.dgwFornecedor.TabIndex = 53;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = " Razao Social";
            this.RazaoSocial.Name = "RazaoSocial";
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Uf
            // 
            this.Uf.HeaderText = "UF";
            this.Uf.Name = "Uf";
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            // 
            // cpoNome
            // 
            this.cpoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoNome.Location = new System.Drawing.Point(100, 312);
            this.cpoNome.Name = "cpoNome";
            this.cpoNome.Size = new System.Drawing.Size(247, 20);
            this.cpoNome.TabIndex = 36;
            this.cpoNome.TextChanged += new System.EventHandler(this.cpoNome_TextChanged);
            // 
            // CaixaPesquisa
            // 
            this.CaixaPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaixaPesquisa.Location = new System.Drawing.Point(183, 27);
            this.CaixaPesquisa.Multiline = true;
            this.CaixaPesquisa.Name = "CaixaPesquisa";
            this.CaixaPesquisa.Size = new System.Drawing.Size(643, 23);
            this.CaixaPesquisa.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nome";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::Apresentacao.Properties.Resources.pesquisar1;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(44, 13);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(124, 45);
            this.btnPesquisa.TabIndex = 45;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Apresentacao.Properties.Resources.delete_4219;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(518, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 44);
            this.button5.TabIndex = 57;
            this.button5.Text = "Excluir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.saveall_1204;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(735, 447);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 44);
            this.btnSalvar.TabIndex = 56;
            this.btnSalvar.Text = "   Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Apresentacao.Properties.Resources.cancel_stop_exit_1583;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(626, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 44);
            this.button3.TabIndex = 55;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Apresentacao.Properties.Resources.document_write_22637;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(407, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "Alterar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cpoCpf
            // 
            this.cpoCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCpf.Location = new System.Drawing.Point(723, 381);
            this.cpoCpf.Name = "cpoCpf";
            this.cpoCpf.Size = new System.Drawing.Size(103, 20);
            this.cpoCpf.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Razão Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Endereço";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(723, 358);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 17);
            this.radioButton1.TabIndex = 67;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pessoa Física";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "CPF";
            // 
            // cpoCnpj
            // 
            this.cpoCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCnpj.Location = new System.Drawing.Point(723, 312);
            this.cpoCnpj.Name = "cpoCnpj";
            this.cpoCnpj.Size = new System.Drawing.Size(103, 20);
            this.cpoCnpj.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "CNPJ";
            // 
            // cpoTelefone
            // 
            this.cpoTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoTelefone.Location = new System.Drawing.Point(100, 381);
            this.cpoTelefone.Name = "cpoTelefone";
            this.cpoTelefone.Size = new System.Drawing.Size(247, 20);
            this.cpoTelefone.TabIndex = 72;
            // 
            // cpoEmail
            // 
            this.cpoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEmail.Location = new System.Drawing.Point(433, 381);
            this.cpoEmail.Name = "cpoEmail";
            this.cpoEmail.Size = new System.Drawing.Size(245, 20);
            this.cpoEmail.TabIndex = 73;
            // 
            // cpoEndereco
            // 
            this.cpoEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoEndereco.Location = new System.Drawing.Point(100, 348);
            this.cpoEndereco.Name = "cpoEndereco";
            this.cpoEndereco.Size = new System.Drawing.Size(247, 20);
            this.cpoEndereco.TabIndex = 74;
            // 
            // cpoCidade
            // 
            this.cpoCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoCidade.Location = new System.Drawing.Point(433, 348);
            this.cpoCidade.Name = "cpoCidade";
            this.cpoCidade.Size = new System.Drawing.Size(170, 20);
            this.cpoCidade.TabIndex = 75;
            // 
            // cpoUf
            // 
            this.cpoUf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoUf.Location = new System.Drawing.Point(636, 348);
            this.cpoUf.Name = "cpoUf";
            this.cpoUf.Size = new System.Drawing.Size(42, 20);
            this.cpoUf.TabIndex = 76;
            // 
            // cpoRazaoSocial
            // 
            this.cpoRazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpoRazaoSocial.Location = new System.Drawing.Point(433, 312);
            this.cpoRazaoSocial.Name = "cpoRazaoSocial";
            this.cpoRazaoSocial.Size = new System.Drawing.Size(246, 20);
            this.cpoRazaoSocial.TabIndex = 77;
            // 
            // lbl_data_hora
            // 
            this.lbl_data_hora.AutoSize = true;
            this.lbl_data_hora.Location = new System.Drawing.Point(49, 478);
            this.lbl_data_hora.Name = "lbl_data_hora";
            this.lbl_data_hora.Size = new System.Drawing.Size(0, 13);
            this.lbl_data_hora.TabIndex = 78;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.lbl_data_hora);
            this.Controls.Add(this.cpoRazaoSocial);
            this.Controls.Add(this.cpoUf);
            this.Controls.Add(this.cpoCidade);
            this.Controls.Add(this.cpoEndereco);
            this.Controls.Add(this.cpoEmail);
            this.Controls.Add(this.cpoTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cpoCnpj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cpoCpf);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwFornecedor);
            this.Controls.Add(this.cpoNome);
            this.Controls.Add(this.CaixaPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisa);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTE";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwFornecedor;
        private System.Windows.Forms.TextBox cpoNome;
        private System.Windows.Forms.TextBox CaixaPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cpoCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpoCnpj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cpoTelefone;
        private System.Windows.Forms.TextBox cpoEmail;
        private System.Windows.Forms.TextBox cpoEndereco;
        private System.Windows.Forms.TextBox cpoCidade;
        private System.Windows.Forms.TextBox cpoUf;
        private System.Windows.Forms.TextBox cpoRazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ativo;
        private System.Windows.Forms.Label lbl_data_hora;
        private System.Windows.Forms.Timer timer1;
    }
}