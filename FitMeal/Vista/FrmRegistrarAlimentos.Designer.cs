namespace FitMeal.Vista
{
    partial class FrmRegistrarAlimentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIrRegistrarAlimento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnIrFeedback = new System.Windows.Forms.Button();
            this.btnIrRegistrarProgreso = new System.Windows.Forms.Button();
            this.btnIrRegistrarPlan = new System.Windows.Forms.Button();
            this.btnIrRegistrarActividad = new System.Windows.Forms.Button();
            this.txtBuscarReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegistrarAlimento = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TipoComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCalorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProteinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCarbohidratos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAlimento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Location = new System.Drawing.Point(1, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 10);
            this.panel2.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 631);
            this.panel1.TabIndex = 0;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
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
            // txtBuscarReceta
            // 
            this.txtBuscarReceta.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarReceta.Location = new System.Drawing.Point(569, 79);
            this.txtBuscarReceta.Name = "txtBuscarReceta";
            this.txtBuscarReceta.Size = new System.Drawing.Size(336, 35);
            this.txtBuscarReceta.TabIndex = 1;
            this.txtBuscarReceta.TextChanged += new System.EventHandler(this.txtBuscarReceta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(327, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Comida:";
            // 
            // dgvRegistrarAlimento
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegistrarAlimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistrarAlimento.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgvRegistrarAlimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistrarAlimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistrarAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarAlimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoComida,
            this.Nombre,
            this.TotalCalorias,
            this.TotalProteinas,
            this.TotalCarbohidratos,
            this.Selec});
            this.dgvRegistrarAlimento.Location = new System.Drawing.Point(332, 163);
            this.dgvRegistrarAlimento.MultiSelect = false;
            this.dgvRegistrarAlimento.Name = "dgvRegistrarAlimento";
            this.dgvRegistrarAlimento.RowHeadersWidth = 51;
            this.dgvRegistrarAlimento.RowTemplate.Height = 24;
            this.dgvRegistrarAlimento.Size = new System.Drawing.Size(718, 357);
            this.dgvRegistrarAlimento.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGuardar.Location = new System.Drawing.Point(919, 562);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 46);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TipoComida
            // 
            this.TipoComida.HeaderText = "Tipo de comida";
            this.TipoComida.MinimumWidth = 6;
            this.TipoComida.Name = "TipoComida";
            this.TipoComida.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // TotalCalorias
            // 
            this.TotalCalorias.HeaderText = "Calorias";
            this.TotalCalorias.MinimumWidth = 6;
            this.TotalCalorias.Name = "TotalCalorias";
            this.TotalCalorias.Width = 80;
            // 
            // TotalProteinas
            // 
            this.TotalProteinas.HeaderText = "Proteinas";
            this.TotalProteinas.MinimumWidth = 6;
            this.TotalProteinas.Name = "TotalProteinas";
            this.TotalProteinas.Width = 80;
            // 
            // TotalCarbohidratos
            // 
            this.TotalCarbohidratos.HeaderText = "Carbohidratos";
            this.TotalCarbohidratos.MinimumWidth = 6;
            this.TotalCarbohidratos.Name = "TotalCarbohidratos";
            this.TotalCarbohidratos.Width = 110;
            // 
            // Selec
            // 
            this.Selec.HeaderText = "Seleccionar";
            this.Selec.MinimumWidth = 6;
            this.Selec.Name = "Selec";
            this.Selec.Width = 125;
            // 
            // FrmRegistrarAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1097, 627);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRegistrarAlimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarReceta);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrarAlimentos";
            this.Text = "FrmRegistrarAlimentos";
            this.Load += new System.EventHandler(this.FrmRegistrarAlimentos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarAlimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIrRegistrarAlimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIrFeedback;
        private System.Windows.Forms.Button btnIrRegistrarProgreso;
        private System.Windows.Forms.Button btnIrRegistrarPlan;
        private System.Windows.Forms.Button btnIrRegistrarActividad;
        private System.Windows.Forms.TextBox txtBuscarReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegistrarAlimento;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCalorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProteinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCarbohidratos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selec;
    }
}