namespace WindowsForms231173_231433
{
    partial class Mercado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.dgvprodutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtalterar = new System.Windows.Forms.TextBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.lblvenda = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Unitário:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(144, 95);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(449, 20);
            this.txtproduto.TabIndex = 4;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(144, 134);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(167, 20);
            this.txtquantidade.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(144, 175);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(167, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // btninserir
            // 
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Location = new System.Drawing.Point(355, 133);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(112, 57);
            this.btninserir.TabIndex = 7;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnremover
            // 
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.Location = new System.Drawing.Point(489, 134);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(104, 56);
            this.btnremover.TabIndex = 8;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // dgvprodutos
            // 
            this.dgvprodutos.AllowUserToAddRows = false;
            this.dgvprodutos.AllowUserToDeleteRows = false;
            this.dgvprodutos.AllowUserToOrderColumns = true;
            this.dgvprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.ValorUnitario});
            this.dgvprodutos.Location = new System.Drawing.Point(44, 223);
            this.dgvprodutos.Name = "dgvprodutos";
            this.dgvprodutos.ReadOnly = true;
            this.dgvprodutos.Size = new System.Drawing.Size(549, 223);
            this.dgvprodutos.TabIndex = 9;
            this.dgvprodutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprodutos_CellClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor Unitário";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alterar Quantidade do Item Selecionado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total da Venda:";
            // 
            // txtalterar
            // 
            this.txtalterar.Location = new System.Drawing.Point(296, 472);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(162, 20);
            this.txtalterar.TabIndex = 12;
            this.txtalterar.TextChanged += new System.EventHandler(this.txtalterar_TextChanged);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(477, 471);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(116, 23);
            this.btnalterar.TabIndex = 13;
            this.btnalterar.Text = "Alterar Quantidade";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngravar.Location = new System.Drawing.Point(83, 581);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(138, 73);
            this.btngravar.TabIndex = 14;
            this.btngravar.Text = "Gravar Venda";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(256, 581);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(137, 73);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar Venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(426, 581);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(127, 73);
            this.btnfinalizar.TabIndex = 16;
            this.btnfinalizar.Text = "Finalizar Venda";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // lblvenda
            // 
            this.lblvenda.AutoSize = true;
            this.lblvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenda.Location = new System.Drawing.Point(140, 47);
            this.lblvenda.Name = "lblvenda";
            this.lblvenda.Size = new System.Drawing.Size(0, 24);
            this.lblvenda.TabIndex = 17;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(157, 521);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 16);
            this.lbltotal.TabIndex = 18;
            // 
            // Mercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 708);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblvenda);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvprodutos);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mercado";
            this.Text = "Mercado";
            this.Load += new System.EventHandler(this.Mercado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView dgvprodutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtalterar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label lblvenda;
        private System.Windows.Forms.Label lbltotal;
    }
}

