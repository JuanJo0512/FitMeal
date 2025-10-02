namespace FitMeal.Vista
{
    partial class FrmGestionarRecetas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtTotalProteinas = new System.Windows.Forms.TextBox();
            this.txtTipo2 = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTotalCalorias = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalCarbohidratos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgAlimentos = new System.Windows.Forms.DataGridView();
            this.nombreAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluirAlimento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnVolver.Location = new System.Drawing.Point(2, 765);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(170, 44);
            this.btnVolver.TabIndex = 69;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAñadir.Location = new System.Drawing.Point(209, 765);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(170, 44);
            this.btnAñadir.TabIndex = 68;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnModificar.Location = new System.Drawing.Point(412, 765);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 44);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEliminar.Location = new System.Drawing.Point(601, 765);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 44);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Cornsilk;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label13.Location = new System.Drawing.Point(27, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(314, 22);
            this.label13.TabIndex = 65;
            this.label13.Text = "Rellena los sigueintes datos de receta";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Cena",
            "Snack"});
            this.cmbCategoria.Location = new System.Drawing.Point(153, 220);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(188, 24);
            this.cmbCategoria.TabIndex = 64;
            // 
            // txtTotalProteinas
            // 
            this.txtTotalProteinas.Location = new System.Drawing.Point(233, 430);
            this.txtTotalProteinas.Name = "txtTotalProteinas";
            this.txtTotalProteinas.Size = new System.Drawing.Size(231, 22);
            this.txtTotalProteinas.TabIndex = 63;
            // 
            // txtTipo2
            // 
            this.txtTipo2.Location = new System.Drawing.Point(282, 323);
            this.txtTipo2.Name = "txtTipo2";
            this.txtTipo2.Size = new System.Drawing.Size(231, 22);
            this.txtTipo2.TabIndex = 62;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(110, 271);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(231, 22);
            this.txtTipo.TabIndex = 61;
            // 
            // txtTotalCalorias
            // 
            this.txtTotalCalorias.Location = new System.Drawing.Point(224, 383);
            this.txtTotalCalorias.Name = "txtTotalCalorias";
            this.txtTotalCalorias.Size = new System.Drawing.Size(197, 22);
            this.txtTotalCalorias.TabIndex = 60;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 161);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 22);
            this.txtNombre.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(26, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 30);
            this.label9.TabIndex = 58;
            this.label9.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(26, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "Total Calorias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(26, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 30);
            this.label7.TabIndex = 56;
            this.label7.Text = "Total Carbohidratos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(26, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 30);
            this.label8.TabIndex = 55;
            this.label8.Text = "Otro Tipo(opcional):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(26, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 30);
            this.label5.TabIndex = 54;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 51);
            this.label1.TabIndex = 52;
            this.label1.Text = "Gestion de Recetas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(26, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 70;
            this.label2.Text = "Total Proteinas:";
            // 
            // txtTotalCarbohidratos
            // 
            this.txtTotalCarbohidratos.Location = new System.Drawing.Point(298, 485);
            this.txtTotalCarbohidratos.Name = "txtTotalCarbohidratos";
            this.txtTotalCarbohidratos.Size = new System.Drawing.Size(231, 22);
            this.txtTotalCarbohidratos.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(26, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(653, 30);
            this.label3.TabIndex = 72;
            this.label3.Text = "seleccione los alimentos que se usan para esta receta:";
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
            this.dtgAlimentos.Location = new System.Drawing.Point(31, 561);
            this.dtgAlimentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgAlimentos.Name = "dtgAlimentos";
            this.dtgAlimentos.RowHeadersWidth = 51;
            this.dtgAlimentos.RowTemplate.Height = 24;
            this.dtgAlimentos.Size = new System.Drawing.Size(569, 194);
            this.dtgAlimentos.TabIndex = 73;
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
            // FrmGestionarRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(793, 837);
            this.Controls.Add(this.dtgAlimentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalCarbohidratos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtTotalProteinas);
            this.Controls.Add(this.txtTipo2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtTotalCalorias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionarRecetas";
            this.Text = "FrmGestionarRecetas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtTotalProteinas;
        private System.Windows.Forms.TextBox txtTipo2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTotalCalorias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalCarbohidratos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgAlimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaAlimento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excluirAlimento;
    }
}