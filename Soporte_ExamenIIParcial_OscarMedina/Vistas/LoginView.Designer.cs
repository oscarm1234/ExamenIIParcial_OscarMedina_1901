﻿
namespace Soporte_ExamenIIParcial_OscarMedina.Vistas
{
    partial class LoginView
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
            this.bttcancelar = new System.Windows.Forms.Button();
            this.bttaceptar = new System.Windows.Forms.Button();
            this.Txt_Contra = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttcancelar
            // 
            this.bttcancelar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttcancelar.Location = new System.Drawing.Point(294, 130);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(75, 23);
            this.bttcancelar.TabIndex = 17;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            // 
            // bttaceptar
            // 
            this.bttaceptar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttaceptar.Location = new System.Drawing.Point(189, 130);
            this.bttaceptar.Name = "bttaceptar";
            this.bttaceptar.Size = new System.Drawing.Size(75, 23);
            this.bttaceptar.TabIndex = 16;
            this.bttaceptar.Text = "Aceptar";
            this.bttaceptar.UseVisualStyleBackColor = true;
            // 
            // Txt_Contra
            // 
            this.Txt_Contra.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contra.Location = new System.Drawing.Point(211, 70);
            this.Txt_Contra.Name = "Txt_Contra";
            this.Txt_Contra.PasswordChar = '*';
            this.Txt_Contra.Size = new System.Drawing.Size(149, 22);
            this.Txt_Contra.TabIndex = 15;
            this.Txt_Contra.Text = "1234";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(211, 29);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(149, 22);
            this.TxtEmail.TabIndex = 14;
            this.TxtEmail.Text = "oscar@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 220);
            this.Controls.Add(this.bttcancelar);
            this.Controls.Add(this.bttaceptar);
            this.Controls.Add(this.Txt_Contra);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button bttaceptar;
        public System.Windows.Forms.TextBox Txt_Contra;
        public System.Windows.Forms.TextBox TxtEmail;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}