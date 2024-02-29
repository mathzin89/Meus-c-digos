namespace Plenitude
{
    partial class NovoMembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoMembro));
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cb_batismoes = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nomepai = new System.Windows.Forms.TextBox();
            this.tb_nomemae = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_estadocivil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d_datanascimento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.n_idademembro = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nomemembro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d_databatismo = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addfoto = new System.Windows.Forms.Button();
            this.mtb_telefonecelular = new System.Windows.Forms.MaskedTextBox();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_idademembro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(109, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(97, 23);
            this.btn_excluir.TabIndex = 108;
            this.btn_excluir.Text = "Excluir usuário";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(6, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar.TabIndex = 107;
            this.btn_salvar.Text = "Salvar alterações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(212, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(97, 23);
            this.btn_novo.TabIndex = 106;
            this.btn_novo.Text = "Limpar";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // cb_batismoes
            // 
            this.cb_batismoes.FormattingEnabled = true;
            this.cb_batismoes.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cb_batismoes.Location = new System.Drawing.Point(330, 146);
            this.cb_batismoes.Name = "cb_batismoes";
            this.cb_batismoes.Size = new System.Drawing.Size(145, 21);
            this.cb_batismoes.TabIndex = 103;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 102;
            this.label14.Text = "Batizado com Espirito Santo?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "Data Batismo";
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Congregado",
            "Membro",
            "Cooperador",
            "Diácono",
            "Diaconisa",
            "Presbítero",
            "Missionária",
            "Evangelista",
            "Pastor"});
            this.cb_cargo.Location = new System.Drawing.Point(12, 146);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(91, 21);
            this.cb_cargo.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Cargo";
            // 
            // tb_nomepai
            // 
            this.tb_nomepai.Location = new System.Drawing.Point(330, 107);
            this.tb_nomepai.Name = "tb_nomepai";
            this.tb_nomepai.Size = new System.Drawing.Size(215, 20);
            this.tb_nomepai.TabIndex = 97;
            // 
            // tb_nomemae
            // 
            this.tb_nomemae.Location = new System.Drawing.Point(109, 108);
            this.tb_nomemae.Name = "tb_nomemae";
            this.tb_nomemae.Size = new System.Drawing.Size(215, 20);
            this.tb_nomemae.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 95;
            this.label11.Text = "Pai";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Mãe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Telefone Celular";
            // 
            // cb_estadocivil
            // 
            this.cb_estadocivil.FormattingEnabled = true;
            this.cb_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Separado(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.cb_estadocivil.Location = new System.Drawing.Point(445, 64);
            this.cb_estadocivil.Name = "cb_estadocivil";
            this.cb_estadocivil.Size = new System.Drawing.Size(100, 21);
            this.cb_estadocivil.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Estado Cívil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "Data de Nascimento";
            // 
            // d_datanascimento
            // 
            this.d_datanascimento.Location = new System.Drawing.Point(224, 64);
            this.d_datanascimento.Name = "d_datanascimento";
            this.d_datanascimento.Size = new System.Drawing.Size(215, 20);
            this.d_datanascimento.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "CPF";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(109, 64);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(109, 20);
            this.tb_cpf.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "RG";
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(12, 64);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(91, 20);
            this.tb_rg.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(334, 25);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(314, 20);
            this.tb_endereco.TabIndex = 82;
            // 
            // n_idademembro
            // 
            this.n_idademembro.Location = new System.Drawing.Point(263, 25);
            this.n_idademembro.Name = "n_idademembro";
            this.n_idademembro.Size = new System.Drawing.Size(63, 20);
            this.n_idademembro.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Idade";
            // 
            // tb_nomemembro
            // 
            this.tb_nomemembro.Location = new System.Drawing.Point(12, 25);
            this.tb_nomemembro.Name = "tb_nomemembro";
            this.tb_nomemembro.Size = new System.Drawing.Size(245, 20);
            this.tb_nomemembro.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Nome completo";
            // 
            // d_databatismo
            // 
            this.d_databatismo.Location = new System.Drawing.Point(109, 147);
            this.d_databatismo.Name = "d_databatismo";
            this.d_databatismo.Size = new System.Drawing.Size(215, 20);
            this.d_databatismo.TabIndex = 109;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 29);
            this.panel1.TabIndex = 110;
            // 
            // btn_addfoto
            // 
            this.btn_addfoto.Location = new System.Drawing.Point(660, 143);
            this.btn_addfoto.Name = "btn_addfoto";
            this.btn_addfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_addfoto.TabIndex = 109;
            this.btn_addfoto.Text = "Add Foto";
            this.btn_addfoto.UseVisualStyleBackColor = true;
            this.btn_addfoto.Click += new System.EventHandler(this.btn_addfoto_Click);
            // 
            // mtb_telefonecelular
            // 
            this.mtb_telefonecelular.Location = new System.Drawing.Point(12, 108);
            this.mtb_telefonecelular.Mask = "(00) 00000-0000";
            this.mtb_telefonecelular.Name = "mtb_telefonecelular";
            this.mtb_telefonecelular.Size = new System.Drawing.Size(91, 20);
            this.mtb_telefonecelular.TabIndex = 111;
            // 
            // pb_foto
            // 
            this.pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_foto.Location = new System.Drawing.Point(654, 25);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(85, 113);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 112;
            this.pb_foto.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(684, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 116;
            this.label15.Text = "MSS Tech.";
            // 
            // NovoMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(748, 201);
            this.Controls.Add(this.btn_addfoto);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.mtb_telefonecelular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.d_databatismo);
            this.Controls.Add(this.cb_batismoes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_nomepai);
            this.Controls.Add(this.tb_nomemae);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_estadocivil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.d_datanascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.n_idademembro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nomemembro);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NovoMembro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Membro";
            ((System.ComponentModel.ISupportInitialize)(this.n_idademembro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.ComboBox cb_batismoes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_nomepai;
        private System.Windows.Forms.TextBox tb_nomemae;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_estadocivil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker d_datanascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.NumericUpDown n_idademembro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nomemembro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker d_databatismo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtb_telefonecelular;
        private System.Windows.Forms.Button btn_addfoto;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label15;
    }
}