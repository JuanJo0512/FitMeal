namespace FitMeal.Vista
{
    partial class FrmDetallesReceta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.NombreAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblCarbohidratos = new System.Windows.Forms.Label();
            this.lblProteinas = new System.Windows.Forms.Label();
            this.lblCalorias = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitulo.Location = new System.Drawing.Point(222, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(373, 42);
            this.lblTitulo.TabIndex = 46;
            this.lblTitulo.Text = "Detalles de la Receta";
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.AutoSize = true;
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentos.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAlimentos.Location = new System.Drawing.Point(58, 77);
            this.lblAlimentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(78, 22);
            this.lblAlimentos.TabIndex = 47;
            this.lblAlimentos.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(517, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(517, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(517, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tipo 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(58, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "Total Calorias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(58, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Total Proteinas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(58, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 22);
            this.label7.TabIndex = 54;
            this.label7.Text = "Total Carbohidratos:";
            // 
            // dtgIngredientes
            // 
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlimento,
            this.Cantidad});
            this.dtgIngredientes.Location = new System.Drawing.Point(17, 305);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.RowHeadersWidth = 51;
            this.dtgIngredientes.RowTemplate.Height = 24;
            this.dtgIngredientes.Size = new System.Drawing.Size(493, 333);
            this.dtgIngredientes.TabIndex = 55;
            // 
            // NombreAlimento
            // 
            this.NombreAlimento.HeaderText = "Nombre Alimento";
            this.NombreAlimento.MinimumWidth = 6;
            this.NombreAlimento.Name = "NombreAlimento";
            this.NombreAlimento.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(13, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 22);
            this.label8.TabIndex = 56;
            this.label8.Text = "Ingredientes de la receta:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.OliveDrab;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnVolver.Location = new System.Drawing.Point(599, 562);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 58);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReceta.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNombreReceta.Location = new System.Drawing.Point(154, 77);
            this.lblNombreReceta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(73, 22);
            this.lblNombreReceta.TabIndex = 58;
            this.lblNombreReceta.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 115);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 25);
            this.txtDescripcion.TabIndex = 59;
            this.txtDescripcion.Text = "";
            // 
            // lblCarbohidratos
            // 
            this.lblCarbohidratos.AutoSize = true;
            this.lblCarbohidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbohidratos.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCarbohidratos.Location = new System.Drawing.Point(240, 165);
            this.lblCarbohidratos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarbohidratos.Name = "lblCarbohidratos";
            this.lblCarbohidratos.Size = new System.Drawing.Size(169, 22);
            this.lblCarbohidratos.TabIndex = 60;
            this.lblCarbohidratos.Text = "Total Carbohidratos";
            // 
            // lblProteinas
            // 
            this.lblProteinas.AutoSize = true;
            this.lblProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProteinas.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblProteinas.Location = new System.Drawing.Point(203, 197);
            this.lblProteinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProteinas.Name = "lblProteinas";
            this.lblProteinas.Size = new System.Drawing.Size(132, 22);
            this.lblProteinas.TabIndex = 61;
            this.lblProteinas.Text = "Total Proteinas";
            // 
            // lblCalorias
            // 
            this.lblCalorias.AutoSize = true;
            this.lblCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorias.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCalorias.Location = new System.Drawing.Point(193, 229);
            this.lblCalorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalorias.Name = "lblCalorias";
            this.lblCalorias.Size = new System.Drawing.Size(122, 22);
            this.lblCalorias.TabIndex = 62;
            this.lblCalorias.Text = "Total Calorias";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCategoria.Location = new System.Drawing.Point(618, 77);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(88, 22);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTipo.Location = new System.Drawing.Point(576, 110);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 22);
            this.lblTipo.TabIndex = 65;
            this.lblTipo.Text = "Tipo";
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTipo2.Location = new System.Drawing.Point(591, 146);
            this.lblTipo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(61, 22);
            this.lblTipo2.TabIndex = 66;
            this.lblTipo2.Text = "Tipo 2";
            // 
            // FrmDetallesReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(844, 662);
            this.Controls.Add(this.lblTipo2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCalorias);
            this.Controls.Add(this.lblProteinas);
            this.Controls.Add(this.lblCarbohidratos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombreReceta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgIngredientes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlimentos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmDetallesReceta";
            this.Text = "FrmDetallesReceta";
            this.Load += new System.EventHandler(this.FrmDetallesReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgIngredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblCarbohidratos;
        private System.Windows.Forms.Label lblProteinas;
        private System.Windows.Forms.Label lblCalorias;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipo2;
    }
}