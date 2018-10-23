namespace Projeto_LP2
{
    partial class Novos_Projetos
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_NomeProjNovoProj = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Propriedade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removerPropriedade = new System.Windows.Forms.Button();
            this.btn_NP_Voltar = new System.Windows.Forms.Button();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Propriedades";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(338, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Selecionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(338, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exibir Relatorio";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.exibirRelatorio_Click);
            // 
            // txt_NomeProjNovoProj
            // 
            this.txt_NomeProjNovoProj.Location = new System.Drawing.Point(77, 63);
            this.txt_NomeProjNovoProj.Name = "txt_NomeProjNovoProj";
            this.txt_NomeProjNovoProj.Size = new System.Drawing.Size(235, 20);
            this.txt_NomeProjNovoProj.TabIndex = 7;
            this.txt_NomeProjNovoProj.TextChanged += new System.EventHandler(this.txt_NomeProjNovoProj_TextChanged);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "GPS",
            "Threads",
            "Banco de dados"});
            this.comboBox.Location = new System.Drawing.Point(76, 137);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(235, 21);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.cmbNovaSelecao);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Propriedade,
            this.Nome});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(76, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 205);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 36;
            // 
            // Propriedade
            // 
            this.Propriedade.Text = "Propriedade";
            this.Propriedade.Width = 100;
            // 
            // removerPropriedade
            // 
            this.removerPropriedade.Location = new System.Drawing.Point(338, 194);
            this.removerPropriedade.Name = "removerPropriedade";
            this.removerPropriedade.Size = new System.Drawing.Size(75, 23);
            this.removerPropriedade.TabIndex = 12;
            this.removerPropriedade.Text = "Remover";
            this.removerPropriedade.UseVisualStyleBackColor = true;
            this.removerPropriedade.Click += new System.EventHandler(this.remover_click);
            // 
            // btn_NP_Voltar
            // 
            this.btn_NP_Voltar.Location = new System.Drawing.Point(482, 373);
            this.btn_NP_Voltar.Name = "btn_NP_Voltar";
            this.btn_NP_Voltar.Size = new System.Drawing.Size(63, 23);
            this.btn_NP_Voltar.TabIndex = 13;
            this.btn_NP_Voltar.Text = "Voltar";
            this.btn_NP_Voltar.UseVisualStyleBackColor = true;
            this.btn_NP_Voltar.Click += new System.EventHandler(this.btn_NP_Voltar_Click);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Novos_Projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 424);
            this.Controls.Add(this.btn_NP_Voltar);
            this.Controls.Add(this.removerPropriedade);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txt_NomeProjNovoProj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Novos_Projetos";
            this.Text = "Novos_Projetos";
            this.Load += new System.EventHandler(this.Novos_Projetos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_NomeProjNovoProj;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Propriedade;
        private System.Windows.Forms.Button removerPropriedade;
        private System.Windows.Forms.Button btn_NP_Voltar;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}