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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluirAlimento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreAlergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAlergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAlergia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ahora por favor, indicamos que alimentos preferirias no comer\r\nLos veras lo menos" +
    " posible en tu plan de comidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "Casi Acabamos!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreAlimento,
            this.categoriaAlimento,
            this.excluirAlimento});
            this.dataGridView1.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.Location = new System.Drawing.Point(29, 181);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 158);
            this.dataGridView1.TabIndex = 46;
            // 
            // nombreAlimento
            // 
            this.nombreAlimento.HeaderText = "Nombre";
            this.nombreAlimento.MinimumWidth = 6;
            this.nombreAlimento.Name = "nombreAlimento";
            this.nombreAlimento.Width = 125;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Buscar: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 411);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(26, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Buscar: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreAlergia,
            this.descripcionAlergia,
            this.checkAlergia});
            this.dataGridView2.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridView2.Location = new System.Drawing.Point(29, 453);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(427, 158);
            this.dataGridView2.TabIndex = 50;
            // 
            // nombreAlergia
            // 
            this.nombreAlergia.HeaderText = "Alergia";
            this.nombreAlergia.MinimumWidth = 6;
            this.nombreAlergia.Name = "nombreAlergia";
            this.nombreAlergia.Width = 125;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(26, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 36);
            this.label5.TabIndex = 49;
            this.label5.Text = "Por ultimo, incluye tus alergias/intolerancias a continuacion\r\nLos alimentos que " +
    "se excluyen con estas NO apareceran en tu plan";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIngreso.Location = new System.Drawing.Point(460, 587);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(132, 57);
            this.btnIngreso.TabIndex = 53;
            this.btnIngreso.Text = "Guardar y finalizar";
            this.btnIngreso.UseVisualStyleBackColor = false;
            // 
            // FrmLlenarPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(609, 671);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLlenarPreferencias";
            this.Text = "FrmLlenarPreferencias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaAlimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluirAlimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAlergia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkAlergia;
    }
}