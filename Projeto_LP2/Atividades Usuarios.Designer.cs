namespace Projeto_LP2
{
    partial class Atividades_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atividades_Usuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_NovoProjetoAtividadesUsuarios = new System.Windows.Forms.Button();
            this.btn_GerenciarDadosAtividadesUsuarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_NovoProjetoAtividadesUsuarios
            // 
            this.btn_NovoProjetoAtividadesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoProjetoAtividadesUsuarios.Location = new System.Drawing.Point(320, 121);
            this.btn_NovoProjetoAtividadesUsuarios.Name = "btn_NovoProjetoAtividadesUsuarios";
            this.btn_NovoProjetoAtividadesUsuarios.Size = new System.Drawing.Size(139, 44);
            this.btn_NovoProjetoAtividadesUsuarios.TabIndex = 1;
            this.btn_NovoProjetoAtividadesUsuarios.Text = "Novo Projeto";
            this.btn_NovoProjetoAtividadesUsuarios.UseVisualStyleBackColor = true;
            this.btn_NovoProjetoAtividadesUsuarios.Click += new System.EventHandler(this.novo_projeto_Click);
            // 
            // btn_GerenciarDadosAtividadesUsuarios
            // 
            this.btn_GerenciarDadosAtividadesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_GerenciarDadosAtividadesUsuarios.Location = new System.Drawing.Point(308, 203);
            this.btn_GerenciarDadosAtividadesUsuarios.Name = "btn_GerenciarDadosAtividadesUsuarios";
            this.btn_GerenciarDadosAtividadesUsuarios.Size = new System.Drawing.Size(164, 44);
            this.btn_GerenciarDadosAtividadesUsuarios.TabIndex = 2;
            this.btn_GerenciarDadosAtividadesUsuarios.Text = "Gerenciar Indicadores";
            this.btn_GerenciarDadosAtividadesUsuarios.UseVisualStyleBackColor = true;
            this.btn_GerenciarDadosAtividadesUsuarios.Click += new System.EventHandler(this.gerenciar_dados_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gerenciar Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.gerItem_Click);
            // 
            // Atividades_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_GerenciarDadosAtividadesUsuarios);
            this.Controls.Add(this.btn_NovoProjetoAtividadesUsuarios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Atividades_Usuarios";
            this.Text = "Atividades_Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormCLose);
            this.Load += new System.EventHandler(this.Atividades_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_NovoProjetoAtividadesUsuarios;
        private System.Windows.Forms.Button btn_GerenciarDadosAtividadesUsuarios;
        private System.Windows.Forms.Button button1;
    }
}