namespace Projeto_LP2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_LoginUsuário = new System.Windows.Forms.Label();
            this.lb_LoginSenha = new System.Windows.Forms.Label();
            this.userCampo = new System.Windows.Forms.TextBox();
            this.senhaCampo = new System.Windows.Forms.TextBox();
            this.btn_EntrarLogin = new System.Windows.Forms.Button();
            this.btn_SairLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_CadastreLogin = new System.Windows.Forms.Button();
            this.erroLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LoginUsuário
            // 
            this.lb_LoginUsuário.AutoSize = true;
            this.lb_LoginUsuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoginUsuário.Location = new System.Drawing.Point(240, 101);
            this.lb_LoginUsuário.Name = "lb_LoginUsuário";
            this.lb_LoginUsuário.Size = new System.Drawing.Size(68, 20);
            this.lb_LoginUsuário.TabIndex = 0;
            this.lb_LoginUsuário.Text = "Usuário ";
            this.lb_LoginUsuário.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_LoginSenha
            // 
            this.lb_LoginSenha.AutoSize = true;
            this.lb_LoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoginSenha.Location = new System.Drawing.Point(240, 156);
            this.lb_LoginSenha.Name = "lb_LoginSenha";
            this.lb_LoginSenha.Size = new System.Drawing.Size(56, 20);
            this.lb_LoginSenha.TabIndex = 1;
            this.lb_LoginSenha.Text = "Senha";
            this.lb_LoginSenha.Click += new System.EventHandler(this.txt_LoginSenha_Click);
            // 
            // userCampo
            // 
            this.userCampo.Location = new System.Drawing.Point(328, 103);
            this.userCampo.Name = "userCampo";
            this.userCampo.Size = new System.Drawing.Size(133, 20);
            this.userCampo.TabIndex = 2;
            this.userCampo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // senhaCampo
            // 
            this.senhaCampo.Location = new System.Drawing.Point(328, 158);
            this.senhaCampo.Name = "senhaCampo";
            this.senhaCampo.PasswordChar = '*';
            this.senhaCampo.Size = new System.Drawing.Size(133, 20);
            this.senhaCampo.TabIndex = 3;
            this.senhaCampo.TextChanged += new System.EventHandler(this.txt_SenhaLogin_TextChanged);
            // 
            // btn_EntrarLogin
            // 
            this.btn_EntrarLogin.Location = new System.Drawing.Point(248, 208);
            this.btn_EntrarLogin.Name = "btn_EntrarLogin";
            this.btn_EntrarLogin.Size = new System.Drawing.Size(86, 30);
            this.btn_EntrarLogin.TabIndex = 4;
            this.btn_EntrarLogin.Text = "Entrar";
            this.btn_EntrarLogin.UseVisualStyleBackColor = true;
            this.btn_EntrarLogin.Click += new System.EventHandler(this.enter_Click);
            // 
            // btn_SairLogin
            // 
            this.btn_SairLogin.Location = new System.Drawing.Point(379, 208);
            this.btn_SairLogin.Name = "btn_SairLogin";
            this.btn_SairLogin.Size = new System.Drawing.Size(86, 30);
            this.btn_SairLogin.TabIndex = 5;
            this.btn_SairLogin.Text = "Sair";
            this.btn_SairLogin.UseVisualStyleBackColor = true;
            this.btn_SairLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txt_CadastreLogin
            // 
            this.txt_CadastreLogin.Location = new System.Drawing.Point(303, 261);
            this.txt_CadastreLogin.Name = "txt_CadastreLogin";
            this.txt_CadastreLogin.Size = new System.Drawing.Size(99, 41);
            this.txt_CadastreLogin.TabIndex = 7;
            this.txt_CadastreLogin.Text = "CADASTRE-SE";
            this.txt_CadastreLogin.UseVisualStyleBackColor = true;
            this.txt_CadastreLogin.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // erroLogin
            // 
            this.erroLogin.AutoSize = true;
            this.erroLogin.ForeColor = System.Drawing.Color.Red;
            this.erroLogin.Location = new System.Drawing.Point(332, 181);
            this.erroLogin.Name = "erroLogin";
            this.erroLogin.Size = new System.Drawing.Size(103, 13);
            this.erroLogin.TabIndex = 8;
            this.erroLogin.Text = "user = 1 / senha = 1";
            this.erroLogin.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(305, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opção Desabilitada";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(506, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.erroLogin);
            this.Controls.Add(this.txt_CadastreLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SairLogin);
            this.Controls.Add(this.btn_EntrarLogin);
            this.Controls.Add(this.senhaCampo);
            this.Controls.Add(this.userCampo);
            this.Controls.Add(this.lb_LoginSenha);
            this.Controls.Add(this.lb_LoginUsuário);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LoginUsuário;
        private System.Windows.Forms.Label lb_LoginSenha;
        private System.Windows.Forms.TextBox userCampo;
        private System.Windows.Forms.TextBox senhaCampo;
        private System.Windows.Forms.Button btn_EntrarLogin;
        private System.Windows.Forms.Button btn_SairLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txt_CadastreLogin;
        private System.Windows.Forms.Label erroLogin;
        private System.Windows.Forms.Label label1;
    }
}