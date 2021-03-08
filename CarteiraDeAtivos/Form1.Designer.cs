namespace CarteiraDeAtivos
{
    partial class CarteiraDeAtivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.botaoComprar = new System.Windows.Forms.Button();
            this.botaoVender = new System.Windows.Forms.Button();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.tbAtivo = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoComprar
            // 
            this.botaoComprar.BackColor = System.Drawing.Color.Green;
            this.botaoComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoComprar.Location = new System.Drawing.Point(597, 68);
            this.botaoComprar.Name = "botaoComprar";
            this.botaoComprar.Size = new System.Drawing.Size(138, 49);
            this.botaoComprar.TabIndex = 0;
            this.botaoComprar.Text = "Comprar";
            this.botaoComprar.UseVisualStyleBackColor = false;
            this.botaoComprar.Click += new System.EventHandler(this.botaoComprar_Click);
            // 
            // botaoVender
            // 
            this.botaoVender.BackColor = System.Drawing.Color.Firebrick;
            this.botaoVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVender.Location = new System.Drawing.Point(597, 123);
            this.botaoVender.Name = "botaoVender";
            this.botaoVender.Size = new System.Drawing.Size(138, 49);
            this.botaoVender.TabIndex = 1;
            this.botaoVender.Text = "Vender";
            this.botaoVender.UseVisualStyleBackColor = false;
            this.botaoVender.Click += new System.EventHandler(this.botaoVender_Click);
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.Location = new System.Drawing.Point(741, 68);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(138, 49);
            this.botaoAtualizar.TabIndex = 2;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = false;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botaoDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeletar.Location = new System.Drawing.Point(741, 123);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(138, 49);
            this.botaoDeletar.TabIndex = 3;
            this.botaoDeletar.Text = "Deletar";
            this.botaoDeletar.UseVisualStyleBackColor = false;
            this.botaoDeletar.Click += new System.EventHandler(this.botaoDeletar_Click);
            // 
            // tbAtivo
            // 
            this.tbAtivo.Location = new System.Drawing.Point(75, 123);
            this.tbAtivo.Name = "tbAtivo";
            this.tbAtivo.Size = new System.Drawing.Size(86, 26);
            this.tbAtivo.TabIndex = 4;
            this.tbAtivo.TextChanged += new System.EventHandler(this.tbAtivo_TextChanged);
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(188, 123);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(88, 26);
            this.tbQuantidade.TabIndex = 5;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(304, 123);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(138, 26);
            this.tbValor.TabIndex = 6;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(473, 123);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(101, 26);
            this.tbData.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor da Operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(801, 46);
            this.label5.TabIndex = 13;
            this.label5.Text = "Controle de Operações Carteira de Ativos";
            // 
            // Lista
            // 
            this.Lista.AllowUserToResizeColumns = false;
            this.Lista.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAtivo,
            this.ColumnQuantidade,
            this.ColumnValor,
            this.ColumnData});
            this.Lista.GridColor = System.Drawing.Color.LightGray;
            this.Lista.Location = new System.Drawing.Point(12, 186);
            this.Lista.Name = "Lista";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Lista.RowHeadersVisible = false;
            this.Lista.RowHeadersWidth = 62;
            this.Lista.RowTemplate.Height = 28;
            this.Lista.Size = new System.Drawing.Size(874, 632);
            this.Lista.TabIndex = 14;
            this.Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_CellContentClick);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(13, 123);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(42, 26);
            this.tbID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.Width = 30;
            // 
            // ColumnAtivo
            // 
            this.ColumnAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnAtivo.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnAtivo.Frozen = true;
            this.ColumnAtivo.HeaderText = "Ativo";
            this.ColumnAtivo.MinimumWidth = 100;
            this.ColumnAtivo.Name = "ColumnAtivo";
            this.ColumnAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnQuantidade.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnQuantidade.Frozen = true;
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.MinimumWidth = 150;
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            this.ColumnQuantidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnQuantidade.Width = 150;
            // 
            // ColumnValor
            // 
            this.ColumnValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnValor.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnValor.Frozen = true;
            this.ColumnValor.HeaderText = "Valor da Operação";
            this.ColumnValor.MinimumWidth = 150;
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnValor.Width = 150;
            // 
            // ColumnData
            // 
            this.ColumnData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnData.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColumnData.Frozen = true;
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.MinimumWidth = 150;
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnData.Width = 150;
            // 
            // CarteiraDeAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 794);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.tbAtivo);
            this.Controls.Add(this.botaoDeletar);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.botaoVender);
            this.Controls.Add(this.botaoComprar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 850);
            this.MinimumSize = new System.Drawing.Size(920, 850);
            this.Name = "CarteiraDeAtivos";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carteira de Ativos";
            this.Load += new System.EventHandler(this.CarteiraDeAtivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoComprar;
        private System.Windows.Forms.Button botaoVender;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.Button botaoDeletar;
        private System.Windows.Forms.TextBox tbAtivo;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
    }
}

