namespace ComercialSys91
{
    partial class FProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduto));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.Lb_disponível = new System.Windows.Forms.Label();
            this.tb_codbar = new System.Windows.Forms.TextBox();
            this.tb_unidade = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.IDcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriçaocl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidadecl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorcl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codbar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desconto";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(36, 18);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(49, 20);
            this.tb_Id.TabIndex = 7;
            // 
            // Lb_disponível
            // 
            this.Lb_disponível.AutoSize = true;
            this.Lb_disponível.Location = new System.Drawing.Point(215, 187);
            this.Lb_disponível.Name = "Lb_disponível";
            this.Lb_disponível.Size = new System.Drawing.Size(78, 13);
            this.Lb_disponível.TabIndex = 8;
            this.Lb_disponível.Text = "Disponibilidade";
            // 
            // tb_codbar
            // 
            this.tb_codbar.Location = new System.Drawing.Point(161, 18);
            this.tb_codbar.MaxLength = 13;
            this.tb_codbar.Name = "tb_codbar";
            this.tb_codbar.Size = new System.Drawing.Size(238, 20);
            this.tb_codbar.TabIndex = 9;
            // 
            // tb_unidade
            // 
            this.tb_unidade.Location = new System.Drawing.Point(272, 80);
            this.tb_unidade.Name = "tb_unidade";
            this.tb_unidade.Size = new System.Drawing.Size(127, 20);
            this.tb_unidade.TabIndex = 10;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(272, 138);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(127, 20);
            this.tb_valor.TabIndex = 11;
            // 
            // tb_desconto
            // 
            this.tb_desconto.Location = new System.Drawing.Point(92, 184);
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(100, 20);
            this.tb_desconto.TabIndex = 13;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(36, 80);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(207, 78);
            this.tb_descricao.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(299, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.Location = new System.Drawing.Point(36, 230);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(94, 37);
            this.btn_Inserir.TabIndex = 15;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(172, 228);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(94, 39);
            this.btn_consultar.TabIndex = 16;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listar.Location = new System.Drawing.Point(305, 228);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(94, 39);
            this.btn_listar.TabIndex = 17;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcl,
            this.Descriçaocl,
            this.Unidadecl,
            this.Valorcl});
            this.dgv_produtos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_produtos.Location = new System.Drawing.Point(0, 288);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(442, 191);
            this.dgv_produtos.TabIndex = 18;
            this.dgv_produtos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_produtos_CellContentClick);
            // 
            // IDcl
            // 
            this.IDcl.HeaderText = "ID";
            this.IDcl.Name = "IDcl";
            // 
            // Descriçaocl
            // 
            this.Descriçaocl.HeaderText = "Descriçao";
            this.Descriçaocl.Name = "Descriçaocl";
            // 
            // Unidadecl
            // 
            this.Unidadecl.HeaderText = "Unidade";
            this.Unidadecl.Name = "Unidadecl";
            // 
            // Valorcl
            // 
            this.Valorcl.HeaderText = "Valor";
            this.Valorcl.Name = "Valorcl";
            // 
            // FProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 479);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_desconto);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.tb_unidade);
            this.Controls.Add(this.tb_codbar);
            this.Controls.Add(this.Lb_disponível);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label Lb_disponível;
        private System.Windows.Forms.TextBox tb_codbar;
        private System.Windows.Forms.TextBox tb_unidade;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriçaocl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidadecl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valorcl;
    }
}