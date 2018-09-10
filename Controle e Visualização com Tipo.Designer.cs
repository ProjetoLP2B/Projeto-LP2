namespace Projeto_LP2
{
    partial class Controle_e_Visualização_com_Tipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controle_e_Visualização_com_Tipo));
            this.lstViewControleTipo = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DESCRIÇÃO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_RelacaoControlView = new System.Windows.Forms.Button();
            this.btn_EditarControlView = new System.Windows.Forms.Button();
            this.btn_AddControlView = new System.Windows.Forms.Button();
            this.btn_DeletarControlView = new System.Windows.Forms.Button();
            this.TIPO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstViewControleTipo
            // 
            this.lstViewControleTipo.BackColor = System.Drawing.Color.White;
            this.lstViewControleTipo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NOME,
            this.DESCRIÇÃO,
            this.TIPO});
            this.lstViewControleTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewControleTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstViewControleTipo.GridLines = true;
            this.lstViewControleTipo.Location = new System.Drawing.Point(12, 12);
            this.lstViewControleTipo.Name = "lstViewControleTipo";
            this.lstViewControleTipo.Size = new System.Drawing.Size(438, 249);
            this.lstViewControleTipo.TabIndex = 1;
            this.lstViewControleTipo.UseCompatibleStateImageBehavior = false;
            this.lstViewControleTipo.View = System.Windows.Forms.View.Details;
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 34;
            // 
            // NOME
            // 
            this.NOME.Text = "NOME";
            this.NOME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NOME.Width = 125;
            // 
            // DESCRIÇÃO
            // 
            this.DESCRIÇÃO.DisplayIndex = 3;
            this.DESCRIÇÃO.Text = "DESCRIÇÃO";
            this.DESCRIÇÃO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DESCRIÇÃO.Width = 210;
            // 
            // btn_RelacaoControlView
            // 
            this.btn_RelacaoControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RelacaoControlView.Location = new System.Drawing.Point(345, 282);
            this.btn_RelacaoControlView.Name = "btn_RelacaoControlView";
            this.btn_RelacaoControlView.Size = new System.Drawing.Size(105, 35);
            this.btn_RelacaoControlView.TabIndex = 38;
            this.btn_RelacaoControlView.Text = "Relação";
            this.btn_RelacaoControlView.UseVisualStyleBackColor = true;
            // 
            // btn_EditarControlView
            // 
            this.btn_EditarControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarControlView.Location = new System.Drawing.Point(234, 282);
            this.btn_EditarControlView.Name = "btn_EditarControlView";
            this.btn_EditarControlView.Size = new System.Drawing.Size(105, 35);
            this.btn_EditarControlView.TabIndex = 37;
            this.btn_EditarControlView.Text = "Editar";
            this.btn_EditarControlView.UseVisualStyleBackColor = true;
            // 
            // btn_AddControlView
            // 
            this.btn_AddControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddControlView.Location = new System.Drawing.Point(12, 282);
            this.btn_AddControlView.Name = "btn_AddControlView";
            this.btn_AddControlView.Size = new System.Drawing.Size(105, 35);
            this.btn_AddControlView.TabIndex = 36;
            this.btn_AddControlView.Text = "Adicionar";
            this.btn_AddControlView.UseVisualStyleBackColor = true;
            // 
            // btn_DeletarControlView
            // 
            this.btn_DeletarControlView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeletarControlView.Location = new System.Drawing.Point(123, 282);
            this.btn_DeletarControlView.Name = "btn_DeletarControlView";
            this.btn_DeletarControlView.Size = new System.Drawing.Size(105, 35);
            this.btn_DeletarControlView.TabIndex = 35;
            this.btn_DeletarControlView.Text = "Deletar";
            this.btn_DeletarControlView.UseVisualStyleBackColor = true;
            // 
            // TIPO
            // 
            this.TIPO.DisplayIndex = 2;
            this.TIPO.Text = "TIPO";
            this.TIPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TIPO.Width = 65;
            // 
            // Controle_e_Visualização_com_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 329);
            this.Controls.Add(this.btn_RelacaoControlView);
            this.Controls.Add(this.btn_EditarControlView);
            this.Controls.Add(this.btn_AddControlView);
            this.Controls.Add(this.btn_DeletarControlView);
            this.Controls.Add(this.lstViewControleTipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controle_e_Visualização_com_Tipo";
            this.Text = "Controle e Visualização Tipo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewControleTipo;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOME;
        private System.Windows.Forms.ColumnHeader DESCRIÇÃO;
        private System.Windows.Forms.ColumnHeader TIPO;
        private System.Windows.Forms.Button btn_RelacaoControlView;
        private System.Windows.Forms.Button btn_EditarControlView;
        private System.Windows.Forms.Button btn_AddControlView;
        private System.Windows.Forms.Button btn_DeletarControlView;
    }
}