namespace FitMeal.Vista
{
    partial class FrmRegistrarActividad
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnProgreso = new System.Windows.Forms.Button();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnRegistrarActividad = new System.Windows.Forms.Button();
            this.btnRegistrarAlimento = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCalorias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chbCardioAerobico = new System.Windows.Forms.CheckBox();
            this.chbFuerza = new System.Windows.Forms.CheckBox();
            this.chbFlexibilidad = new System.Windows.Forms.CheckBox();
            this.chbDeportes = new System.Windows.Forms.CheckBox();
            this.chbActividadesAireLibre = new System.Windows.Forms.CheckBox();
            this.chbActividadDiaria = new System.Windows.Forms.CheckBox();
            this.grpEjercicio = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.grpEjercicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.btnCalificar);
            this.panel1.Controls.Add(this.btnProgreso);
            this.panel1.Controls.Add(this.btnPlan);
            this.panel1.Controls.Add(this.btnRegistrarActividad);
            this.panel1.Controls.Add(this.btnRegistrarAlimento);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 631);
            this.panel1.TabIndex = 1;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Miskan", 16.2F);
            this.btnPerfil.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnPerfil.Location = new System.Drawing.Point(0, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(286, 155);
            this.btnPerfil.TabIndex = 26;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCalificar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCalificar.Location = new System.Drawing.Point(-3, 541);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(289, 76);
            this.btnCalificar.TabIndex = 11;
            this.btnCalificar.Text = "Calificar Experiencia";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // btnProgreso
            // 
            this.btnProgreso.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgreso.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnProgreso.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnProgreso.Location = new System.Drawing.Point(0, 442);
            this.btnProgreso.Name = "btnProgreso";
            this.btnProgreso.Size = new System.Drawing.Size(289, 76);
            this.btnProgreso.TabIndex = 10;
            this.btnProgreso.Text = "Mi Progreso";
            this.btnProgreso.UseVisualStyleBackColor = false;
            this.btnProgreso.Click += new System.EventHandler(this.btnProgreso_Click);
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPlan.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnPlan.Location = new System.Drawing.Point(-3, 344);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(289, 76);
            this.btnPlan.TabIndex = 9;
            this.btnPlan.Text = "Mi Plan";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnRegistrarActividad
            // 
            this.btnRegistrarActividad.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRegistrarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarActividad.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistrarActividad.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegistrarActividad.Location = new System.Drawing.Point(-4, 252);
            this.btnRegistrarActividad.Name = "btnRegistrarActividad";
            this.btnRegistrarActividad.Size = new System.Drawing.Size(293, 76);
            this.btnRegistrarActividad.TabIndex = 7;
            this.btnRegistrarActividad.Text = "Registrar Actividad";
            this.btnRegistrarActividad.UseVisualStyleBackColor = false;
            this.btnRegistrarActividad.Click += new System.EventHandler(this.btnRegistrarActividad_Click);
            // 
            // btnRegistrarAlimento
            // 
            this.btnRegistrarAlimento.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRegistrarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAlimento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRegistrarAlimento.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegistrarAlimento.Location = new System.Drawing.Point(0, 161);
            this.btnRegistrarAlimento.Name = "btnRegistrarAlimento";
            this.btnRegistrarAlimento.Size = new System.Drawing.Size(286, 76);
            this.btnRegistrarAlimento.TabIndex = 6;
            this.btnRegistrarAlimento.Text = "Registrar Alimento";
            this.btnRegistrarAlimento.UseVisualStyleBackColor = false;
            this.btnRegistrarAlimento.Click += new System.EventHandler(this.btnRegistrarAlimento_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Location = new System.Drawing.Point(1, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 10);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Miskan", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(338, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro Nueva Actividad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(342, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Por favor, completa los siguientes datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(345, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calorias Quemadas:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCalorias
            // 
            this.txtCalorias.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalorias.Location = new System.Drawing.Point(610, 386);
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.Size = new System.Drawing.Size(141, 35);
            this.txtCalorias.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(349, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Duracion Actividad(En horas):";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(745, 435);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(141, 35);
            this.txtDuracion.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(896, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "h";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Miskan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGuardar.Location = new System.Drawing.Point(346, 526);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 46);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(506, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 30);
            this.label8.TabIndex = 19;
            // 
            // chbCardioAerobico
            // 
            this.chbCardioAerobico.AutoSize = true;
            this.chbCardioAerobico.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCardioAerobico.Location = new System.Drawing.Point(18, 72);
            this.chbCardioAerobico.Name = "chbCardioAerobico";
            this.chbCardioAerobico.Size = new System.Drawing.Size(139, 24);
            this.chbCardioAerobico.TabIndex = 20;
            this.chbCardioAerobico.Text = "Cardio/Aerobico";
            this.chbCardioAerobico.UseVisualStyleBackColor = true;
            // 
            // chbFuerza
            // 
            this.chbFuerza.AutoSize = true;
            this.chbFuerza.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.chbFuerza.Location = new System.Drawing.Point(18, 42);
            this.chbFuerza.Name = "chbFuerza";
            this.chbFuerza.Size = new System.Drawing.Size(76, 24);
            this.chbFuerza.TabIndex = 21;
            this.chbFuerza.Text = "Fuerza";
            this.chbFuerza.UseVisualStyleBackColor = true;
            // 
            // chbFlexibilidad
            // 
            this.chbFlexibilidad.AutoSize = true;
            this.chbFlexibilidad.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.chbFlexibilidad.Location = new System.Drawing.Point(304, 42);
            this.chbFlexibilidad.Name = "chbFlexibilidad";
            this.chbFlexibilidad.Size = new System.Drawing.Size(188, 24);
            this.chbFlexibilidad.TabIndex = 22;
            this.chbFlexibilidad.Text = "Flexibilidad y Movilidad";
            this.chbFlexibilidad.UseVisualStyleBackColor = true;
            // 
            // chbDeportes
            // 
            this.chbDeportes.AutoSize = true;
            this.chbDeportes.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.chbDeportes.Location = new System.Drawing.Point(304, 72);
            this.chbDeportes.Name = "chbDeportes";
            this.chbDeportes.Size = new System.Drawing.Size(236, 24);
            this.chbDeportes.TabIndex = 23;
            this.chbDeportes.Text = "Deportes de equipo/Individual";
            this.chbDeportes.UseVisualStyleBackColor = true;
            // 
            // chbActividadesAireLibre
            // 
            this.chbActividadesAireLibre.AutoSize = true;
            this.chbActividadesAireLibre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.chbActividadesAireLibre.Location = new System.Drawing.Point(18, 102);
            this.chbActividadesAireLibre.Name = "chbActividadesAireLibre";
            this.chbActividadesAireLibre.Size = new System.Drawing.Size(189, 24);
            this.chbActividadesAireLibre.TabIndex = 24;
            this.chbActividadesAireLibre.Text = "Activdades al aire libre";
            this.chbActividadesAireLibre.UseVisualStyleBackColor = true;
            // 
            // chbActividadDiaria
            // 
            this.chbActividadDiaria.AutoSize = true;
            this.chbActividadDiaria.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.chbActividadDiaria.Location = new System.Drawing.Point(18, 133);
            this.chbActividadDiaria.Name = "chbActividadDiaria";
            this.chbActividadDiaria.Size = new System.Drawing.Size(201, 24);
            this.chbActividadDiaria.TabIndex = 25;
            this.chbActividadDiaria.Text = "Actividad diaria ocacional";
            this.chbActividadDiaria.UseVisualStyleBackColor = true;
            // 
            // grpEjercicio
            // 
            this.grpEjercicio.Controls.Add(this.chbFuerza);
            this.grpEjercicio.Controls.Add(this.chbCardioAerobico);
            this.grpEjercicio.Controls.Add(this.chbDeportes);
            this.grpEjercicio.Controls.Add(this.chbActividadDiaria);
            this.grpEjercicio.Controls.Add(this.chbFlexibilidad);
            this.grpEjercicio.Controls.Add(this.chbActividadesAireLibre);
            this.grpEjercicio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEjercicio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.grpEjercicio.Location = new System.Drawing.Point(346, 172);
            this.grpEjercicio.Name = "grpEjercicio";
            this.grpEjercicio.Size = new System.Drawing.Size(649, 177);
            this.grpEjercicio.TabIndex = 26;
            this.grpEjercicio.TabStop = false;
            this.grpEjercicio.Text = "Tipo De Ejercicio:";
            // 
            // FrmRegistrarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1097, 631);
            this.Controls.Add(this.grpEjercicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRegistrarActividad";
            this.Text = "FrmRegistrarActividad";
            this.panel1.ResumeLayout(false);
            this.grpEjercicio.ResumeLayout(false);
            this.grpEjercicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnProgreso;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Button btnRegistrarActividad;
        private System.Windows.Forms.Button btnRegistrarAlimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCalorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbCardioAerobico;
        private System.Windows.Forms.CheckBox chbFuerza;
        private System.Windows.Forms.CheckBox chbFlexibilidad;
        private System.Windows.Forms.CheckBox chbDeportes;
        private System.Windows.Forms.CheckBox chbActividadesAireLibre;
        private System.Windows.Forms.CheckBox chbActividadDiaria;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.GroupBox grpEjercicio;
    }
}