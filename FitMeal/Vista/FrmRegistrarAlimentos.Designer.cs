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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIrRegistrarAlimento = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnIrFeedback = new System.Windows.Forms.Button();
            this.btnIrRegistrarProgreso = new System.Windows.Forms.Button();
            this.btnIrRegistrarPlan = new System.Windows.Forms.Button();
            this.btnIrRegistrarActividad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totCarb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totProt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selec = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnPerfil.Font = new System.Drawing.Font("Miskan", 16.2F);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(524, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 35);
            this.textBox1.TabIndex = 1;
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
            this.totProt,
            this.Selec});
            this.dataGridView1.Location = new System.Drawing.Point(332, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 417);
            this.dataGridView1.TabIndex = 4;
            // 
            // comida
            // 
            this.comida.HeaderText = "Comida";
            this.comida.MinimumWidth = 6;
            this.comida.Name = "comida";
            this.comida.Width = 185;
            // 
            // totCal
            // 
            this.totCal.HeaderText = "Calorias";
            this.totCal.MinimumWidth = 6;
            this.totCal.Name = "totCal";
            this.totCal.Width = 125;
            // 
            // totCarb
            // 
            this.totCarb.HeaderText = "Carbohidratos";
            this.totCarb.MinimumWidth = 6;
            this.totCarb.Name = "totCarb";
            this.totCarb.Width = 125;
            // 
            // totProt
            // 
            this.totProt.HeaderText = "Proteinas";
            this.totProt.MinimumWidth = 6;
            this.totProt.Name = "totProt";
            this.totProt.Width = 125;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrarAlimentos";
            this.Text = "FrmRegistrarAlimentos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn totCarb;
        private System.Windows.Forms.DataGridViewTextBoxColumn totProt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selec;
    }
}