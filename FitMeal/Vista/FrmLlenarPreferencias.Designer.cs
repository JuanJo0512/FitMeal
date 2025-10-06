namespace FitMeal.Vista
{
    partial class FrmLlenarPreferencias
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
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtgAlimentos = new System.Windows.Forms.DataGridView();
            this.nombreAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluirAlimento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBuscarAlergia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgAlergias = new System.Windows.Forms.DataGridView();
            this.nombreAlergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlergiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAlergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAlergia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblAlergias = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarAlimento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlergias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.AutoSize = true;
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentos.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAlimentos.Location = new System.Drawing.Point(13, 127);
            this.lblAlimentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(504, 44);
            this.lblAlimentos.TabIndex = 25;
            this.lblAlimentos.Text = "Ahora por favor, indicamos que alimentos preferirias no comer\r\nLos veras lo menos" +
    " posible en tu plan de comidas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitulo.Location = new System.Drawing.Point(8, 52);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 51);
            this.lblTitulo.TabIndex = 45;
            this.lblTitulo.Text = "Casi Acabamos!";
            // 
            // dtgAlimentos
            // 
            this.dtgAlimentos.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgAlimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreAlimento,
            this.AlimentoID,
            this.categoriaAlimento,
            this.excluirAlimento});
            this.dtgAlimentos.GridColor = System.Drawing.Color.Cornsilk;
            this.dtgAlimentos.Location = new System.Drawing.Point(17, 235);
            this.dtgAlimentos.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtgAlimentos.Name = "dtgAlimentos";
            this.dtgAlimentos.RowHeadersWidth = 51;
            this.dtgAlimentos.RowTemplate.Height = 24;
            this.dtgAlimentos.Size = new System.Drawing.Size(759, 239);
            this.dtgAlimentos.TabIndex = 46;
            // 
            // nombreAlimento
            // 
            this.nombreAlimento.HeaderText = "Nombre";
            this.nombreAlimento.MinimumWidth = 6;
            this.nombreAlimento.Name = "nombreAlimento";
            this.nombreAlimento.Width = 125;
            // 
            // AlimentoID
            // 
            this.AlimentoID.HeaderText = "ID";
            this.AlimentoID.MinimumWidth = 6;
            this.AlimentoID.Name = "AlimentoID";
            this.AlimentoID.Visible = false;
            this.AlimentoID.Width = 125;
            // 
            // categoriaAlimento
            // 
            this.categoriaAlimento.HeaderText = "Categoria";
            this.categoriaAlimento.MinimumWidth = 6;
            this.categoriaAlimento.Name = "categoriaAlimento";
            this.categoriaAlimento.Width = 125;
            // 
            // excluirAlimento
            // 
            this.excluirAlimento.HeaderText = "Excluir Alimento";
            this.excluirAlimento.MinimumWidth = 6;
            this.excluirAlimento.Name = "excluirAlimento";
            this.excluirAlimento.Width = 125;
            // 
            // txtBuscarAlergia
            // 
            this.txtBuscarAlergia.Location = new System.Drawing.Point(125, 573);
            this.txtBuscarAlergia.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBuscarAlergia.Name = "txtBuscarAlergia";
            this.txtBuscarAlergia.Size = new System.Drawing.Size(463, 22);
            this.txtBuscarAlergia.TabIndex = 52;
            this.txtBuscarAlergia.TextChanged += new System.EventHandler(this.txtBuscarAlergia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(13, 571);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Buscar: ";
            // 
            // dtgAlergias
            // 
            this.dtgAlergias.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAlergias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlergias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreAlergia,
            this.AlergiaID,
            this.descripcionAlergia,
            this.checkAlergia});
            this.dtgAlergias.GridColor = System.Drawing.Color.Cornsilk;
            this.dtgAlergias.Location = new System.Drawing.Point(17, 628);
            this.dtgAlergias.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtgAlergias.Name = "dtgAlergias";
            this.dtgAlergias.RowHeadersWidth = 51;
            this.dtgAlergias.RowTemplate.Height = 24;
            this.dtgAlergias.Size = new System.Drawing.Size(759, 239);
            this.dtgAlergias.TabIndex = 50;
            // 
            // nombreAlergia
            // 
            this.nombreAlergia.HeaderText = "Alergia";
            this.nombreAlergia.MinimumWidth = 6;
            this.nombreAlergia.Name = "nombreAlergia";
            this.nombreAlergia.Width = 125;
            // 
            // AlergiaID
            // 
            this.AlergiaID.HeaderText = "ID";
            this.AlergiaID.MinimumWidth = 6;
            this.AlergiaID.Name = "AlergiaID";
            this.AlergiaID.Visible = false;
            this.AlergiaID.Width = 125;
            // 
            // descripcionAlergia
            // 
            this.descripcionAlergia.HeaderText = "Descripción";
            this.descripcionAlergia.MinimumWidth = 6;
            this.descripcionAlergia.Name = "descripcionAlergia";
            this.descripcionAlergia.Width = 125;
            // 
            // checkAlergia
            // 
            this.checkAlergia.HeaderText = "Incluir Alergia";
            this.checkAlergia.MinimumWidth = 6;
            this.checkAlergia.Name = "checkAlergia";
            this.checkAlergia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkAlergia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkAlergia.Width = 125;
            // 
            // lblAlergias
            // 
            this.lblAlergias.AutoSize = true;
            this.lblAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlergias.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAlergias.Location = new System.Drawing.Point(13, 495);
            this.lblAlergias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlergias.Name = "lblAlergias";
            this.lblAlergias.Size = new System.Drawing.Size(549, 44);
            this.lblAlergias.TabIndex = 49;
            this.lblAlergias.Text = "Incluye tus alergias/intolerancias a continuacion\r\nLos alimentos que se excluyen " +
    "con estas NO apareceran en tu plan";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnguardar.Location = new System.Drawing.Point(817, 835);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(235, 86);
            this.btnguardar.TabIndex = 53;
            this.btnguardar.Text = "Guardar y finalizar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;

            this.label2.Location = new System.Drawing.Point(13, 183);

            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Buscar: ";
            // 
            // txtBuscarAlimento
            // 

            this.txtBuscarAlimento.Location = new System.Drawing.Point(112, 185);

            this.txtBuscarAlimento.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBuscarAlimento.Name = "txtBuscarAlimento";
            this.txtBuscarAlimento.Size = new System.Drawing.Size(463, 22);
            this.txtBuscarAlimento.TabIndex = 48;
            this.txtBuscarAlimento.TextChanged += new System.EventHandler(this.txtBuscarAlimento_TextChanged);
            // 
            // FrmLlenarPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1083, 956);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtBuscarAlergia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgAlergias);
            this.Controls.Add(this.lblAlergias);
            this.Controls.Add(this.txtBuscarAlimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgAlimentos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAlimentos);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmLlenarPreferencias";
            this.Text = "                 ";
            this.Load += new System.EventHandler(this.LlenarPreferencias);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlergias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dtgAlimentos;
        private System.Windows.Forms.TextBox txtBuscarAlergia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgAlergias;
        private System.Windows.Forms.Label lblAlergias;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaAlimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluirAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlergiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAlergia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkAlergia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarAlimento;
    }
}