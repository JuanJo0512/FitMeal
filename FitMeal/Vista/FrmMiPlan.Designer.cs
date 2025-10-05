namespace FitMeal.Vista
{
    partial class FrmMiPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMiPlan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnIrFeedback = new System.Windows.Forms.Button();
            this.btnIrRegistrarProgreso = new System.Windows.Forms.Button();
            this.btnIrRegistrarPlan = new System.Windows.Forms.Button();
            this.btnIrRegistrarActividad = new System.Windows.Forms.Button();
            this.btnIrRegistrarAlimento = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMiPlan = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proteínas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carbohidratos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarPlan = new System.Windows.Forms.Button();
            this.btnAprobarPlan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMiPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.btnIrFeedback);
            this.panel1.Controls.Add(this.btnIrRegistrarProgreso);
            this.panel1.Controls.Add(this.btnIrRegistrarPlan);
            this.panel1.Controls.Add(this.btnIrRegistrarActividad);
            this.panel1.Controls.Add(this.btnIrRegistrarAlimento);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 631);
            this.panel1.TabIndex = 4;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnPerfil.Location = new System.Drawing.Point(-1, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(286, 155);
            this.btnPerfil.TabIndex = 13;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnIrFeedback
            // 
            this.btnIrFeedback.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIrFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrFeedback.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIrFeedback.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIrFeedback.Location = new System.Drawing.Point(-3, 541);
            this.btnIrFeedback.Name = "btnIrFeedback";
            this.btnIrFeedback.Size = new System.Drawing.Size(289, 76);
            this.btnIrFeedback.TabIndex = 11;
            this.btnIrFeedback.Text = "Calificar Experiencia";
            this.btnIrFeedback.UseVisualStyleBackColor = false;
            this.btnIrFeedback.Click += new System.EventHandler(this.btnIrFeedback_Click);
            // 
            // btnIrRegistrarProgreso
            // 
            this.btnIrRegistrarProgreso.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIrRegistrarProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegistrarProgreso.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIrRegistrarProgreso.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIrRegistrarProgreso.Location = new System.Drawing.Point(0, 442);
            this.btnIrRegistrarProgreso.Name = "btnIrRegistrarProgreso";
            this.btnIrRegistrarProgreso.Size = new System.Drawing.Size(289, 76);
            this.btnIrRegistrarProgreso.TabIndex = 10;
            this.btnIrRegistrarProgreso.Text = "Mi Progreso";
            this.btnIrRegistrarProgreso.UseVisualStyleBackColor = false;
            this.btnIrRegistrarProgreso.Click += new System.EventHandler(this.btnIrRegistrarProgreso_Click);
            // 
            // btnIrRegistrarPlan
            // 
            this.btnIrRegistrarPlan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIrRegistrarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegistrarPlan.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIrRegistrarPlan.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIrRegistrarPlan.Location = new System.Drawing.Point(-3, 344);
            this.btnIrRegistrarPlan.Name = "btnIrRegistrarPlan";
            this.btnIrRegistrarPlan.Size = new System.Drawing.Size(289, 76);
            this.btnIrRegistrarPlan.TabIndex = 9;
            this.btnIrRegistrarPlan.Text = "Mi Plan";
            this.btnIrRegistrarPlan.UseVisualStyleBackColor = false;
            this.btnIrRegistrarPlan.Click += new System.EventHandler(this.btnIrRegistrarPlan_Click);
            // 
            // btnIrRegistrarActividad
            // 
            this.btnIrRegistrarActividad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIrRegistrarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegistrarActividad.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIrRegistrarActividad.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIrRegistrarActividad.Location = new System.Drawing.Point(-4, 252);
            this.btnIrRegistrarActividad.Name = "btnIrRegistrarActividad";
            this.btnIrRegistrarActividad.Size = new System.Drawing.Size(293, 76);
            this.btnIrRegistrarActividad.TabIndex = 7;
            this.btnIrRegistrarActividad.Text = "Registrar Actividad";
            this.btnIrRegistrarActividad.UseVisualStyleBackColor = false;
            this.btnIrRegistrarActividad.Click += new System.EventHandler(this.btnIrRegistrarActividad_Click);
            // 
            // btnIrRegistrarAlimento
            // 
            this.btnIrRegistrarAlimento.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIrRegistrarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrRegistrarAlimento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIrRegistrarAlimento.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIrRegistrarAlimento.Location = new System.Drawing.Point(0, 161);
            this.btnIrRegistrarAlimento.Name = "btnIrRegistrarAlimento";
            this.btnIrRegistrarAlimento.Size = new System.Drawing.Size(286, 76);
            this.btnIrRegistrarAlimento.TabIndex = 6;
            this.btnIrRegistrarAlimento.Text = "Registrar Alimento";
            this.btnIrRegistrarAlimento.UseVisualStyleBackColor = false;
            this.btnIrRegistrarAlimento.Click += new System.EventHandler(this.btnIrRegistrarAlimento_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Location = new System.Drawing.Point(1, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 10);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(464, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mi Plan";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblNombre.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNombre.Location = new System.Drawing.Point(461, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(185, 36);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre aqui";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Todos",
            "Desayuno",
            "Almuerzo",
            "Cena",
            "Snack"});
            this.cmbCategoria.Location = new System.Drawing.Point(615, 166);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(307, 24);
            this.cmbCategoria.TabIndex = 34;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(342, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Elige el momento del dia";
            // 
            // dtgMiPlan
            // 
<<<<<<< HEAD
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comida,
            this.totCal,
            this.totCarb,
            this.totProt});
            this.dataGridView1.Location = new System.Drawing.Point(346, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 354);
            this.dataGridView1.TabIndex = 36;
