
namespace Presentacion
{
    partial class Menu
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
            this.Header = new System.Windows.Forms.Panel();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVacunaciones = new System.Windows.Forms.Button();
            this.btnCentros = new System.Windows.Forms.Button();
            this.Pacientes = new System.Windows.Forms.Button();
            this.btnVacunas = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(184, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(820, 55);
            this.Header.TabIndex = 0;
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.White;
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(184, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(820, 636);
            this.Wrapper.TabIndex = 1;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Black;
            this.SideBar.Controls.Add(this.btnCentros);
            this.SideBar.Controls.Add(this.Pacientes);
            this.SideBar.Controls.Add(this.btnVacunas);
            this.SideBar.Controls.Add(this.btnVacunaciones);
            this.SideBar.Controls.Add(this.label1);
            this.SideBar.Controls.Add(this.Logo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(184, 636);
            this.SideBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "VACUNACIONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources._61155;
            this.pictureBox1.Location = new System.Drawing.Point(775, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Presentacion.Properties.Resources.logoUser;
            this.Logo.Location = new System.Drawing.Point(16, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADMIN";
            // 
            // btnVacunaciones
            // 
            this.btnVacunaciones.BackColor = System.Drawing.Color.Black;
            this.btnVacunaciones.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacunaciones.ForeColor = System.Drawing.Color.White;
            this.btnVacunaciones.Location = new System.Drawing.Point(28, 164);
            this.btnVacunaciones.Name = "btnVacunaciones";
            this.btnVacunaciones.Size = new System.Drawing.Size(126, 39);
            this.btnVacunaciones.TabIndex = 3;
            this.btnVacunaciones.Text = "VACUNACION";
            this.btnVacunaciones.UseVisualStyleBackColor = false;
            this.btnVacunaciones.Click += new System.EventHandler(this.btnVacunaciones_Click);
            // 
            // btnCentros
            // 
            this.btnCentros.BackColor = System.Drawing.Color.Black;
            this.btnCentros.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentros.ForeColor = System.Drawing.Color.White;
            this.btnCentros.Location = new System.Drawing.Point(28, 344);
            this.btnCentros.Name = "btnCentros";
            this.btnCentros.Size = new System.Drawing.Size(126, 39);
            this.btnCentros.TabIndex = 6;
            this.btnCentros.Text = "CENTROS";
            this.btnCentros.UseVisualStyleBackColor = false;
            this.btnCentros.Click += new System.EventHandler(this.btnCentros_Click);
            // 
            // Pacientes
            // 
            this.Pacientes.BackColor = System.Drawing.Color.Black;
            this.Pacientes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pacientes.ForeColor = System.Drawing.Color.White;
            this.Pacientes.Location = new System.Drawing.Point(28, 284);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Size = new System.Drawing.Size(126, 39);
            this.Pacientes.TabIndex = 5;
            this.Pacientes.Text = "PACIENTES";
            this.Pacientes.UseVisualStyleBackColor = false;
            this.Pacientes.Click += new System.EventHandler(this.Pacientes_Click);
            // 
            // btnVacunas
            // 
            this.btnVacunas.BackColor = System.Drawing.Color.Black;
            this.btnVacunas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacunas.ForeColor = System.Drawing.Color.White;
            this.btnVacunas.Location = new System.Drawing.Point(28, 223);
            this.btnVacunas.Name = "btnVacunas";
            this.btnVacunas.Size = new System.Drawing.Size(126, 39);
            this.btnVacunas.TabIndex = 4;
            this.btnVacunas.Text = "VACUNAS";
            this.btnVacunas.UseVisualStyleBackColor = false;
            this.btnVacunas.Click += new System.EventHandler(this.btnVacunas_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1004, 636);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVacunaciones;
        private System.Windows.Forms.Button btnCentros;
        private System.Windows.Forms.Button Pacientes;
        private System.Windows.Forms.Button btnVacunas;
    }
}