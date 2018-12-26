namespace PROJETOK
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
            this.grd_funcionarios = new System.Windows.Forms.DataGridView();
            this.bt_adicionaFuncionario = new System.Windows.Forms.Button();
            this.bt_alterarFuncionario = new System.Windows.Forms.Button();
            this.txt_Insert_Nome_Fun = new System.Windows.Forms.TextBox();
            this.txt_num_funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_funcionarios
            // 
            this.grd_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_funcionarios.Location = new System.Drawing.Point(12, 146);
            this.grd_funcionarios.Name = "grd_funcionarios";
            this.grd_funcionarios.Size = new System.Drawing.Size(354, 292);
            this.grd_funcionarios.TabIndex = 0;
            this.grd_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_funcionarios_CellDoubleClick);
            // 
            // bt_adicionaFuncionario
            // 
            this.bt_adicionaFuncionario.Location = new System.Drawing.Point(12, 17);
            this.bt_adicionaFuncionario.Name = "bt_adicionaFuncionario";
            this.bt_adicionaFuncionario.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionaFuncionario.TabIndex = 1;
            this.bt_adicionaFuncionario.Text = "Adicionar";
            this.bt_adicionaFuncionario.UseVisualStyleBackColor = true;
            this.bt_adicionaFuncionario.Click += new System.EventHandler(this.bt_adicionaFuncionario_Click_1);
            // 
            // bt_alterarFuncionario
            // 
            this.bt_alterarFuncionario.Location = new System.Drawing.Point(130, 17);
            this.bt_alterarFuncionario.Name = "bt_alterarFuncionario";
            this.bt_alterarFuncionario.Size = new System.Drawing.Size(83, 23);
            this.bt_alterarFuncionario.TabIndex = 2;
            this.bt_alterarFuncionario.Text = "Editar";
            this.bt_alterarFuncionario.UseVisualStyleBackColor = true;
            this.bt_alterarFuncionario.Click += new System.EventHandler(this.bt_alterarFuncionario_Click_1);
            // 
            // txt_Insert_Nome_Fun
            // 
            this.txt_Insert_Nome_Fun.Location = new System.Drawing.Point(53, 78);
            this.txt_Insert_Nome_Fun.Name = "txt_Insert_Nome_Fun";
            this.txt_Insert_Nome_Fun.Size = new System.Drawing.Size(242, 20);
            this.txt_Insert_Nome_Fun.TabIndex = 4;
            // 
            // txt_num_funcionario
            // 
            this.txt_num_funcionario.Location = new System.Drawing.Point(67, 114);
            this.txt_num_funcionario.Name = "txt_num_funcionario";
            this.txt_num_funcionario.Size = new System.Drawing.Size(100, 20);
            this.txt_num_funcionario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Click 2 vezes para selecionar linha";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num_funcionario);
            this.Controls.Add(this.txt_Insert_Nome_Fun);
            this.Controls.Add(this.bt_alterarFuncionario);
            this.Controls.Add(this.bt_adicionaFuncionario);
            this.Controls.Add(this.grd_funcionarios);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.grd_funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_funcionarios;
        private System.Windows.Forms.Button bt_adicionaFuncionario;
        private System.Windows.Forms.Button bt_alterarFuncionario;
        private System.Windows.Forms.TextBox txt_Insert_Nome_Fun;
        private System.Windows.Forms.TextBox txt_num_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}