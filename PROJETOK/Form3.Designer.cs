namespace PROJETOK
{
    partial class Form3
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
            this.grd_clientes = new System.Windows.Forms.DataGridView();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.txt_nomeCliente = new System.Windows.Forms.TextBox();
            this.txt_nomeCidade = new System.Windows.Forms.TextBox();
            this.txt_nomePais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_clientes
            // 
            this.grd_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_clientes.Location = new System.Drawing.Point(12, 215);
            this.grd_clientes.Name = "grd_clientes";
            this.grd_clientes.Size = new System.Drawing.Size(411, 223);
            this.grd_clientes.TabIndex = 0;
            this.grd_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_clientes_CellDoubleClick);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(22, 25);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_adicionar.TabIndex = 1;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(160, 25);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 23);
            this.bt_editar.TabIndex = 2;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // txt_nomeCliente
            // 
            this.txt_nomeCliente.Location = new System.Drawing.Point(79, 81);
            this.txt_nomeCliente.Name = "txt_nomeCliente";
            this.txt_nomeCliente.Size = new System.Drawing.Size(201, 20);
            this.txt_nomeCliente.TabIndex = 3;
            // 
            // txt_nomeCidade
            // 
            this.txt_nomeCidade.Location = new System.Drawing.Point(79, 116);
            this.txt_nomeCidade.Name = "txt_nomeCidade";
            this.txt_nomeCidade.Size = new System.Drawing.Size(100, 20);
            this.txt_nomeCidade.TabIndex = 4;
            // 
            // txt_nomePais
            // 
            this.txt_nomePais.Location = new System.Drawing.Point(79, 154);
            this.txt_nomePais.Name = "txt_nomePais";
            this.txt_nomePais.Size = new System.Drawing.Size(100, 20);
            this.txt_nomePais.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "País";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Faça duplo click para selecionar";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomePais);
            this.Controls.Add(this.txt_nomeCidade);
            this.Controls.Add(this.txt_nomeCliente);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.grd_clientes);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.grd_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_clientes;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.TextBox txt_nomeCliente;
        private System.Windows.Forms.TextBox txt_nomeCidade;
        private System.Windows.Forms.TextBox txt_nomePais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}