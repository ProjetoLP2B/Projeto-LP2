namespace Projeto_LP2
{
    partial class Indicadores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indicadores));
            this.lst_Indicadores = new System.Windows.Forms.ListBox();
            this.btn_InserirIndicadores = new System.Windows.Forms.Button();
            this.btn_AlterarIndicadores = new System.Windows.Forms.Button();
            this.btn_CancelarIndicadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Indicadores
            // 
            this.lst_Indicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_Indicadores.FormattingEnabled = true;
            this.lst_Indicadores.ItemHeight = 18;
            this.lst_Indicadores.Location = new System.Drawing.Point(14, 21);
            this.lst_Indicadores.Name = "lst_Indicadores";
            this.lst_Indicadores.Size = new System.Drawing.Size(530, 328);
            this.lst_Indicadores.TabIndex = 0;
            // 
            // btn_InserirIndicadores
            // 
            this.btn_InserirIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InserirIndicadores.Location = new System.Drawing.Point(196, 374);
            this.btn_InserirIndicadores.Name = "btn_InserirIndicadores";
            this.btn_InserirIndicadores.Size = new System.Drawing.Size(160, 33);
            this.btn_InserirIndicadores.TabIndex = 1;
            this.btn_InserirIndicadores.Text = "Inserir";
            this.btn_InserirIndicadores.UseVisualStyleBackColor = true;
            // 
            // btn_AlterarIndicadores
            // 
            this.btn_AlterarIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarIndicadores.Location = new System.Drawing.Point(14, 374);
            this.btn_AlterarIndicadores.Name = "btn_AlterarIndicadores";
            this.btn_AlterarIndicadores.Size = new System.Drawing.Size(158, 33);
            this.btn_AlterarIndicadores.TabIndex = 2;
            this.btn_AlterarIndicadores.Text = "Alterar";
            this.btn_AlterarIndicadores.UseVisualStyleBackColor = true;
            this.btn_AlterarIndicadores.Click += new System.EventHandler(this.btn_AlterarIndicadores_Click);
            // 
            // btn_CancelarIndicadores
            // 
            this.btn_CancelarIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarIndicadores.Location = new System.Drawing.Point(384, 374);
            this.btn_CancelarIndicadores.Name = "btn_CancelarIndicadores";
            this.btn_CancelarIndicadores.Size = new System.Drawing.Size(160, 33);
            this.btn_CancelarIndicadores.TabIndex = 3;
            this.btn_CancelarIndicadores.Text = "Cancelar";
            this.btn_CancelarIndicadores.UseVisualStyleBackColor = true;
            // 
            // Indicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 429);
            this.Controls.Add(this.btn_CancelarIndicadores);
            this.Controls.Add(this.btn_AlterarIndicadores);
            this.Controls.Add(this.btn_InserirIndicadores);
            this.Controls.Add(this.lst_Indicadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indicadores";
            this.Text = "Indicadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Indicadores;
        private System.Windows.Forms.Button btn_InserirIndicadores;
        private System.Windows.Forms.Button btn_AlterarIndicadores;
        private System.Windows.Forms.Button btn_CancelarIndicadores;
    }
}

