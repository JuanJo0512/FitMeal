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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCarb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totProt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Todos",
            "Desayuno",
            "Almuerzo ",
            "Cena",
            "Snack"});
            this.comboBox1.Location = new System.Drawing.Point(615, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 24);
            this.comboBox1.TabIndex = 34;
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
            // dataGridView1
            // 
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
            // 
            // comida
            // 
            this.comida.HeaderText = "Comida";
            this.comida.MinimumWidth = 6;
            this.comida.Name = "comida";
            this.comida.ReadOnly = true;
            this.comida.Width = 185;
            // 
            // totCal
            // 
            this.totCal.HeaderText = "Calorias";
            this.totCal.MinimumWidth = 6;
            this.totCal.Name = "totCal";
            this.totCal.ReadOnly = true;
            this.totCal.Width = 125;
            // 
            // totCarb
            // 
            this.totCarb.HeaderText = "Carbohidratos";
            this.totCarb.MinimumWidth = 6;
            this.totCarb.Name = "totCarb";
            this.totCarb.ReadOnly = true;
            this.totCarb.Width = 125;
            // 
            // totProt
            // 
            this.totProt.HeaderText = "Proteinas";
            this.totProt.MinimumWidth = 6;
            this.totProt.Name = "totProt";
            this.totProt.ReadOnly = true;
            this.totProt.Width = 125;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnguardar.Location = new System.Drawing.Point(346, 564);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(152, 58);
            this.btnguardar.TabIndex = 54;
            this.btnguardar.Text = "Generar Plan";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.OliveDrab;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(825, 560);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 58);
            this.button7.TabIndex = 55;
            this.button7.Text = "Aprovar Plan";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // FrmMiPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1085, 633);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMiPlan";
            this.Text = "FrmMiPlan";
            this.Load += new System.EventHandler(this.FrmMiPlan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCarb;
        private System.Windows.Forms.DataGridViewTextBoxColumn totProt;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button7;
    }
}