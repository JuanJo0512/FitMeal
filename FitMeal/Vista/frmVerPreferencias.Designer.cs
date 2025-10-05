namespace FitMeal.Vista
{
    partial class frmVerPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPreferencias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dtgPreferencias = new System.Windows.Forms.DataGridView();
            this.dtgAlergias = new System.Windows.Forms.DataGridView();
            this.preferenciaAlimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlimentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergiaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlergiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreferencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlergias)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 631);
            this.panel1.TabIndex = 2;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Miskan", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBox1.Location = new System.Drawing.Point(334, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(462, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mis Preferencias";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNombre.Location = new System.Drawing.Point(459, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(192, 38);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre aqui";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(417, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Preferencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(812, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Alergias";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnIngreso.Location = new System.Drawing.Point(769, 43);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(230, 42);
            this.btnIngreso.TabIndex = 34;
            this.btnIngreso.Text = "Editar Preferencias";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Goldenrod;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(758, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(250, 42);
            this.button7.TabIndex = 35;
            this.button7.Text = "Eliminar Preferencias";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtgPreferencias
            // 
            this.dtgPreferencias.AllowUserToAddRows = false;
            this.dtgPreferencias.AllowUserToDeleteRows = false;
            this.dtgPreferencias.AllowUserToResizeColumns = false;
            this.dtgPreferencias.AllowUserToResizeRows = false;
            this.dtgPreferencias.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgPreferencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPreferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPreferencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preferenciaAlimento,
            this.AlimentoID});
            this.dtgPreferencias.GridColor = System.Drawing.Color.Cornsilk;
            this.dtgPreferencias.Location = new System.Drawing.Point(347, 232);
            this.dtgPreferencias.Name = "dtgPreferencias";
            this.dtgPreferencias.ReadOnly = true;
            this.dtgPreferencias.RowHeadersWidth = 51;
            this.dtgPreferencias.RowTemplate.Height = 24;
            this.dtgPreferencias.Size = new System.Drawing.Size(361, 345);
            this.dtgPreferencias.TabIndex = 36;
            // 
            // dtgAlergias
            // 
            this.dtgAlergias.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dtgAlergias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgAlergias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlergias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alergiaNombre,
            this.AlergiaID});
            this.dtgAlergias.GridColor = System.Drawing.Color.Cornsilk;
            this.dtgAlergias.Location = new System.Drawing.Point(769, 232);
            this.dtgAlergias.Name = "dtgAlergias";
            this.dtgAlergias.ReadOnly = true;
            this.dtgAlergias.RowHeadersWidth = 51;
            this.dtgAlergias.RowTemplate.Height = 24;
            this.dtgAlergias.Size = new System.Drawing.Size(256, 345);
            this.dtgAlergias.TabIndex = 37;
            // 
            // preferenciaAlimento
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.preferenciaAlimento.DefaultCellStyle = dataGridViewCellStyle9;
            this.preferenciaAlimento.HeaderText = "Alimentos excluidos";
            this.preferenciaAlimento.MinimumWidth = 10;
            this.preferenciaAlimento.Name = "preferenciaAlimento";
            this.preferenciaAlimento.ReadOnly = true;
            this.preferenciaAlimento.Width = 200;
            // 
            // AlimentoID
            // 
            this.AlimentoID.HeaderText = "ID";
            this.AlimentoID.MinimumWidth = 6;
            this.AlimentoID.Name = "AlimentoID";
            this.AlimentoID.ReadOnly = true;
            this.AlimentoID.Visible = false;
            this.AlimentoID.Width = 125;
            // 
            // alergiaNombre
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.alergiaNombre.DefaultCellStyle = dataGridViewCellStyle7;
            this.alergiaNombre.HeaderText = "Alergia";
            this.alergiaNombre.MinimumWidth = 6;
            this.alergiaNombre.Name = "alergiaNombre";
            this.alergiaNombre.ReadOnly = true;
            this.alergiaNombre.Width = 110;
            // 
            // AlergiaID
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.AlergiaID.DefaultCellStyle = dataGridViewCellStyle8;
            this.AlergiaID.HeaderText = "ID";
            this.AlergiaID.MinimumWidth = 6;
            this.AlergiaID.Name = "AlergiaID";
            this.AlergiaID.ReadOnly = true;
            this.AlergiaID.Visible = false;
            this.AlergiaID.Width = 125;
            // 
            // frmVerPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1093, 630);
            this.Controls.Add(this.dtgAlergias);
            this.Controls.Add(this.dtgPreferencias);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerPreferencias";
            this.Text = "frmVerPreferencias";
            this.Load += new System.EventHandler(this.frmVerPreferencias_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPreferencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlergias)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dtgPreferencias;
        private System.Windows.Forms.DataGridView dtgAlergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn preferenciaAlimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlimentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergiaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlergiaID;
    }
}