=======
            this.dtgMiPlan.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgMiPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMiPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMiPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMiPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.TipodeComida,
            this.NombreReceta,
            this.Calorias,
            this.Proteínas,
            this.Carbohidratos});
            this.dtgMiPlan.Location = new System.Drawing.Point(346, 196);
            this.dtgMiPlan.Name = "dtgMiPlan";
            this.dtgMiPlan.RowHeadersWidth = 51;
            this.dtgMiPlan.RowTemplate.Height = 24;
            this.dtgMiPlan.Size = new System.Drawing.Size(716, 354);
            this.dtgMiPlan.TabIndex = 36;
            this.dtgMiPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMiPlan_CellDoubleClick);
>>>>>>> 8abe2bac9927a815135406c39f81ab8fb01a9557
            // 
            // Dia
            // 
<<<<<<< HEAD
            this.comida.HeaderText = "Comida";
            this.comida.MinimumWidth = 6;
            this.comida.Name = "comida";
            this.comida.ReadOnly = true;
            this.comida.Width = 185;
=======
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 6;
            this.Dia.Name = "Dia";
            this.Dia.Width = 125;
>>>>>>> 8abe2bac9927a815135406c39f81ab8fb01a9557
            // 
            // TipodeComida
            // 
<<<<<<< HEAD
            this.totCal.HeaderText = "Calorias";
            this.totCal.MinimumWidth = 6;
            this.totCal.Name = "totCal";
            this.totCal.ReadOnly = true;
            this.totCal.Width = 125;
=======
            this.TipodeComida.HeaderText = "Tipo de Comida";
            this.TipodeComida.MinimumWidth = 6;
            this.TipodeComida.Name = "TipodeComida";
            this.TipodeComida.Width = 125;
>>>>>>> 8abe2bac9927a815135406c39f81ab8fb01a9557
            // 
            // NombreReceta
            // 
<<<<<<< HEAD
            this.totCarb.HeaderText = "Carbohidratos";
            this.totCarb.MinimumWidth = 6;
            this.totCarb.Name = "totCarb";
            this.totCarb.ReadOnly = true;
            this.totCarb.Width = 125;
=======
            this.NombreReceta.HeaderText = "Nombre de Receta";
            this.NombreReceta.MinimumWidth = 6;
            this.NombreReceta.Name = "NombreReceta";
            this.NombreReceta.Width = 125;
>>>>>>> 8abe2bac9927a815135406c39f81ab8fb01a9557
            // 
            // Calorias
            // 
<<<<<<< HEAD
            this.totProt.HeaderText = "Proteinas";
            this.totProt.MinimumWidth = 6;
            this.totProt.Name = "totProt";
            this.totProt.ReadOnly = true;
            this.totProt.Width = 125;
=======
            this.Calorias.HeaderText = "Calorias";
            this.Calorias.MinimumWidth = 6;
            this.Calorias.Name = "Calorias";
            this.Calorias.Width = 125;
>>>>>>> 8abe2bac9927a815135406c39f81ab8fb01a9557
            // 
            // Proteínas
            // 
            this.Proteínas.HeaderText = "Proteínas";
            this.Proteínas.MinimumWidth = 6;
            this.Proteínas.Name = "Proteínas";
            this.Proteínas.Width = 125;
            // 
            // Carbohidratos
            // 
            this.Carbohidratos.HeaderText = "Carbohidratos";
            this.Carbohidratos.MinimumWidth = 6;
            this.Carbohidratos.Name = "Carbohidratos";
            this.Carbohidratos.Width = 125;
            // 
            // btnGenerarPlan
            // 
            this.btnGenerarPlan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnGenerarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPlan.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGenerarPlan.Location = new System.Drawing.Point(346, 564);
            this.btnGenerarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarPlan.Name = "btnGenerarPlan";
            this.btnGenerarPlan.Size = new System.Drawing.Size(152, 58);
            this.btnGenerarPlan.TabIndex = 54;
            this.btnGenerarPlan.Text = "Generar Plan";
            this.btnGenerarPlan.UseVisualStyleBackColor = false;
            this.btnGenerarPlan.Click += new System.EventHandler(this.btnGenerarPlan_Click);
            // 
            // btnAprobarPlan
            // 
            this.btnAprobarPlan.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAprobarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarPlan.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAprobarPlan.Location = new System.Drawing.Point(825, 560);
            this.btnAprobarPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAprobarPlan.Name = "btnAprobarPlan";
            this.btnAprobarPlan.Size = new System.Drawing.Size(152, 58);
            this.btnAprobarPlan.TabIndex = 55;
            this.btnAprobarPlan.Text = "Aprovar Plan";
            this.btnAprobarPlan.UseVisualStyleBackColor = false;
            this.btnAprobarPlan.Click += new System.EventHandler(this.btnAprobarPlan_Click);
            // 
            // FrmMiPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1085, 633);
            this.Controls.Add(this.btnAprobarPlan);
            this.Controls.Add(this.btnGenerarPlan);
            this.Controls.Add(this.dtgMiPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMiPlan";
            this.Text = "FrmMiPlan";
            this.Load += new System.EventHandler(this.FrmMiPlan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMiPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnIrFeedback;
        private System.Windows.Forms.Button btnIrRegistrarProgreso;
        private System.Windows.Forms.Button btnIrRegistrarPlan;
        private System.Windows.Forms.Button btnIrRegistrarActividad;
        private System.Windows.Forms.Button btnIrRegistrarAlimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMiPlan;
        private System.Windows.Forms.Button btnGenerarPlan;
        private System.Windows.Forms.Button btnAprobarPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proteínas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carbohidratos;
    }
}