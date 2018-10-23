namespace Projeto_LP2
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NomeCadastro = new System.Windows.Forms.TextBox();
            this.txt_SobrenomeCadastro = new System.Windows.Forms.TextBox();
            this.txt_EmailCadastro = new System.Windows.Forms.TextBox();
            this.txt_SenhaCadastro = new System.Windows.Forms.TextBox();
            this.txt_ConfirmeSenhaCadastro = new System.Windows.Forms.TextBox();
            this.btn_CadastrarCadastro = new System.Windows.Forms.Button();
            this.btn_SairCadastro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UsuarioCadastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVerificaNome = new System.Windows.Forms.Label();
            this.lblVerificaSobrenome = new System.Windows.Forms.Label();
            this.lblVerificaUsuario = new System.Windows.Forms.Label();
            this.lblVerificaEmail = new System.Windows.Forms.Label();
            this.lblVerificiaSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sobrenome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirme a senha ";
            // 
            // txt_NomeCadastro
            // 
            this.txt_NomeCadastro.Location = new System.Drawing.Point(82, 99);
            this.txt_NomeCadastro.Name = "txt_NomeCadastro";
            this.txt_NomeCadastro.Size = new System.Drawing.Size(195, 20);
            this.txt_NomeCadastro.TabIndex = 5;
            this.txt_NomeCadastro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_SobrenomeCadastro
            // 
            this.txt_SobrenomeCadastro.Location = new System.Drawing.Point(340, 99);
            this.txt_SobrenomeCadastro.Name = "txt_SobrenomeCadastro";
            this.txt_SobrenomeCadastro.Size = new System.Drawing.Size(195, 20);
            this.txt_SobrenomeCadastro.TabIndex = 6;
            this.txt_SobrenomeCadastro.TextChanged += new System.EventHandler(this.txt_SobrenomeCadastro_TextChanged);
            // 
            // txt_EmailCadastro
            // 
            this.txt_EmailCadastro.Location = new System.Drawing.Point(82, 229);
            this.txt_EmailCadastro.Name = "txt_EmailCadastro";
            this.txt_EmailCadastro.Size = new System.Drawing.Size(262, 20);
            this.txt_EmailCadastro.TabIndex = 8;
            this.txt_EmailCadastro.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_SenhaCadastro
            // 
            this.txt_SenhaCadastro.Location = new System.Drawing.Point(82, 311);
            this.txt_SenhaCadastro.Name = "txt_SenhaCadastro";
            this.txt_SenhaCadastro.Size = new System.Drawing.Size(195, 20);
            this.txt_SenhaCadastro.TabIndex = 9;
            this.txt_SenhaCadastro.UseSystemPasswordChar = true;
            this.txt_SenhaCadastro.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_ConfirmeSenhaCadastro
            // 
            this.txt_ConfirmeSenhaCadastro.Location = new System.Drawing.Point(340, 311);
            this.txt_ConfirmeSenhaCadastro.Name = "txt_ConfirmeSenhaCadastro";
            this.txt_ConfirmeSenhaCadastro.Size = new System.Drawing.Size(195, 20);
            this.txt_ConfirmeSenhaCadastro.TabIndex = 10;
            this.txt_ConfirmeSenhaCadastro.UseSystemPasswordChar = true;
            this.txt_ConfirmeSenhaCadastro.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_CadastrarCadastro
            // 
            this.btn_CadastrarCadastro.Location = new System.Drawing.Point(82, 359);
            this.btn_CadastrarCadastro.Name = "btn_CadastrarCadastro";
            this.btn_CadastrarCadastro.Size = new System.Drawing.Size(117, 42);
            this.btn_CadastrarCadastro.TabIndex = 11;
            this.btn_CadastrarCadastro.Text = "Cadastrar";
            this.btn_CadastrarCadastro.UseVisualStyleBackColor = true;
            this.btn_CadastrarCadastro.Click += new System.EventHandler(this.btn_CadastrarCadastro_Click);
            // 
            // btn_SairCadastro
            // 
            this.btn_SairCadastro.Location = new System.Drawing.Point(418, 359);
            this.btn_SairCadastro.Name = "btn_SairCadastro";
            this.btn_SairCadastro.Size = new System.Drawing.Size(117, 42);
            this.btn_SairCadastro.TabIndex = 12;
            this.btn_SairCadastro.Text = "Sair";
            this.btn_SairCadastro.UseVisualStyleBackColor = true;
            this.btn_SairCadastro.Click += new System.EventHandler(this.btn_SairCadastro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UsuarioCadastro
            // 
            this.txt_UsuarioCadastro.Location = new System.Drawing.Point(82, 166);
            this.txt_UsuarioCadastro.Name = "txt_UsuarioCadastro";
            this.txt_UsuarioCadastro.Size = new System.Drawing.Size(262, 20);
            this.txt_UsuarioCadastro.TabIndex = 7;
            this.txt_UsuarioCadastro.TextChanged += new System.EventHandler(this.txt_UsuarioCadastro_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Usuario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblVerificaNome
            // 
            this.lblVerificaNome.AutoSize = true;
            this.lblVerificaNome.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaNome.Location = new System.Drawing.Point(79, 122);
            this.lblVerificaNome.Name = "lblVerificaNome";
            this.lblVerificaNome.Size = new System.Drawing.Size(83, 13);
            this.lblVerificaNome.TabIndex = 16;
            this.lblVerificaNome.Text = "Usuario Invalido";
            this.lblVerificaNome.Visible = false;
            // 
            // lblVerificaSobrenome
            // 
            this.lblVerificaSobrenome.AutoSize = true;
            this.lblVerificaSobrenome.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaSobrenome.Location = new System.Drawing.Point(337, 126);
            this.lblVerificaSobrenome.Name = "lblVerificaSobrenome";
            this.lblVerificaSobrenome.Size = new System.Drawing.Size(101, 13);
            this.lblVerificaSobrenome.TabIndex = 17;
            this.lblVerificaSobrenome.Text = "Sobrenome Invalido";
            this.lblVerificaSobrenome.Visible = false;
            // 
            // lblVerificaUsuario
            // 
            this.lblVerificaUsuario.AutoSize = true;
            this.lblVerificaUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaUsuario.Location = new System.Drawing.Point(219, 189);
            this.lblVerificaUsuario.Name = "lblVerificaUsuario";
            this.lblVerificaUsuario.Size = new System.Drawing.Size(83, 13);
            this.lblVerificaUsuario.TabIndex = 18;
            this.lblVerificaUsuario.Text = "Usuário Inválido";
            this.lblVerificaUsuario.Visible = false;
            // 
            // lblVerificaEmail
            // 
            this.lblVerificaEmail.AutoSize = true;
            this.lblVerificaEmail.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaEmail.Location = new System.Drawing.Point(79, 252);
            this.lblVerificaEmail.Name = "lblVerificaEmail";
            this.lblVerificaEmail.Size = new System.Drawing.Size(75, 13);
            this.lblVerificaEmail.TabIndex = 19;
            this.lblVerificaEmail.Text = "E-mail Inválido";
            this.lblVerificaEmail.Visible = false;
            // 
            // lblVerificiaSenha
            // 
            this.lblVerificiaSenha.AutoSize = true;
            this.lblVerificiaSenha.ForeColor = System.Drawing.Color.Red;
            this.lblVerificiaSenha.Location = new System.Drawing.Point(337, 334);
            this.lblVerificiaSenha.Name = "lblVerificiaSenha";
            this.lblVerificiaSenha.Size = new System.Drawing.Size(121, 13);
            this.lblVerificiaSenha.TabIndex = 20;
            this.lblVerificiaSenha.Text = "Senha não corresponde";
            this.lblVerificiaSenha.Visible = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.lblVerificiaSenha);
            this.Controls.Add(this.lblVerificaEmail);
            this.Controls.Add(this.lblVerificaUsuario);
            this.Controls.Add(this.lblVerificaSobrenome);
            this.Controls.Add(this.lblVerificaNome);
            this.Controls.Add(this.txt_UsuarioCadastro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SairCadastro);
            this.Controls.Add(this.btn_CadastrarCadastro);
            this.Controls.Add(this.txt_ConfirmeSenhaCadastro);
            this.Controls.Add(this.txt_SenhaCadastro);
            this.Controls.Add(this.txt_EmailCadastro);
            this.Controls.Add(this.txt_SobrenomeCadastro);
            this.Controls.Add(this.txt_NomeCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NomeCadastro;
        private System.Windows.Forms.TextBox txt_SobrenomeCadastro;
        private System.Windows.Forms.TextBox txt_EmailCadastro;
        private System.Windows.Forms.TextBox txt_SenhaCadastro;
        private System.Windows.Forms.TextBox txt_ConfirmeSenhaCadastro;
        private System.Windows.Forms.Button btn_CadastrarCadastro;
        private System.Windows.Forms.Button btn_SairCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_UsuarioCadastro;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label lblVerificaNome;
        private System.Windows.Forms.Label lblVerificaSobrenome;
        private System.Windows.Forms.Label lblVerificaUsuario;
        private System.Windows.Forms.Label lblVerificaEmail;
        private System.Windows.Forms.Label lblVerificiaSenha;
    }
}