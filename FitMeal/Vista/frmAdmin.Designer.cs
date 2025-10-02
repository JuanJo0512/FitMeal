namespace FitMeal.Vista
{
    partial class FrmAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.brnSalir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Controls.Add(this.brnSalir);
            this.panel2.Controls.Add(this.btnRecetas);
            this.panel2.Controls.Add(this.btnAlimentos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(94, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 372);
            this.panel2.TabIndex = 9;
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlimentos.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAlimentos.Location = new System.Drawing.Point(128, 218);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(131, 39);
            this.btnAlimentos.TabIndex = 6;
            this.btnAlimentos.Text = "Alimentos";
            this.btnAlimentos.UseVisualStyleBackColor = false;
            this.btnAlimentos.Click += new System.EventHandler(this.btnAlimentos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(40, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(122, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indique que desea gestionar";
            // 
            // btnRecetas
            // 
            this.btnRecetas.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetas.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRecetas.Location = new System.Drawing.Point(349, 218);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(131, 39);
            this.btnRecetas.TabIndex = 7;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = false;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // brnSalir
            // 
            this.brnSalir.BackColor = System.Drawing.Color.OliveDrab;
            this.brnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSalir.ForeColor = System.Drawing.Color.Cornsilk;
            this.brnSalir.Location = new System.Drawing.Point(236, 307);
            this.brnSalir.Name = "brnSalir";
            this.brnSalir.Size = new System.Drawing.Size(131, 39);
            this.brnSalir.TabIndex = 8;
            this.brnSalir.Text = "Salir";
            this.brnSalir.UseVisualStyleBackColor = false;
            this.brnSalir.Click += new System.EventHandler(this.brnSalir_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnSalir;
    }
}