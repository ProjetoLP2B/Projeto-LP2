namespace Projeto_LP2
{
    partial class ItemIndicador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemIndicador));
            this.lst_ItemIndicador = new System.Windows.Forms.ListBox();
            this.btn_CancelarItemIndicadores = new System.Windows.Forms.Button();
            this.btn_AlterarItemIndicadores = new System.Windows.Forms.Button();
            this.btn_InserirItemIndicadores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_ItemIndicador
            // 
            this.lst_ItemIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_ItemIndicador.FormattingEnabled = true;
            this.lst_ItemIndicador.ItemHeight = 18;
            this.lst_ItemIndicador.Location = new System.Drawing.Point(13, 12);
            this.lst_ItemIndicador.Name = "lst_ItemIndicador";
            this.lst_ItemIndicador.Size = new System.Drawing.Size(530, 328);
            this.lst_ItemIndicador.TabIndex = 4;
            // 
            // btn_CancelarItemIndicadores
            // 
            this.btn_CancelarItemIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarItemIndicadores.Location = new System.Drawing.Point(383, 377);
            this.btn_CancelarItemIndicadores.Name = "btn_CancelarItemIndicadores";
            this.btn_CancelarItemIndicadores.Size = new System.Drawing.Size(160, 33);
            this.btn_CancelarItemIndicadores.TabIndex = 7;
            this.btn_CancelarItemIndicadores.Text = "Cancelar";
            this.btn_CancelarItemIndicadores.UseVisualStyleBackColor = true;
            // 
            // btn_AlterarItemIndicadores
            // 
            this.btn_AlterarItemIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarItemIndicadores.Location = new System.Drawing.Point(13, 377);
            this.btn_AlterarItemIndicadores.Name = "btn_AlterarItemIndicadores";
            this.btn_AlterarItemIndicadores.Size = new System.Drawing.Size(158, 33);
            this.btn_AlterarItemIndicadores.TabIndex = 6;
            this.btn_AlterarItemIndicadores.Text = "Alterar";
            this.btn_AlterarItemIndicadores.UseVisualStyleBackColor = true;
            this.btn_AlterarItemIndicadores.Click += new System.EventHandler(this.btn_AlterarItemIndicadores_Click);
            // 
            // btn_InserirItemIndicadores
            // 
            this.btn_InserirItemIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InserirItemIndicadores.Location = new System.Drawing.Point(195, 377);
            this.btn_InserirItemIndicadores.Name = "btn_InserirItemIndicadores";
            this.btn_InserirItemIndicadores.Size = new System.Drawing.Size(160, 33);
            this.btn_InserirItemIndicadores.TabIndex = 5;
            this.btn_InserirItemIndicadores.Text = "Inserir";
            this.btn_InserirItemIndicadores.UseVisualStyleBackColor = true;
            // 
            // ItemIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 429);
            this.Controls.Add(this.btn_CancelarItemIndicadores);
            this.Controls.Add(this.btn_AlterarItemIndicadores);
            this.Controls.Add(this.btn_InserirItemIndicadores);
            this.Controls.Add(this.lst_ItemIndicador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemIndicador";
            this.Text = "Item Indicador";
            this.Load += new System.EventHandler(this.ItemIndicador_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lst_ItemIndicador;
        private System.Windows.Forms.Button btn_CancelarItemIndicadores;
        private System.Windows.Forms.Button btn_AlterarItemIndicadores;
        private System.Windows.Forms.Button btn_InserirItemIndicadores;
    }
}